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
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("annotation_value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("branch_create")) __score1++;
            if (__jsonProps.Contains("branch_create.branch")) __score1++;
            if (__jsonProps.Contains("branch_create.endpoints")) __score1++;
            if (__jsonProps.Contains("masking_rules")) __score1++;
            if (__jsonProps.Contains("start_anonymization")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.AnnotationCreateValueRequest? annotationValue = default;
            global::Neon.BranchAnonymizedCreateRequestVariant2? branchAnonymizedCreateRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
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
                }
            }

            if (annotationValue == null && branchAnonymizedCreateRequestVariant2 == null)
            {
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

            if (value.IsAnnotationValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.AnnotationCreateValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.AnnotationCreateValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.AnnotationCreateValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnnotationValue!, typeInfo);
            }
            else if (value.IsBranchAnonymizedCreateRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.BranchAnonymizedCreateRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.BranchAnonymizedCreateRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.BranchAnonymizedCreateRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchAnonymizedCreateRequestVariant2!, typeInfo);
            }
        }
    }
}