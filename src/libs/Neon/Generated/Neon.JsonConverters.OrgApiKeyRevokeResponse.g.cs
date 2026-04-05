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
                        apiKeyRevokeResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.ApiKeyRevokeResponse>(__rawJson, options);
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
                        orgApiKeyRevokeResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.OrgApiKeyRevokeResponseVariant2>(__rawJson, options);
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
                    apiKeyRevokeResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.ApiKeyRevokeResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    orgApiKeyRevokeResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.OrgApiKeyRevokeResponseVariant2>(__rawJson, options);
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

            if (value.IsApiKeyRevokeResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKeyRevokeResponse, typeof(global::Neon.ApiKeyRevokeResponse), options);
            }
            else if (value.IsOrgApiKeyRevokeResponseVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrgApiKeyRevokeResponseVariant2, typeof(global::Neon.OrgApiKeyRevokeResponseVariant2), options);
            }
        }
    }
}