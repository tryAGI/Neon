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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.NeonAuthEmailServerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.NeonAuthEmailServerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Neon.StandardEmailServer? standard = default;
            if (discriminator?.Type == global::Neon.NeonAuthEmailServerConfigDiscriminatorType.Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.StandardEmailServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.StandardEmailServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.StandardEmailServer)}");
                standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Neon.SharedEmailServer? shared = default;
            if (discriminator?.Type == global::Neon.NeonAuthEmailServerConfigDiscriminatorType.Shared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.SharedEmailServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.SharedEmailServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.SharedEmailServer)}");
                shared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStandard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.StandardEmailServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.StandardEmailServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.StandardEmailServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Standard!, typeInfo);
            }
            else if (value.IsShared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.SharedEmailServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.SharedEmailServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.SharedEmailServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared!, typeInfo);
            }
        }
    }
}