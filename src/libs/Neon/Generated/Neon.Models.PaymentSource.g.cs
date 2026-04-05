
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentSource
    {
        /// <summary>
        /// Type of payment source. E.g. "card".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public global::Neon.PaymentSourceBankCard? Card { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of payment source. E.g. "card".
        /// </param>
        /// <param name="card"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentSource(
            string type,
            global::Neon.PaymentSourceBankCard? card)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Card = card;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSource" /> class.
        /// </summary>
        public PaymentSource()
        {
        }
    }
}