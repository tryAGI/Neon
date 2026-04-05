#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole>
    {
        /// <inheritdoc />
        public override global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole Read(
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
                        return global::Neon.NeonAuthOrganizationConfigUpdateCreatorRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRoleExtensions.ToValueString(value));
        }
    }
}
