
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendingLimitUpdateRequest
    {
        /// <summary>
        /// Monthly spending cap in cents. Must be positive. To remove a<br/>
        /// previously configured limit, send a DELETE request to the<br/>
        /// spending_limit endpoint — `0` and `null` are rejected here.<br/>
        /// The cap is alert-only: notifications fire at 80% and 100%, but<br/>
        /// computes are not suspended. Setting a cap below the period's<br/>
        /// already-accrued spend is permitted and will trigger the<br/>
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
        /// Monthly spending cap in cents. Must be positive. To remove a<br/>
        /// previously configured limit, send a DELETE request to the<br/>
        /// spending_limit endpoint — `0` and `null` are rejected here.<br/>
        /// The cap is alert-only: notifications fire at 80% and 100%, but<br/>
        /// computes are not suspended. Setting a cap below the period's<br/>
        /// already-accrued spend is permitted and will trigger the<br/>
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