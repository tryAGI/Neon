#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class OrgApiKeyRevokeResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.OrgApiKeyRevokeResponse>
    {
        /// <inheritdoc />
        public override global::Neon.OrgApiKeyRevokeResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Neon.ApiKeyRevokeResponse? apiKeyRevokeResponse = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ApiKeyRevokeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ApiKeyRevokeResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ApiKeyRevokeResponse).Name}");
                apiKeyRevokeResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Neon.OrgApiKeyRevokeResponseVariant2? orgApiKeyRevokeResponseVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OrgApiKeyRevokeResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OrgApiKeyRevokeResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OrgApiKeyRevokeResponseVariant2).Name}");
                orgApiKeyRevokeResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Neon.OrgApiKeyRevokeResponse(
                apiKeyRevokeResponse,

                orgApiKeyRevokeResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.OrgApiKeyRevokeResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsApiKeyRevokeResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ApiKeyRevokeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ApiKeyRevokeResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ApiKeyRevokeResponse).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ApiKeyRevokeResponse!, typeInfo);
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
            if (value.IsOrgApiKeyRevokeResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OrgApiKeyRevokeResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OrgApiKeyRevokeResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OrgApiKeyRevokeResponseVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.OrgApiKeyRevokeResponseVariant2!, typeInfo);
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