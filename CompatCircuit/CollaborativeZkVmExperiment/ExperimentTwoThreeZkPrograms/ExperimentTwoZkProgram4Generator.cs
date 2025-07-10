using HuayiQi.CollaborativeZkVm.ZkPrograms;
using HuayiQi.CollaborativeZkVm.ZkVmCircuits;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentTwoThreeZkPrograms;
public class ExperimentTwoZkProgram4Generator : ExperimentTwoThreeZkProgramGeneratorBase {
    protected override string CodeName => "exp2_4";
    protected override ZkProgramOpcode GetNewOp(int step) => NewOp(ZkVmOpType.Store, 0, 0, 0);
}
