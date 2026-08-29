#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class NeonAuthEmailServerConfigResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.NeonAuthEmailServerConfigResponse>
    {
        /// <inheritdoc />
        public override global::Neon.NeonAuthEmailServerConfigResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.NeonAuthEmailServerConfigResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Neon.StandardEmailServerResponse? standard = default;
            if (discriminator?.Type == global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType.Standard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.StandardEmailServerResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.StandardEmailServerResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.StandardEmailServerResponse)}");
                standard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Neon.SharedEmailServer? shared = default;
            if (discriminator?.Type == global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType.Shared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.SharedEmailServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.SharedEmailServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.SharedEmailServer)}");
                shared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Neon.NeonAuthEmailServerConfigResponse(
                discriminator?.Type,
                standard,

                shared
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.NeonAuthEmailServerConfigResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStandard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.StandardEmailServerResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.StandardEmailServerResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.StandardEmailServerResponse).Name}");
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