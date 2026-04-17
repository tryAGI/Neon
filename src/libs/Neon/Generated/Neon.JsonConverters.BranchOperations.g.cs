#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class BranchOperationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.BranchOperations>
    {
        /// <inheritdoc />
        public override global::Neon.BranchOperations Read(
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
            if (__jsonProps.Contains("branch")) __score0++;
            if (__jsonProps.Contains("branch.active_time_seconds")) __score0++;
            if (__jsonProps.Contains("branch.compute_time_seconds")) __score0++;
            if (__jsonProps.Contains("branch.cpu_used_sec")) __score0++;
            if (__jsonProps.Contains("branch.created_at")) __score0++;
            if (__jsonProps.Contains("branch.created_by")) __score0++;
            if (__jsonProps.Contains("branch.creation_source")) __score0++;
            if (__jsonProps.Contains("branch.current_state")) __score0++;
            if (__jsonProps.Contains("branch.data_transfer_bytes")) __score0++;
            if (__jsonProps.Contains("branch.default")) __score0++;
            if (__jsonProps.Contains("branch.expires_at")) __score0++;
            if (__jsonProps.Contains("branch.id")) __score0++;
            if (__jsonProps.Contains("branch.init_source")) __score0++;
            if (__jsonProps.Contains("branch.last_reset_at")) __score0++;
            if (__jsonProps.Contains("branch.logical_size")) __score0++;
            if (__jsonProps.Contains("branch.name")) __score0++;
            if (__jsonProps.Contains("branch.parent_id")) __score0++;
            if (__jsonProps.Contains("branch.parent_lsn")) __score0++;
            if (__jsonProps.Contains("branch.parent_timestamp")) __score0++;
            if (__jsonProps.Contains("branch.pending_state")) __score0++;
            if (__jsonProps.Contains("branch.primary")) __score0++;
            if (__jsonProps.Contains("branch.project_id")) __score0++;
            if (__jsonProps.Contains("branch.protected")) __score0++;
            if (__jsonProps.Contains("branch.restore_status")) __score0++;
            if (__jsonProps.Contains("branch.restored_as")) __score0++;
            if (__jsonProps.Contains("branch.restored_from")) __score0++;
            if (__jsonProps.Contains("branch.restricted_actions")) __score0++;
            if (__jsonProps.Contains("branch.state_changed_at")) __score0++;
            if (__jsonProps.Contains("branch.ttl_interval_seconds")) __score0++;
            if (__jsonProps.Contains("branch.updated_at")) __score0++;
            if (__jsonProps.Contains("branch.written_data_bytes")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("operations")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.BranchResponse? response1 = default;
            global::Neon.OperationsResponse? response2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.BranchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.BranchResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.BranchResponse).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.BranchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.BranchResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.BranchResponse).Name}");
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

            var __value = new global::Neon.BranchOperations(
                response1,

                response2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.BranchOperations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponse1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Neon.BranchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Neon.BranchResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Neon.BranchResponse).Name}");
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