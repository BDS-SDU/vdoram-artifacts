using HuayiQi.CompatCircuitProgramming.CircuitElements;

namespace HuayiQi.CompatCircuitProgramming.Gadgets;
public interface IGadget {
    public List<string> GetInputWireNames();
    public List<string> GetOutputWireNames();

    public GadgetInstance ApplyGadget(IReadOnlyList<Wire> inputWires, string namePrefix);
}
