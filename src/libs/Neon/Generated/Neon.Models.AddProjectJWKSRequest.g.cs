
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Add a new JWKS to a specific endpoint of a project
    /// </summary>
    public sealed partial class AddProjectJWKSRequest
    {
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
        /// Branch ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The name of the required JWT Audience to be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_audience")]
        public string? JwtAudience { get; set; }

        /// <summary>
        /// DEPRECATED. This field should only be used when using Neon RLS. The roles the JWKS should be mapped to. By default, the JWKS is mapped to the `authenticator`, `authenticated` and `anonymous` roles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_names")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RoleNames { get; set; }

        /// <summary>
        /// DEPRECATED. This field should only be used when using Neon RLS. If true, the role creation will be skipped.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_role_creation")]
        public bool? SkipRoleCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectJWKSRequest" /> class.
        /// </summary>
        /// <param name="jwksUrl">
        /// The URL that lists the JWKS
        /// </param>
        /// <param name="providerName">
        /// The name of the authentication provider (e.g., Clerk, Stytch, Auth0)
        /// </param>
        /// <param name="branchId">
        /// Branch ID
        /// </param>
        /// <param name="jwtAudience">
        /// The name of the required JWT Audience to be used
        /// </param>
        /// <param name="skipRoleCreation">
        /// DEPRECATED. This field should only be used when using Neon RLS. If true, the role creation will be skipped.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectJWKSRequest(
            string jwksUrl,
            string providerName,
            string? branchId,
            string? jwtAudience,
            bool? skipRoleCreation)
        {
            this.JwksUrl = jwksUrl ?? throw new global::System.ArgumentNullException(nameof(jwksUrl));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.BranchId = branchId;
            this.JwtAudience = jwtAudience;
            this.SkipRoleCreation = skipRoleCreation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectJWKSRequest" /> class.
        /// </summary>
        public AddProjectJWKSRequest()
        {
        }
    }
}