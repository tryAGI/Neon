
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferProjectsToOrganizationRequest
    {
        /// <summary>
        /// The destination organization identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationOrgId { get; set; }

        /// <summary>
        /// The list of projects ids to transfer. Maximum of 400 project ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferProjectsToOrganizationRequest" /> class.
        /// </summary>
        /// <param name="destinationOrgId">
        /// The destination organization identifier
        /// </param>
        /// <param name="projectIds">
        /// The list of projects ids to transfer. Maximum of 400 project ids
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferProjectsToOrganizationRequest(
            string destinationOrgId,
            global::System.Collections.Generic.IList<string> projectIds)
        {
            this.DestinationOrgId = destinationOrgId ?? throw new global::System.ArgumentNullException(nameof(destinationOrgId));
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferProjectsToOrganizationRequest" /> class.
        /// </summary>
        public TransferProjectsToOrganizationRequest()
        {
        }
    }
}