﻿using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HuayiQi.CompatCircuitCore.Extensions;
public class IPAddressJsonConverter : JsonConverter<IPAddress> {
    public override IPAddress? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => IPAddress.Parse(reader.GetString()!);
    public override void Write(Utf8JsonWriter writer, IPAddress value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}
