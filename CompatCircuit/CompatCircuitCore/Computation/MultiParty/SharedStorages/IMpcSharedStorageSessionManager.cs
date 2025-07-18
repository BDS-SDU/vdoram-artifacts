﻿using HuayiQi.CompatCircuitCore.Computation.MultiParty.Messages;
using HuayiQi.CompatCircuitCore.Computation.MultiParty.Network;

namespace HuayiQi.CompatCircuitCore.Computation.MultiParty.SharedStorages;
public interface IMpcSharedStorageSessionManager {
    public void HandleRawMessage(RawMessage message);
    public void RegisterSession(int sessionID, IMpcSharedStorage sharedStorage);
    public void UnregisterSession(int sessionID);
    public IMpcClient MpcClient { get; }
}