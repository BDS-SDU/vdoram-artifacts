using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramIncreasingSubsequenceGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_increasing";
    protected override ZkProgramExample ZkProgramExample { get; } = new LongestContinuousIncreasingSubsequenceProgramGenerator().GetZkProgram();
}