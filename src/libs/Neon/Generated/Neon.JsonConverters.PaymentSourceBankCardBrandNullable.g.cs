#nullable enable

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public sealed class PaymentSourceBankCardBrandNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.PaymentSourceBankCardBrand?>
    {
        /// <inheritdoc />
        public override global::Neon.PaymentSourceBankCardBrand? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Neon.PaymentSourceBankCardBrandExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Neon.PaymentSourceBankCardBrand)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Neon.PaymentSourceBankCardBrand?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.PaymentSourceBankCardBrand? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Neon.PaymentSourceBankCardBrandExtensions.ToValueString(value.Value));
            }
        }
    }
}
