#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class DatabaseOperationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.DatabaseOperations>
    {
        /// <inheritdoc />
        public override global::Neon.DatabaseOperations Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Neon.DatabaseResponse? response1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.DatabaseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.DatabaseResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.DatabaseResponse).Name}");
                response1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Neon.OperationsResponse? response2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OperationsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OperationsResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OperationsResponse).Name}");
                response2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Neon.DatabaseOperations(
                response1,

                response2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.DatabaseOperations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsResponse1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.DatabaseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.DatabaseResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.DatabaseResponse).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Response1!, typeInfo);
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
            if (value.IsResponse2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OperationsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OperationsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OperationsResponse).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Response2!, typeInfo);
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