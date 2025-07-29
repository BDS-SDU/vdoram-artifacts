using HuayiQi.CollaborativeZkVm.ZkPrograms.Examples;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentFourZkPrograms;
public class ExperimentFourZkProgramRangeQueryGenerator : ExperimentFourZkProgramGeneratorBase {
    protected override string CodeNameOverride { get; } = "exp4_range";
    protected override ZkProgramExample ZkProgramExample { get; } = new RangeQueryProgramGenerator().GetZkProgram();

}