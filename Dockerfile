FROM ubuntu:24.04

# Check architecture.
RUN if [ "$(uname -m)" != "x86_64" ]; then \
        echo "Error: Architecture is not x86_64 (amd64)." >&2; \
        exit 1; \
    fi

# Update and install dependencies.
RUN apt-get update && \
    apt-get full-upgrade -y && \
    apt-get install -y nano dotnet-sdk-8.0 build-essential curl tmux tar xz-utils openssh-client git unzip dos2unix jq htop python3 haveged pkg-config libssl-dev openssh-server sudo gosu

# Create non-root user 'user' with sudo privileges.
RUN mkdir -p /etc/sudoers.d && \
    useradd -m -s /bin/bash user && \
    usermod -aG sudo user && \
    echo "user ALL=(ALL) NOPASSWD:ALL" > /etc/sudoers.d/user && \
    chmod 0440 /etc/sudoers.d/user

# Prepare SSH server directory.
RUN mkdir -p /var/run/sshd

# Generate SSH host keys.
RUN ssh-keygen -A

# Switch to user 'user'.
USER user
WORKDIR /home/user

# Install Rust nightly toolchain.
RUN curl --proto '=https' --tlsv1.3 https://sh.rustup.rs -sSf | sh -s -- --default-toolchain nightly -y

# Add Cargo to PATH.
ENV PATH="/home/user/.cargo/bin:${PATH}"

# Source .bashrc to apply environment variables.
RUN echo "source ~/.bashrc" >> ~/.bash_profile

# Copy repository contents.
COPY . vdoram-artifacts

# Set user write permissions for vdoram-artifacts.
USER root
RUN chown -R user:user /home/user/vdoram-artifacts && \
    chmod -R u+rw /home/user/vdoram-artifacts

# Switch back to user 'user'.
USER user

# Build the Rust client.
RUN (cd /home/user/vdoram-artifacts/collaborative-zksnark-mod/mpc-snarks && \
    cargo build --release --bin client)

# Build the dotnet client.
RUN (cd /home/user/vdoram-artifacts/CompatCircuit && \
    dotnet build CollaborativeZkVmExperiment -c Release -r linux-x64 && \
    dotnet build CollaborativeZkVmExperiment -c Release)

# Use config-e1-n1.sh by default.
RUN (cd /home/user/vdoram-artifacts/CompatCircuit/Experiments/scripts && \
    cp config-e1-n1.sh config.sh)

# Set up local SSH access.
RUN mkdir -p /home/user/.ssh && \
    ssh-keygen -t ed25519 -f /home/user/.ssh/id_ed25519 -N "" && \
    cat /home/user/.ssh/id_ed25519.pub >> /home/user/.ssh/authorized_keys && \
    chmod 600 /home/user/.ssh/authorized_keys

# Preload the ssh function in .bashrc.
RUN echo 'function ssh() {' >> ~/.bashrc && \
    echo '    command ssh -o "StrictHostKeyChecking no" -o "UserKnownHostsFile /dev/null" "$@"' >> ~/.bashrc && \
    echo '}' >> ~/.bashrc

# Preload the scp function in .bashrc.
RUN echo 'function scp() {' >> ~/.bashrc && \
    echo '    command scp -o "StrictHostKeyChecking no" -o "UserKnownHostsFile /dev/null" "$@"' >> ~/.bashrc && \
    echo '}' >> ~/.bashrc

# Create and configure entrypoint script.
USER root
RUN echo '#!/bin/bash' > /entrypoint.sh && \
    echo '/usr/sbin/sshd &' >> /entrypoint.sh && \
    echo 'nohup haveged -F >/home/user/haveged.log 2>&1 &' >> /entrypoint.sh && \
    echo 'exec gosu user bash -c "source ~/.bashrc && /bin/bash"' >> /entrypoint.sh && \
    chmod +x /entrypoint.sh

# Set entrypoint.
ENTRYPOINT ["/entrypoint.sh"]