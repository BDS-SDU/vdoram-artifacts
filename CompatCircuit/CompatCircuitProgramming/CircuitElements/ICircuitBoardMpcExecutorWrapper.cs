using HuayiQi.CompatCircuitCore.Arithmetic;
using HuayiQi.CompatCircuitCore.CompatCircuits.R1csCircuits;
using HuayiQi.CompatCircuitCore.Computation;
using HuayiQi.CompatCircuitCore.MultiPartyComputationPrimitives;

namespace HuayiQi.CompatCircuitProgramming.CircuitElements;
public interface ICircuitBoardMpcExecutorWrapper {
    public void AddPublic(string wireName, Field value);
    public void AddPrivate(string wireName, MpcValue value);
    public Task<CircuitExecuteResult> Compute();
    public MpcValue GetOutput(string wireName);
    public R1csCircuitWithValues GetR1csCircuitWithValues();
}
