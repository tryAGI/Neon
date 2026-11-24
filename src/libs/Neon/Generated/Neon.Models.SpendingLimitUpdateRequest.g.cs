
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpendingLimitUpdateRequest
    {
        /// <summary>
        /// Monthly spending notification threshold in cents. Must be positive.<br/>
        /// To remove a previously configured threshold, send a DELETE request<br/>
        /// to the spending_limit endpoint — `0` and `null` are rejected here.<br/>
        /// The threshold is alert-only: notifications are sent at 80% and 100%,<br/>
        /// but computes are not suspended. Setting a threshold below the<br/>
        /// period's already-accrued spend is permitted and triggers the<br/>
        /// over-limit notification on the next worker run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spending_limit_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SpendingLimitCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingLimitUpdateRequest" /> class.
        /// </summary>
        /// <param name="spendingLimitCents">
        /// Monthly spending notification threshold in cents. Must be positive.<br/>
        /// To remove a previously configured threshold, send a DELETE request<br/>
        /// to the spending_limit endpoint — `0` and `null` are rejected here.<br/>
        /// The threshold is alert-only: notifications are sent at 80% and 100%,<br/>
        /// but computes are not suspended. Setting a threshold below the<br/>
        /// period's already-accrued spend is permitted and triggers the<br/>
        /// over-limit notification on the next worker run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendingLimitUpdateRequest(
            long spendingLimitCents)
        {
            this.SpendingLimitCents = spendingLimitCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingLimitUpdateRequest" /> class.
        /// </summary>
        public SpendingLimitUpdateRequest()
        {
        }

    }
}