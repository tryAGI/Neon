#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class BranchAnonymizedCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.BranchAnonymizedCreateRequest>
    {
        /// <inheritdoc />
        public override global::Neon.BranchAnonymizedCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Neon.AnnotationCreateValueRequest? annotationValue = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.AnnotationCreateValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.AnnotationCreateValueRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.AnnotationCreateValueRequest).Name}");
                annotationValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Neon.BranchAnonymizedCreateRequestVariant2? branchAnonymizedCreateRequestVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.BranchAnonymizedCreateRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.BranchAnonymizedCreateRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.BranchAnonymizedCreateRequestVariant2).Name}");
                branchAnonymizedCreateRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Neon.BranchAnonymizedCreateRequest(
                annotationValue,

                branchAnonymizedCreateRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.BranchAnonymizedCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsAnnotationValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.AnnotationCreateValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.AnnotationCreateValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.AnnotationCreateValueRequest).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.AnnotationValue!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsBranchAnonymizedCreateRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.BranchAnonymizedCreateRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.BranchAnonymizedCreateRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.BranchAnonymizedCreateRequestVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.BranchAnonymizedCreateRequestVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}