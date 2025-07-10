using System.Text.Json;

namespace HuayiQi.CompatCircuitCore.GlobalConfig;
public static class JsonConfig {
    public static JsonSerializerOptions JsonSerializerOptions => new() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
}
