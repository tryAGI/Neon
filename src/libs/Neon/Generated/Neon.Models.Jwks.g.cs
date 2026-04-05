
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Jwks
    {
        /// <summary>
        /// JWKS ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Branch ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The URL that lists the JWKS
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
        /// The name of the required JWT Audience to be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_audience")]
        public string? JwtAudience { get; set; }

        /// <summary>
        /// 
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
        /// JWKS ID
        /// </param>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="jwksUrl">
        /// The URL that lists the JWKS
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
        /// Branch ID
        /// </param>
        /// <param name="jwtAudience">
        /// The name of the required JWT Audience to be used
        /// </param>
        /// <param name="roleNames"></param>
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