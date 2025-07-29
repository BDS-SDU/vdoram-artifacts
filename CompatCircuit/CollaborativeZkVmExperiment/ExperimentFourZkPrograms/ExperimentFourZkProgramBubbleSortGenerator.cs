using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramBubbleSortGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_bubble";
    protected override ZkProgramExample ZkProgramExample { get; } = new BubbleSortProgramGenerator().GetZkProgram();
}