#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class TriggerCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.TriggerCreateRequest>
    {
        /// <inheritdoc />
        public override global::Neon.TriggerCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.TriggerCreateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.TriggerCreateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.TriggerCreateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Neon.ScheduleTriggerCreateRequest? schedule = default;
            if (discriminator?.Type == global::Neon.TriggerCreateRequestDiscriminatorType.Schedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ScheduleTriggerCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ScheduleTriggerCreateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.ScheduleTriggerCreateRequest)}");
                schedule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Neon.StorageObjectCreatedTriggerCreateRequest? storageObjectCreated = default;
            if (discriminator?.Type == global::Neon.TriggerCreateRequestDiscriminatorType.StorageObjectCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.StorageObjectCreatedTriggerCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.StorageObjectCreatedTriggerCreateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Neon.StorageObjectCreatedTriggerCreateRequest)}");
                storageObjectCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Neon.TriggerCreateRequest(
                discriminator?.Type,
                schedule,

                storageObjectCreated
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.TriggerCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSchedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ScheduleTriggerCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ScheduleTriggerCreateRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ScheduleTriggerCreateRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Schedule!, typeInfo);
            }
            else if (value.IsStorageObjectCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.StorageObjectCreatedTriggerCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.StorageObjectCreatedTriggerCreateRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.StorageObjectCreatedTriggerCreateRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StorageObjectCreated!, typeInfo);
            }
        }
    }
}