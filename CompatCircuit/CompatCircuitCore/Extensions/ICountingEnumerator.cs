namespace HuayiQi.CompatCircuitCore.Extensions;
public interface ICountingEnumerator<T> : IEnumerator<T> {
    public long Count { get; }
}
