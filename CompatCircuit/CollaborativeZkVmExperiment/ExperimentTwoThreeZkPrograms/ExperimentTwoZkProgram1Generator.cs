using HuayiQi.CollaborativeZkVm.ZkPrograms;
using HuayiQi.CollaborativeZkVm.ZkVmCircuits;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentTwoThreeZkPrograms;
public class ExperimentTwoZkProgram1Generator : ExperimentTwoThreeZkProgramGeneratorBase {
    protected override string CodeName => "exp2_1";
    protected override ZkProgramOpcode GetNewOp(int step) => NewOp(ZkVmOpType.Mul, 0, 0, 0);
}
