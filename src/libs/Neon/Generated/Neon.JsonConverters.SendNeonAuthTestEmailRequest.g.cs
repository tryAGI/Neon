#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class SendNeonAuthTestEmailRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.SendNeonAuthTestEmailRequest>
    {
        /// <inheritdoc />
        public override global::Neon.SendNeonAuthTestEmailRequest Read(
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
            if (__jsonProps.Contains("host")) __score0++;
            if (__jsonProps.Contains("password")) __score0++;
            if (__jsonProps.Contains("port")) __score0++;
            if (__jsonProps.Contains("sender_email")) __score0++;
            if (__jsonProps.Contains("sender_name")) __score0++;
            if (__jsonProps.Contains("username")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("recipient_email")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.StandardEmailServer? standardServer = default;
            global::Neon.SendNeonAuthTestEmailRequestVariant2? sendNeonAuthTestEmailRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        standardServer = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.StandardEmailServer>(__rawJson, options);
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
                        sendNeonAuthTestEmailRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.SendNeonAuthTestEmailRequestVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (standardServer == null && sendNeonAuthTestEmailRequestVariant2 == null)
            {
                try
                {
                    standardServer = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.StandardEmailServer>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sendNeonAuthTestEmailRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.SendNeonAuthTestEmailRequestVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Neon.SendNeonAuthTestEmailRequest(
                standardServer,

                sendNeonAuthTestEmailRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.SendNeonAuthTestEmailRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStandardServer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandardServer, typeof(global::Neon.StandardEmailServer), options);
            }
            else if (value.IsSendNeonAuthTestEmailRequestVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SendNeonAuthTestEmailRequestVariant2, typeof(global::Neon.SendNeonAuthTestEmailRequestVariant2), options);
            }
        }
    }
}