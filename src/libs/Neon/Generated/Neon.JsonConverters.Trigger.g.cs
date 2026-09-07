#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class TriggerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.Trigger>
    {
        /// <inheritdoc />
        public override global::Neon.Trigger Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.TriggerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.TriggerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.TriggerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Neon.ScheduleTrigger? schedule = default;
            if (discriminator?.Type == global::Neon.TriggerDiscriminatorType.Schedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ScheduleTrigger), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ScheduleTrigger> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.ScheduleTrigger)}");
                schedule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Neon.Trigger(
                discriminator?.Type,
                schedule
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.Trigger value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSchedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ScheduleTrigger), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ScheduleTrigger?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ScheduleTrigger).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Schedule!, typeInfo);
            }
        }
    }
}