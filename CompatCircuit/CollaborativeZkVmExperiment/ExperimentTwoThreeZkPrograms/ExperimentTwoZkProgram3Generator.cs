using HuayiQi.CollaborativeZkVm.ZkPrograms;
using HuayiQi.CollaborativeZkVm.ZkVmCircuits;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentTwoThreeZkPrograms;
public class ExperimentTwoZkProgram3Generator : ExperimentTwoThreeZkProgramGeneratorBase {
    protected override string CodeName => "exp2_3";
    protected override ZkProgramOpcode GetNewOp(int step) => NewOp(ZkVmOpType.Hash, 0, 0, 0);
}
