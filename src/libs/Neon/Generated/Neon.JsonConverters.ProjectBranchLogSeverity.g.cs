#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectBranchLogSeverityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.ProjectBranchLogSeverity>
    {
        /// <inheritdoc />
        public override global::Neon.ProjectBranchLogSeverity Read(
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
                        return global::Neon.ProjectBranchLogSeverityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.ProjectBranchLogSeverity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.ProjectBranchLogSeverity);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.ProjectBranchLogSeverity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Neon.ProjectBranchLogSeverityExtensions.ToValueString(value));
        }
    }
}
