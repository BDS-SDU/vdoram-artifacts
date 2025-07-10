using HuayiQi.CompatCircuitCore.BinarySerialization;

namespace HuayiQi.CompatCircuitCore.MultiPartyComputationPrimitives;
public class GeneralBinaryDecodableFileEnumerator<T> : FileEnumeratorBase<T> where T : IGeneralBinaryDecodable<T>, IBinaryEncodable {
    public GeneralBinaryDecodableFileEnumerator(Stream stream) : base(stream) { }
    protected override T FromEncodedBytes(ReadOnlySpan<byte> buffer, out int bytesRead) => T.FromEncodedBytes(buffer, out bytesRead);
}
