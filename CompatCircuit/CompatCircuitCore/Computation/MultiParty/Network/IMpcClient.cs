using HuayiQi.CompatCircuitCore.Computation.MultiParty.Messages;

namespace HuayiQi.CompatCircuitCore.Computation.MultiParty.Network;
public interface IMpcClient {
    public void Start();
    public void Stop();
    public void BroadcastMessage(RawMessage message);
    public void SendMessage(int receiverIndex, RawMessage message);
    public event EventHandler<RawMessage>? OnMessageReceived;
}
