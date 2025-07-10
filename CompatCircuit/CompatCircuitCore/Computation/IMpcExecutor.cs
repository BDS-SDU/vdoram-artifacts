using HuayiQi.CompatCircuitCore.Arithmetic;
using HuayiQi.CompatCircuitCore.CompatCircuits.MpcCircuits;
using HuayiQi.CompatCircuitCore.MultiPartyComputationPrimitives;

namespace HuayiQi.CompatCircuitCore.Computation;
public interface IMpcExecutor {
    public Task<CircuitExecuteResult> Compute(MpcCircuit mpcCircuit, IReadOnlyDictionary<int, Field> publicInputValueDict, IReadOnlyDictionary<int, MpcValue> privateInputValueShareDict);
}