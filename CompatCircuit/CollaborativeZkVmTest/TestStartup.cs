using HuayiQi.CompatCircuitCore.SerilogHelpers;
using Serilog;
using Startup = HuayiQi.CollaborativeZkVm.Startup;

namespace HuayiQi.CollaborativeZkVmTest;

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
