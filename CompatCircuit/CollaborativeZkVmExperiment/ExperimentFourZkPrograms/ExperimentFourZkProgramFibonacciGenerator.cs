using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramFibonacciGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_fib";
    protected override ZkProgramExample ZkProgramExample { get; } = new FibonacciProgramGenerator().GetZkProgram();
}
