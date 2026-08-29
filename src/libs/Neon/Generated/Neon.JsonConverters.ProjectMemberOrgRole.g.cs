#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectMemberOrgRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.ProjectMemberOrgRole>
    {
        /// <inheritdoc />
        public override global::Neon.ProjectMemberOrgRole Read(
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
                        return global::Neon.ProjectMemberOrgRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.ProjectMemberOrgRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.ProjectMemberOrgRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.ProjectMemberOrgRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Neon.ProjectMemberOrgRoleExtensions.ToValueString(value));
        }
    }
}
