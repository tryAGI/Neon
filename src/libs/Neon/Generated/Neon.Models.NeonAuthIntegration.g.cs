
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthIntegration
    {
        /// <summary>
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// Project identifier assigned by the auth provider for this integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthProviderProjectId { get; set; }

        /// <summary>
        /// The Neon branch ID. Returned as `id` from `GET /projects/{project_id}/branches`.<br/>
        /// Example: br-cool-darkness-12345678
        /// </summary>
        /// <example>br-cool-darkness-12345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// Name of the database used by the Neon Auth integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// Timestamp when the Neon Auth integration was created, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthProviderProjectOwnedBy OwnedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusJsonConverter))]
        public global::Neon.NeonAuthProviderProjectTransferStatus? TransferStatus { get; set; }

        /// <summary>
        /// URL of the provider's JWKS endpoint used to verify JWTs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUrl { get; set; }

        /// <summary>
        /// Base URL of the Neon Auth service endpoint for this integration. Injected into the project environment as `NEON_AUTH_BASE_URL`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Application name shown in auth emails and communications. Defaults to the project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthIntegration" /> class.
        /// </summary>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="authProviderProjectId">
        /// Project identifier assigned by the auth provider for this integration.
        /// </param>
        /// <param name="branchId">
        /// The Neon branch ID. Returned as `id` from `GET /projects/{project_id}/branches`.<br/>
        /// Example: br-cool-darkness-12345678
        /// </param>
        /// <param name="dbName">
        /// Name of the database used by the Neon Auth integration.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the Neon Auth integration was created, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </param>
        /// <param name="ownedBy"></param>
        /// <param name="jwksUrl">
        /// URL of the provider's JWKS endpoint used to verify JWTs.
        /// </param>
        /// <param name="transferStatus"></param>
        /// <param name="baseUrl">
        /// Base URL of the Neon Auth service endpoint for this integration. Injected into the project environment as `NEON_AUTH_BASE_URL`.
        /// </param>
        /// <param name="name">
        /// Application name shown in auth emails and communications. Defaults to the project name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthIntegration(
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string authProviderProjectId,
            string branchId,
            string dbName,
            global::System.DateTime createdAt,
            global::Neon.NeonAuthProviderProjectOwnedBy ownedBy,
            string jwksUrl,
            global::Neon.NeonAuthProviderProjectTransferStatus? transferStatus,
            string? baseUrl,
            string? name)
        {
            this.AuthProvider = authProvider;
            this.AuthProviderProjectId = authProviderProjectId ?? throw new global::System.ArgumentNullException(nameof(authProviderProjectId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CreatedAt = createdAt;
            this.OwnedBy = ownedBy;
            this.TransferStatus = transferStatus;
            this.JwksUrl = jwksUrl ?? throw new global::System.ArgumentNullException(nameof(jwksUrl));
            this.BaseUrl = baseUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthIntegration" /> class.
        /// </summary>
        public NeonAuthIntegration()
        {
        }

    }
}