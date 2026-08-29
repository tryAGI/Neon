
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Jwks
    {
        /// <summary>
        /// The JWKS configuration's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Neon project ID. Returned as `id` from `GET /projects`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The Neon branch ID. Returned as `id` from `GET /projects/{project_id}/branches`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// URL of the provider's JWKS endpoint used to verify JWTs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUrl { get; set; }

        /// <summary>
        /// The name of the authentication provider (e.g., Clerk, Stytch, Auth0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// The date and time when the JWKS was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the JWKS was last modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Expected JWT `aud` claim value configured for this JWKS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_audience")]
        public string? JwtAudience { get; set; }

        /// <summary>
        /// Database role names that are permitted to authenticate using this JWKS configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_names")]
        public global::System.Collections.Generic.IList<string>? RoleNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Jwks" /> class.
        /// </summary>
        /// <param name="id">
        /// The JWKS configuration's ID.
        /// </param>
        /// <param name="projectId">
        /// The Neon project ID. Returned as `id` from `GET /projects`.
        /// </param>
        /// <param name="jwksUrl">
        /// URL of the provider's JWKS endpoint used to verify JWTs.
        /// </param>
        /// <param name="providerName">
        /// The name of the authentication provider (e.g., Clerk, Stytch, Auth0)
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the JWKS was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the JWKS was last modified
        /// </param>
        /// <param name="branchId">
        /// The Neon branch ID. Returned as `id` from `GET /projects/{project_id}/branches`.
        /// </param>
        /// <param name="jwtAudience">
        /// Expected JWT `aud` claim value configured for this JWKS.
        /// </param>
        /// <param name="roleNames">
        /// Database role names that are permitted to authenticate using this JWKS configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Jwks(
            string id,
            string projectId,
            string jwksUrl,
            string providerName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? branchId,
            string? jwtAudience,
            global::System.Collections.Generic.IList<string>? roleNames)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BranchId = branchId;
            this.JwksUrl = jwksUrl ?? throw new global::System.ArgumentNullException(nameof(jwksUrl));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.JwtAudience = jwtAudience;
            this.RoleNames = roleNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Jwks" /> class.
        /// </summary>
        public Jwks()
        {
        }

    }
}