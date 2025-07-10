using HuayiQi.CompatCircuitCore.RandomGenerators;

namespace HuayiQi.CompatCircuitCore.GlobalConfig;
public static class RandomConfig {
    public static RandomGeneratorRef RandomGenerator { get; } = new RandomGeneratorRef() { Value = new CryptographyRandomGenerator() };
}
