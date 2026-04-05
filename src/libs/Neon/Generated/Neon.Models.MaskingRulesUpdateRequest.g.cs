
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MaskingRulesUpdateRequest
    {
        /// <summary>
        /// List of masking rules to apply to the branch.<br/>
        /// This will replace all existing masking rules for the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masking_rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.MaskingRule> MaskingRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRulesUpdateRequest" /> class.
        /// </summary>
        /// <param name="maskingRules">
        /// List of masking rules to apply to the branch.<br/>
        /// This will replace all existing masking rules for the branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaskingRulesUpdateRequest(
            global::System.Collections.Generic.IList<global::Neon.MaskingRule> maskingRules)
        {
            this.MaskingRules = maskingRules ?? throw new global::System.ArgumentNullException(nameof(maskingRules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRulesUpdateRequest" /> class.
        /// </summary>
        public MaskingRulesUpdateRequest()
        {
        }
    }
}