#!/usr/bin/env bash
set -euo pipefail

source -- ./common.sh
ensure_script_dir

# Create rawdata directory structure
mkdir -p rawdata/preprocess
mkdir -p rawdata/compute/log-single/0
mkdir -p rawdata/compute/log-mpc-2t/0
mkdir -p rawdata/compute/log-mpc-4t/0
mkdir -p rawdata/compute/log-mpc-8t/0
mkdir -p rawdata/compute/log-mpc-16t/0
mkdir -p rawdata/zkp/log-single/0
mkdir -p rawdata/zkp/log-mpc-2t/0
mkdir -p rawdata/zkp/log-mpc-4t/0
mkdir -p rawdata/zkp/log-mpc-8t/0

# Copy files, skip if source doesn't exist or is empty
cp -r preprocess-scripts/*.txt rawdata/preprocess/ || true
cp -r run/1/log/0/*.txt rawdata/compute/log-single/0/ || true
cp -r run/2/log/0/*.txt rawdata/compute/log-mpc-2t/0/ || true
cp -r run/4/log/0/*.txt rawdata/compute/log-mpc-4t/0/ || true
cp -r run/8/log/0/*.txt rawdata/compute/log-mpc-8t/0/ || true
cp -r run/16/log/0/*.txt rawdata/compute/log-mpc-16t/0/ || true
cp -r run/1/r1cs/0/*.std* rawdata/zkp/log-single/0/ || true
cp -r run/2/r1cs/0/*.std* rawdata/zkp/log-mpc-2t/0/ || true
cp -r run/4/r1cs/0/*.std* rawdata/zkp/log-mpc-4t/0/ || true
cp -r run/8/r1cs/0/*.std* rawdata/zkp/log-mpc-8t/0/ || true

echo Done. Please check the folder \"rawdata\".