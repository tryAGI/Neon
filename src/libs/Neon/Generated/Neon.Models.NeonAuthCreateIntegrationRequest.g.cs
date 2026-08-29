
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthCreateIntegrationRequest
    {
        /// <summary>
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// The Neon project ID. Returned as `id` from `GET /projects`.<br/>
        /// Example: wispy-forest-12345678
        /// </summary>
        /// <example>wispy-forest-12345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The Neon branch ID. Returned as `id` from `GET /projects/{project_id}/branches`.<br/>
        /// Example: br-cool-darkness-12345678
        /// </summary>
        /// <example>br-cool-darkness-12345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// Name of the database to associate with the Neon Auth integration. When omitted, the integration uses the project's default database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_name")]
        public string? DatabaseName { get; set; }

        /// <summary>
        /// Deprecated. The database role for the auth integration. Omit this field; it is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthCreateIntegrationRequest" /> class.
        /// </summary>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="projectId">
        /// The Neon project ID. Returned as `id` from `GET /projects`.<br/>
        /// Example: wispy-forest-12345678
        /// </param>
        /// <param name="branchId">
        /// The Neon branch ID. Returned as `id` from `GET /projects/{project_id}/branches`.<br/>
        /// Example: br-cool-darkness-12345678
        /// </param>
        /// <param name="databaseName">
        /// Name of the database to associate with the Neon Auth integration. When omitted, the integration uses the project's default database.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthCreateIntegrationRequest(
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string projectId,
            string branchId,
            string? databaseName)
        {
            this.AuthProvider = authProvider;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.DatabaseName = databaseName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthCreateIntegrationRequest" /> class.
        /// </summary>
        public NeonAuthCreateIntegrationRequest()
        {
        }

    }
}