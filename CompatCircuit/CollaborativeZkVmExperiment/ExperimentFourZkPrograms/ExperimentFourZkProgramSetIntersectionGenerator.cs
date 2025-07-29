using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramSetIntersecionGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_intersection";
    protected override ZkProgramExample ZkProgramExample { get; } = new SetIntersectionProgramGenerator().GetZkProgram();
}