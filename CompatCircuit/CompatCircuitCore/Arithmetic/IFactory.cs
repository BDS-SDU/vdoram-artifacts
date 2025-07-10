using System.Numerics;

namespace HuayiQi.CompatCircuitCore.Arithmetic;
public interface IArithFactory<TArithValue> {
    public TArithValue New(BigInteger value);
}
