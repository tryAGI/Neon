#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class TriggerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.TriggerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::Neon.TriggerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.TriggerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.TriggerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.TriggerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Neon.ScheduleTriggerUpdateRequest? schedule = default;
            if (discriminator?.Type == global::Neon.TriggerUpdateRequestDiscriminatorType.Schedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ScheduleTriggerUpdateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ScheduleTriggerUpdateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.ScheduleTriggerUpdateRequest)}");
                schedule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Neon.TriggerUpdateRequest(
                discriminator?.Type,
                schedule
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.TriggerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSchedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ScheduleTriggerUpdateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ScheduleTriggerUpdateRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ScheduleTriggerUpdateRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Schedule!, typeInfo);
            }
        }
    }
}