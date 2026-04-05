
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentSourceBankCard
    {
        /// <summary>
        /// Last 4 digits of the card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Last4 { get; set; }

        /// <summary>
        /// Brand of credit card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.PaymentSourceBankCardBrandJsonConverter))]
        public global::Neon.PaymentSourceBankCardBrand? Brand { get; set; }

        /// <summary>
        /// Credit card expiration month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Credit card expiration year
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSourceBankCard" /> class.
        /// </summary>
        /// <param name="last4">
        /// Last 4 digits of the card.
        /// </param>
        /// <param name="brand">
        /// Brand of credit card.
        /// </param>
        /// <param name="expMonth">
        /// Credit card expiration month
        /// </param>
        /// <param name="expYear">
        /// Credit card expiration year
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentSourceBankCard(
            string last4,
            global::Neon.PaymentSourceBankCardBrand? brand,
            long? expMonth,
            long? expYear)
        {
            this.Last4 = last4 ?? throw new global::System.ArgumentNullException(nameof(last4));
            this.Brand = brand;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSourceBankCard" /> class.
        /// </summary>
        public PaymentSourceBankCard()
        {
        }
    }
}