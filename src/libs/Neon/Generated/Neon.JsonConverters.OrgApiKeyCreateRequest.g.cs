#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class OrgApiKeyCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.OrgApiKeyCreateRequest>
    {
        /// <inheritdoc />
        public override global::Neon.OrgApiKeyCreateRequest Read(
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
            if (__jsonProps.Contains("key_name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("project_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.ApiKeyCreateRequest? apiKeyCreateRequest = default;
            global::Neon.OrgApiKeyCreateRequestVariant2? orgApiKeyCreateRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        apiKeyCreateRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.ApiKeyCreateRequest>(__rawJson, options);
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
                        orgApiKeyCreateRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.OrgApiKeyCreateRequestVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (apiKeyCreateRequest == null && orgApiKeyCreateRequestVariant2 == null)
            {
                try
                {
                    apiKeyCreateRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.ApiKeyCreateRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    orgApiKeyCreateRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.OrgApiKeyCreateRequestVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Neon.OrgApiKeyCreateRequest(
                apiKeyCreateRequest,

                orgApiKeyCreateRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.OrgApiKeyCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiKeyCreateRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKeyCreateRequest, typeof(global::Neon.ApiKeyCreateRequest), options);
            }
            else if (value.IsOrgApiKeyCreateRequestVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrgApiKeyCreateRequestVariant2, typeof(global::Neon.OrgApiKeyCreateRequestVariant2), options);
            }
        }
    }
}