#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class StorageObjectCreatedTriggerTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.StorageObjectCreatedTriggerType?>
    {
        /// <inheritdoc />
        public override global::Neon.StorageObjectCreatedTriggerType? Read(
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
                        return global::Neon.StorageObjectCreatedTriggerTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.StorageObjectCreatedTriggerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.StorageObjectCreatedTriggerType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.StorageObjectCreatedTriggerType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Neon.StorageObjectCreatedTriggerTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
