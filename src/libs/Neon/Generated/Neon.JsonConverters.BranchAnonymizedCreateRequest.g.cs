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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("annotation_value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("branch_create")) __score1++;
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
                        annotationValue = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.AnnotationCreateValueRequest>(__rawJson, options);
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
                        branchAnonymizedCreateRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.BranchAnonymizedCreateRequestVariant2>(__rawJson, options);
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
                    annotationValue = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.AnnotationCreateValueRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    branchAnonymizedCreateRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.BranchAnonymizedCreateRequestVariant2>(__rawJson, options);
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

            if (value.IsAnnotationValue)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnnotationValue, typeof(global::Neon.AnnotationCreateValueRequest), options);
            }
            else if (value.IsBranchAnonymizedCreateRequestVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchAnonymizedCreateRequestVariant2, typeof(global::Neon.BranchAnonymizedCreateRequestVariant2), options);
            }
        }
    }
}