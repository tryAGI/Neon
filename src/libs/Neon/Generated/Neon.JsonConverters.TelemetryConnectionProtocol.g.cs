#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class TelemetryConnectionProtocolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.TelemetryConnectionProtocol>
    {
        /// <inheritdoc />
        public override global::Neon.TelemetryConnectionProtocol Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Neon.TelemetryConnectionProtocolExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.TelemetryConnectionProtocol)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.TelemetryConnectionProtocol);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.TelemetryConnectionProtocol value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Neon.TelemetryConnectionProtocolExtensions.ToValueString(value));
        }
    }
}
