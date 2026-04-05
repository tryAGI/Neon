
#nullable enable

namespace Neon
{
    /// <summary>
    /// Details of an organization guest, who is not directly a member of<br/>
    /// an organization but has been shared one of the projects it owns
    /// </summary>
    public sealed partial class OrganizationGuest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PermissionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationGuest" /> class.
        /// </summary>
        /// <param name="permissionId"></param>
        /// <param name="userEmail"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationGuest(
            string permissionId,
            string userEmail,
            string projectId,
            string projectName)
        {
            this.PermissionId = permissionId ?? throw new global::System.ArgumentNullException(nameof(permissionId));
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationGuest" /> class.
        /// </summary>
        public OrganizationGuest()
        {
        }
    }
}