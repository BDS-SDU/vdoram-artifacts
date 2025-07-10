using HuayiQi.CompatCircuitCore.BinarySerialization;

namespace HuayiQi.CompatCircuitCore.Computation.MultiParty.Network.NetMessages;
public interface INetMessagePayload<T> : IBinaryEncodable, IGeneralBinaryDecodable<T> where T : INetMessagePayload<T> {
    public static abstract byte MessagePayloadTypeID { get; }
}