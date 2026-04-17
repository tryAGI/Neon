#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class OrgApiKeysListResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.OrgApiKeysListResponseItem>
    {
        /// <inheritdoc />
        public override global::Neon.OrgApiKeysListResponseItem Read(
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
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("created_by")) __score0++;
            if (__jsonProps.Contains("created_by.id")) __score0++;
            if (__jsonProps.Contains("created_by.image")) __score0++;
            if (__jsonProps.Contains("created_by.name")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("last_used_at")) __score0++;
            if (__jsonProps.Contains("last_used_from_addr")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("project_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.ApiKeysListResponseItem? apiKeysListResponseItem = default;
            global::Neon.OrgApiKeysListResponseItemVariant2? orgApiKeysListResponseItemVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ApiKeysListResponseItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ApiKeysListResponseItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ApiKeysListResponseItem).Name}");
                        apiKeysListResponseItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OrgApiKeysListResponseItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OrgApiKeysListResponseItemVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OrgApiKeysListResponseItemVariant2).Name}");
                        orgApiKeysListResponseItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (apiKeysListResponseItem == null && orgApiKeysListResponseItemVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ApiKeysListResponseItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ApiKeysListResponseItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ApiKeysListResponseItem).Name}");
                    apiKeysListResponseItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OrgApiKeysListResponseItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OrgApiKeysListResponseItemVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OrgApiKeysListResponseItemVariant2).Name}");
                    orgApiKeysListResponseItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Neon.OrgApiKeysListResponseItem(
                apiKeysListResponseItem,

                orgApiKeysListResponseItemVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.OrgApiKeysListResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiKeysListResponseItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.ApiKeysListResponseItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.ApiKeysListResponseItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.ApiKeysListResponseItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKeysListResponseItem!, typeInfo);
            }
            else if (value.IsOrgApiKeysListResponseItemVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.OrgApiKeysListResponseItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.OrgApiKeysListResponseItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.OrgApiKeysListResponseItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrgApiKeysListResponseItemVariant2!, typeInfo);
            }
        }
    }
}