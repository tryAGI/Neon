
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchAnonymizedCreateRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_create")]
        public global::Neon.BranchCreateRequest? BranchCreate { get; set; }

        /// <summary>
        /// List of masking rules to apply to the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masking_rules")]
        public global::System.Collections.Generic.IList<global::Neon.MaskingRule>? MaskingRules { get; set; }

        /// <summary>
        /// If true, automatically start anonymization after the branch is created.<br/>
        /// Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_anonymization")]
        public bool? StartAnonymization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAnonymizedCreateRequestVariant2" /> class.
        /// </summary>
        /// <param name="branchCreate"></param>
        /// <param name="maskingRules">
        /// List of masking rules to apply to the branch.
        /// </param>
        /// <param name="startAnonymization">
        /// If true, automatically start anonymization after the branch is created.<br/>
        /// Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchAnonymizedCreateRequestVariant2(
            global::Neon.BranchCreateRequest? branchCreate,
            global::System.Collections.Generic.IList<global::Neon.MaskingRule>? maskingRules,
            bool? startAnonymization)
        {
            this.BranchCreate = branchCreate;
            this.MaskingRules = maskingRules;
            this.StartAnonymization = startAnonymization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchAnonymizedCreateRequestVariant2" /> class.
        /// </summary>
        public BranchAnonymizedCreateRequestVariant2()
        {
        }
    }
}