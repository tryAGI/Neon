
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectAdvisorSecurityIssuesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.AdvisorIssue> Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectAdvisorSecurityIssuesResponse" /> class.
        /// </summary>
        /// <param name="issues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectAdvisorSecurityIssuesResponse(
            global::System.Collections.Generic.IList<global::Neon.AdvisorIssue> issues)
        {
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectAdvisorSecurityIssuesResponse" /> class.
        /// </summary>
        public GetProjectAdvisorSecurityIssuesResponse()
        {
        }
    }
}