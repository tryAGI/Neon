
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectMemberRoleResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemberId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Email address of the user who has been granted access to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The user's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Organization-level role used by project member role management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectMemberOrgRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ProjectMemberOrgRole OrgRole { get; set; }

        /// <summary>
        /// Per-project role. `viewer` maps to `VIEWER`, `editor` maps to `EDITOR`,<br/>
        /// and `admin` maps to `ADMIN`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectRoleJsonConverter))]
        public global::Neon.ProjectRole? ProjectRole { get; set; }

        /// <summary>
        /// The caller's effective permission for a project when<br/>
        /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
        /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
        /// Omitted for personal projects, flag-off organizations, and non-user<br/>
        /// subjects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_default_project_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectPermissionLevelJsonConverter))]
        public global::Neon.ProjectPermissionLevel? OrgDefaultProjectPermission { get; set; }

        /// <summary>
        /// The caller's effective permission for a project when<br/>
        /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
        /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
        /// Omitted for personal projects, flag-off organizations, and non-user<br/>
        /// subjects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit_project_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectPermissionLevelJsonConverter))]
        public global::Neon.ProjectPermissionLevel? ExplicitProjectPermission { get; set; }

        /// <summary>
        /// The caller's effective permission for a project when<br/>
        /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
        /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
        /// Omitted for personal projects, flag-off organizations, and non-user<br/>
        /// subjects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_project_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectPermissionLevelJsonConverter))]
        public global::Neon.ProjectPermissionLevel? EffectiveProjectPermission { get; set; }

        /// <summary>
        /// Hint that database credentials may need rotation after the role change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_rotation_recommended")]
        public bool? CredentialRotationRecommended { get; set; }

        /// <summary>
        /// Hint that project-scoped org API keys created by the target user may need rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_api_key_rotation_recommended")]
        public bool? OrgApiKeyRotationRecommended { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberRoleResponse" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="userId"></param>
        /// <param name="orgRole">
        /// Organization-level role used by project member role management.
        /// </param>
        /// <param name="email">
        /// Email address of the user who has been granted access to the project.
        /// </param>
        /// <param name="name">
        /// The user's display name.
        /// </param>
        /// <param name="projectRole">
        /// Per-project role. `viewer` maps to `VIEWER`, `editor` maps to `EDITOR`,<br/>
        /// and `admin` maps to `ADMIN`.
        /// </param>
        /// <param name="orgDefaultProjectPermission">
        /// The caller's effective permission for a project when<br/>
        /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
        /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
        /// Omitted for personal projects, flag-off organizations, and non-user<br/>
        /// subjects.
        /// </param>
        /// <param name="explicitProjectPermission">
        /// The caller's effective permission for a project when<br/>
        /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
        /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
        /// Omitted for personal projects, flag-off organizations, and non-user<br/>
        /// subjects.
        /// </param>
        /// <param name="effectiveProjectPermission">
        /// The caller's effective permission for a project when<br/>
        /// per-project permissions are enabled. `VIEWER` grants read access,<br/>
        /// `EDITOR` adds update access, and `ADMIN` grants full management.<br/>
        /// Omitted for personal projects, flag-off organizations, and non-user<br/>
        /// subjects.
        /// </param>
        /// <param name="credentialRotationRecommended">
        /// Hint that database credentials may need rotation after the role change.
        /// </param>
        /// <param name="orgApiKeyRotationRecommended">
        /// Hint that project-scoped org API keys created by the target user may need rotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMemberRoleResponse(
            string projectId,
            global::System.Guid memberId,
            global::System.Guid userId,
            global::Neon.ProjectMemberOrgRole orgRole,
            string? email,
            string? name,
            global::Neon.ProjectRole? projectRole,
            global::Neon.ProjectPermissionLevel? orgDefaultProjectPermission,
            global::Neon.ProjectPermissionLevel? explicitProjectPermission,
            global::Neon.ProjectPermissionLevel? effectiveProjectPermission,
            bool? credentialRotationRecommended,
            bool? orgApiKeyRotationRecommended)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.MemberId = memberId;
            this.UserId = userId;
            this.Email = email;
            this.Name = name;
            this.OrgRole = orgRole;
            this.ProjectRole = projectRole;
            this.OrgDefaultProjectPermission = orgDefaultProjectPermission;
            this.ExplicitProjectPermission = explicitProjectPermission;
            this.EffectiveProjectPermission = effectiveProjectPermission;
            this.CredentialRotationRecommended = credentialRotationRecommended;
            this.OrgApiKeyRotationRecommended = orgApiKeyRotationRecommended;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberRoleResponse" /> class.
        /// </summary>
        public ProjectMemberRoleResponse()
        {
        }

    }
}