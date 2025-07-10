using HuayiQi.CompatCircuitCore.Arithmetic;
using HuayiQi.CompatCircuitCore.MultiPartyComputationPrimitives;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentRandomPublicInputGenerators;
public class ExperimentRandomPublicInputFileEnumerator : ArithFactoryBinaryDecodableFileEnumerator<Field, Field> {
    public ExperimentRandomPublicInputFileEnumerator(Stream stream, IArithFactory<Field> factory) : base(stream, factory) { }
}
