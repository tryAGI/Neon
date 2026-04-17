#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class EndpointOperationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.EndpointOperations>
    {
        /// <inheritdoc />
        public override global::Neon.EndpointOperations Read(
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
            if (__jsonProps.Contains("endpoint")) __score0++;
            if (__jsonProps.Contains("endpoint.autoscaling_limit_max_cu")) __score0++;
            if (__jsonProps.Contains("endpoint.autoscaling_limit_min_cu")) __score0++;
            if (__jsonProps.Contains("endpoint.branch_id")) __score0++;
            if (__jsonProps.Contains("endpoint.compute_release_version")) __score0++;
            if (__jsonProps.Contains("endpoint.created_at")) __score0++;
            if (__jsonProps.Contains("endpoint.creation_source")) __score0++;
            if (__jsonProps.Contains("endpoint.current_state")) __score0++;
            if (__jsonProps.Contains("endpoint.disabled")) __score0++;
            if (__jsonProps.Contains("endpoint.host")) __score0++;
            if (__jsonProps.Contains("endpoint.id")) __score0++;
            if (__jsonProps.Contains("endpoint.last_active")) __score0++;
            if (__jsonProps.Contains("endpoint.name")) __score0++;
            if (__jsonProps.Contains("endpoint.passwordless_access")) __score0++;
            if (__jsonProps.Contains("endpoint.pending_state")) __score0++;
            if (__jsonProps.Contains("endpoint.pooler_enabled")) __score0++;
            if (__jsonProps.Contains("endpoint.pooler_mode")) __score0++;
            if (__jsonProps.Contains("endpoint.project_id")) __score0++;
            if (__jsonProps.Contains("endpoint.provisioner")) __score0++;
            if (__jsonProps.Contains("endpoint.proxy_host")) __score0++;
            if (__jsonProps.Contains("endpoint.region_id")) __score0++;
            if (__jsonProps.Contains("endpoint.settings")) __score0++;
            if (__jsonProps.Contains("endpoint.started_at")) __score0++;
            if (__jsonProps.Contains("endpoint.suspend_timeout_seconds")) __score0++;
            if (__jsonProps.Contains("endpoint.suspended_at")) __score0++;
            if (__jsonProps.Contains("endpoint.type")) __score0++;
            if (__jsonProps.Contains("endpoint.updated_at")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("operations")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.EndpointResponse? response1 = default;
            global::Neon.OperationsResponse? response2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.EndpointResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.EndpointResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.EndpointResponse).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.EndpointResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.EndpointResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.EndpointResponse).Name}");
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

            var __value = new global::Neon.EndpointOperations(
                response1,

                response2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.EndpointOperations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponse1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.EndpointResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.EndpointResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.EndpointResponse).Name}");
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