# VDORAM Artifacts

This repository contains artifacts for the paper "VDORAM: Towards a Random Access Machine with Both Public Verifiability and Distributed Obliviousness." The code is primarily intended for academic research.

For setup and evaluation, refer to the [Artifact Evaluation Step-by-Step Guide](CompatCircuit/Experiments/README.md).

## CompatCircuit
The core contribution of the paper, featuring (to our best knowledge):
- **CompatCircuit**: The first multi-prover ZKP frontend designed for collaborative zkSNARKs.
- **VDORAM**: The first multi-prover zkVM implementation.

## collaborative-zksnark-mod
A modified version of `collaborative-zksnark` that integrates with CompatCircuit. This component generates proofs where the private inputs (outputs of CompatCircuit computations) are secretly shared among all parties.

## rawdata
Experimentally collected datasets that reproduce the figures in the submitted manuscript when used with the provided CompatCircuit source code.
