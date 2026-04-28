#!/usr/bin/env bash
set -euo pipefail

# Check 1: Verify client executable exists
if [ ! -f "./target/release/client" ]; then
    echo "Error: Client executable not found at ./target/release/client"
    echo "Please build the client first with 'cargo build --release'"
    exit 1
fi

# Check 2: Detect processes with exact name 'client' (not just containing "client")
existing_clients=$(pgrep -x "client" 2>/dev/null || echo "")
if [ -n "${existing_clients:-}" ]; then
    echo "Error: Found $existing_clients processes named exactly 'client':"
    pgrep -xa "client"
    echo "Please stop these processes first."
    exit 1
fi

# Read the party number
while true; do
    read -p "Enter party number (1, 2, 4, or 8): " party_number
    
    # Check if input is one of the allowed values
    if [[ "$party_number" =~ ^(1|2|4|8)$ ]]; then
        echo "Valid party number: $party_number"
        break
    else
        echo "Invalid input. Please enter only 1, 2, 4, or 8."
    fi
done

# Read input size (positive integer)
while true; do
    read -p "Enter input size (positive integer, e.g., 1, 15, 1024, or 12341): " input_size
    
    if [[ "$input_size" =~ ^[1-9][0-9]*$ ]]; then
        break
    else
        echo "Invalid input. Please enter a positive integer."
    fi
done

# Check if party number is 1
if [ "$party_number" -eq 1 ]; then
    echo "Party number is 1 - executing local computation"
    
    unset TMUX
    echo Start a new TMUX session for party 0
    tmux new-session -d "tmux setw remain-on-exit on; ./target/release/client --hosts data/${party_number} -d PlonkSquaringLocal ${input_size} --party 0 | tee -a squaring_n${party_number}_input${input_size}_party0.log"
else
    echo "Party number is $party_number - executing multi-party computation"

    unset TMUX
    
    for ((i=0; i<party_number; i++)); do
        echo Start a new TMUX session for party "$i"
        tmux new-session -d "tmux setw remain-on-exit on; ./target/release/client --hosts data/${party_number} -d PlonkSquaringMultiParty ${input_size} --party ${i} | tee -a squaring_n${party_number}_input${input_size}_party${i}.log"
    done
fi

echo "Started. Please observe logs by 'tail -f squaring_n${party_number}_input${input_size}_party0.log'"
