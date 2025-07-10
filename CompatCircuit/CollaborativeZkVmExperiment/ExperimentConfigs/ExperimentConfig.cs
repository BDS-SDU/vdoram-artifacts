using System.Net;

namespace HuayiQi.CollaborativeZkVmExperiment.ExperimentConfigs;
public class ExperimentConfig {
    public required IReadOnlyList<IPAddress> PartyIPAddresses { get; set; }

    public ExperimentConfig() { }
}
