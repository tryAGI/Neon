
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgApiKeyRevokeResponseVariant2
    {
        /// <summary>
        /// If set, the API key can access only this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgApiKeyRevokeResponseVariant2" /> class.
        /// </summary>
        /// <param name="projectId">
        /// If set, the API key can access only this project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgApiKeyRevokeResponseVariant2(
            string? projectId)
        {
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgApiKeyRevokeResponseVariant2" /> class.
        /// </summary>
        public OrgApiKeyRevokeResponseVariant2()
        {
        }
    }
}