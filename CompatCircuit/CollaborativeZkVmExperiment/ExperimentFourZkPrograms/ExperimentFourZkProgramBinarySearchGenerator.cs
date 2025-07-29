using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramBinarySearchGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_binary";
    protected override ZkProgramExample ZkProgramExample { get; } = new BinarySearchProgramGenerator().GetZkProgram();
}