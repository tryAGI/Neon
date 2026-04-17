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
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("created_by")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("last_used_at")) __score0++;
            if (__jsonProps.Contains("last_used_from_addr")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("revoked")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("project_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.ApiKeyRevokeResponse? apiKeyRevokeResponse = default;
            global::Neon.OrgApiKeyRevokeResponseVariant2? orgApiKeyRevokeResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
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
                }
                else if (__bestIndex == 1)
                {
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
                }
            }

            if (apiKeyRevokeResponse == null && orgApiKeyRevokeResponseVariant2 == null)
            {
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

            if (value.IsApiKeyRevokeResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ApiKeyRevokeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ApiKeyRevokeResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ApiKeyRevokeResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKeyRevokeResponse!, typeInfo);
            }
            else if (value.IsOrgApiKeyRevokeResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OrgApiKeyRevokeResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OrgApiKeyRevokeResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OrgApiKeyRevokeResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrgApiKeyRevokeResponseVariant2!, typeInfo);
            }
        }
    }
}