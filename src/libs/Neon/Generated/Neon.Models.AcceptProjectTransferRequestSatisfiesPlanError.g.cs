
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestSatisfiesPlanError
    {
        /// <summary>
        /// List of reasons why the target account's plan cannot satisfy the transfer requirements. Each item contains a `code` identifying the constraint and a `message` with a human-readable explanation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason> Reasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestSatisfiesPlanError" /> class.
        /// </summary>
        /// <param name="reasons">
        /// List of reasons why the target account's plan cannot satisfy the transfer requirements. Each item contains a `code` identifying the constraint and a `message` with a human-readable explanation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestSatisfiesPlanError(
            global::System.Collections.Generic.IList<global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason> reasons)
        {
            this.Reasons = reasons ?? throw new global::System.ArgumentNullException(nameof(reasons));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestSatisfiesPlanError" /> class.
        /// </summary>
        public AcceptProjectTransferRequestSatisfiesPlanError()
        {
        }

    }
}