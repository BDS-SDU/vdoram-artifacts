# Artifact Evaluation Guide (Docker)

This document supplements the `Artifact Evaluation Step-By-Step Guide` by providing specific instructions for running the experiments via Docker on Linux.

## I. Preparation

This section replaces the `I. Preparation` section in the `Artifact Evaluation Step-By-Step Guide`.

### Install Docker

First, install Docker on your Linux system:
```bash
sudo apt update && sudo apt install docker.io
```

To verify that the Docker daemon is running, execute the following command:
```bash
sudo docker ps
```

### 2. Source Code Acquisition

The subsequent step is to acquire the artifact's source code. The repository should be cloned into the user's home directory. This guide assumes the destination directory is `~/vdoram-artifacts`.

```bash
cd ~
git clone https://github.com/BDS-SDU/vdoram-artifacts vdoram-artifacts
cd vdoram-artifacts
```

### 3. Build the Docker image

Build the Docker image using the following command:
```bash
sudo docker build -t vdoram-env .
```

### 4. Run the Docker image

Finally, run the Docker image to start an interactive Bash shell:
```bash
sudo docker run -it vdoram-env
```

```
user@08b2006b5f47:~$ ls
haveged.log  vdoram-artifacts
user@08b2006b5f47:~$ cd vdoram-artifacts/CompatCircuit/Experiments/scripts/
user@08b2006b5f47:~/vdoram-artifacts/CompatCircuit/Experiments/scripts$ 
```

## II. Running the Experiments

You are now ready to proceed with the experiment setup and execution. Follow the instructions starting from **Section II. Project Compilation** in the `Artifact Evaluation Step-By-Step Guide` to continue.
