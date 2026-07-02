#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionDeployRequestRuntimeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.FunctionDeployRequestRuntime?>
    {
        /// <inheritdoc />
        public override global::Neon.FunctionDeployRequestRuntime? Read(
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
                        return global::Neon.FunctionDeployRequestRuntimeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.FunctionDeployRequestRuntime)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.FunctionDeployRequestRuntime?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.FunctionDeployRequestRuntime? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Neon.FunctionDeployRequestRuntimeExtensions.ToValueString(value.Value));
            }
        }
    }
}
