#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class NeonAuthEmailServerConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.NeonAuthEmailServerConfig>
    {
        /// <inheritdoc />
        public override global::Neon.NeonAuthEmailServerConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.NeonAuthEmailServerConfigDiscriminator>(ref readerCopy, options);

            global::Neon.StandardEmailServer? standard = default;
            if (discriminator?.Type == global::Neon.NeonAuthEmailServerConfigDiscriminatorType.Standard)
            {
                standard = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.StandardEmailServer>(ref reader, options);
            }
            global::Neon.SharedEmailServer? shared = default;
            if (discriminator?.Type == global::Neon.NeonAuthEmailServerConfigDiscriminatorType.Shared)
            {
                shared = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.SharedEmailServer>(ref reader, options);
            }

            var __value = new global::Neon.NeonAuthEmailServerConfig(
                discriminator?.Type,
                standard,

                shared
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.NeonAuthEmailServerConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStandard)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Standard, typeof(global::Neon.StandardEmailServer), options);
            }
            else if (value.IsShared)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared, typeof(global::Neon.SharedEmailServer), options);
            }
        }
    }
}