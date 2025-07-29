using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramSlidingWindowGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_slide";
    protected override ZkProgramExample ZkProgramExample { get; } = new SlidingWindowProgramGenerator().GetZkProgram();
}