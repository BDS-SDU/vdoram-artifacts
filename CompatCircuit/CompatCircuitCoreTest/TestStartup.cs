using HuayiQi.CompatCircuitCore.SerilogHelpers;
using Serilog;
using Startup = HuayiQi.CompatCircuitCore.Startup;

namespace HuayiQi.CompatCircuitCoreTest;
[TestClass]
public static class TestStartup {
    [AssemblyInitialize]
    public static void Initialize(TestContext context) {
        InitializeSerilog();
        Startup.InitializeJsonSerializer();
    }
    private static void InitializeSerilog() => Serilog.Log.Logger = new Serilog.LoggerConfiguration()
        .MinimumLevel.ControlledBy(SerilogHelper.LoggingLevelSwitch)
        .WriteTo.Trace(outputTemplate: SerilogHelper.OutputTemplate)
        .CreateLogger();
}
