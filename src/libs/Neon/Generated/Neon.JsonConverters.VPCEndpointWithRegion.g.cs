#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class VPCEndpointWithRegionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.VPCEndpointWithRegion>
    {
        /// <inheritdoc />
        public override global::Neon.VPCEndpointWithRegion Read(
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
            if (__jsonProps.Contains("label")) __score0++;
            if (__jsonProps.Contains("vpc_endpoint_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("region_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.VPCEndpoint? vPCEndpoint = default;
            global::Neon.VPCEndpointWithRegionVariant2? vPCEndpointWithRegionVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        vPCEndpoint = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.VPCEndpoint>(__rawJson, options);
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
                        vPCEndpointWithRegionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.VPCEndpointWithRegionVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (vPCEndpoint == null && vPCEndpointWithRegionVariant2 == null)
            {
                try
                {
                    vPCEndpoint = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.VPCEndpoint>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    vPCEndpointWithRegionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.VPCEndpointWithRegionVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Neon.VPCEndpointWithRegion(
                vPCEndpoint,

                vPCEndpointWithRegionVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.VPCEndpointWithRegion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsVPCEndpoint)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VPCEndpoint, typeof(global::Neon.VPCEndpoint), options);
            }
            else if (value.IsVPCEndpointWithRegionVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VPCEndpointWithRegionVariant2, typeof(global::Neon.VPCEndpointWithRegionVariant2), options);
            }
        }
    }
}