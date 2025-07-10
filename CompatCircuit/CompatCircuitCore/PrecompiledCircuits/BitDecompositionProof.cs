using HuayiQi.CompatCircuitCore.CompatCircuits;
using HuayiQi.CompatCircuitCore.CompatCircuits.BasicCircuits;
using HuayiQi.CompatCircuitCore.Extensions;
using HuayiQi.CompatCircuitCore.GlobalConfig;

namespace HuayiQi.CompatCircuitCore.PrecompiledCircuits;
public static class BitDecompositionProof {
    public static BasicCircuit Circuit { get; }
    public static CompatCircuitSymbols CompatCircuitSymbols { get; }

    static BitDecompositionProof() {
        using (MemoryStream stream = new(Resources.BitDecompositionProofCircuitFile)) {
            CompatCircuit CompatCircuit = CompatCircuitSerializer.Deserialize(stream);
            Circuit = new BasicCircuit(CompatCircuit);
        }
        using (MemoryStream stream = new(Resources.BitDecompositionProofCircuitSymbolsFile)) {
            CompatCircuitSymbols = JsonSerializerHelper.Deserialize<CompatCircuitSymbols>(stream, JsonConfig.JsonSerializerOptions) ?? throw new Exception("Failed to deserialize CompatCircuitSymbols.");
        }
    }
}
