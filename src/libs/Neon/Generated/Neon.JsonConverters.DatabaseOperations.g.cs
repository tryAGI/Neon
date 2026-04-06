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
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("database")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("operations")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.DatabaseResponse? response1 = default;
            global::Neon.OperationsResponse? response2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
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
                }
            }

            if (response1 == null && response2 == null)
            {
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

            if (value.IsResponse1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.DatabaseResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.DatabaseResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.DatabaseResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response1!, typeInfo);
            }
            else if (value.IsResponse2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OperationsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OperationsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OperationsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response2!, typeInfo);
            }
        }
    }
}