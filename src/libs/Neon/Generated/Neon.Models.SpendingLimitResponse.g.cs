
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendingLimitResponse
    {
        /// <summary>
        /// Monthly spending cap in cents. `null` indicates that no limit<br/>
        /// is currently configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spending_limit_cents")]
        public long? SpendingLimitCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingLimitResponse" /> class.
        /// </summary>
        /// <param name="spendingLimitCents">
        /// Monthly spending cap in cents. `null` indicates that no limit<br/>
        /// is currently configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendingLimitResponse(
            long? spendingLimitCents)
        {
            this.SpendingLimitCents = spendingLimitCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingLimitResponse" /> class.
        /// </summary>
        public SpendingLimitResponse()
        {
        }
    }
}