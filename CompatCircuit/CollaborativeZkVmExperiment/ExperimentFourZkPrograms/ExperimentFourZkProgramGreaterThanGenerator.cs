using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramGreaterThanGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_greater";
    protected override ZkProgramExample ZkProgramExample { get; } = new GreaterThanZkProgramGenerator().GetZkProgram();
}