using HuayiQi.CompatCircuitCore.BinarySerialization;

namespace HuayiQi.CompatCircuitCore.Computation.MultiParty.Messages;
public interface IMessagePayload<T> : IBinaryEncodable, IGeneralBinaryDecodable<T> where T : IMessagePayload<T> {
    public static abstract byte MessagePayloadTypeID { get; }
}
