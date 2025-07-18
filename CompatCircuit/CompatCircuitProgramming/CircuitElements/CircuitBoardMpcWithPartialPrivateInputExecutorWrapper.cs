﻿using HuayiQi.CompatCircuitCore.Arithmetic;
using HuayiQi.CompatCircuitCore.CompatCircuits;
using HuayiQi.CompatCircuitCore.Computation;
using HuayiQi.CompatCircuitCore.Computation.MultiParty;
using HuayiQi.CompatCircuitCore.Extensions;
using HuayiQi.CompatCircuitCore.MultiPartyComputationPrimitives;

namespace HuayiQi.CompatCircuitProgramming.CircuitElements;
public class CircuitBoardMpcWithPartialPrivateInputExecutorWrapper : CircuitBoardExecutorWrapperBase<Field> {
    protected MpcExecutor CircuitExecutor { get; }

    public CircuitBoardMpcWithPartialPrivateInputExecutorWrapper(CompatCircuit compatCircuit, CompatCircuitSymbols compatCircuitSymbols, MpcExecutor circuitExecutor)
        : base(compatCircuit, compatCircuitSymbols) => this.CircuitExecutor = circuitExecutor;

    public async Task Compute() => await AsyncHelper.TerminateOnException(async () => {
        if (this.ExecuteResult is not null) {
            throw new Exception("Compute() can be called only once");
        }
        this.ExecuteResult = await this.CircuitExecutor.Compute(this.MpcCircuit, this.PublicInputValues, this.PrivateInputValues);
        this.CheckExecuteResult(this.ExecuteResult);
    });

    protected virtual void CheckExecuteResult(CircuitExecuteResult executeResult) {
        for (int i = 0; i < executeResult.ValueBoard.Count; i++) {
            if (executeResult.ValueBoard[i] is null) {
                throw new Exception($"Wire {i} should not be null");
            }
        }
    }

    public MpcValue GetOutput(string wireName) =>
        this.ExecuteResult is null ? throw new Exception("Please call Compute() first") :
        this.ExecuteResult.ValueBoard[this.GetWireID(wireName)] ?? throw new Exception($"Output wire {wireName} is null");
}

