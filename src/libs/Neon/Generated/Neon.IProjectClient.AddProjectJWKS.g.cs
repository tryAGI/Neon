#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Add JWKS URL<br/>
        /// Adds a JWKS URL to the specified project for verifying JWTs used as the authentication mechanism.<br/>
        /// The URL must be a valid HTTPS URL that returns a JSON Web Key Set.<br/>
        /// The `provider_name` field allows you to specify which authentication provider you're using (e.g., Clerk, Auth0, AWS Cognito).<br/>
        /// The `branch_id` scopes the JWKS URL to specific branches; if not specified, it applies to all branches.<br/>
        /// The `role_names` scopes the URL to specific roles; if not specified, default roles are used (`authenticator`, `authenticated`, `anonymous`).<br/>
        /// The `jwt_audience` specifies which `aud` values are accepted in JWTs.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.JWKSCreationOperation> AddProjectJWKSAsync(
            string projectId,

            global::Neon.AddProjectJWKSRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add JWKS URL<br/>
        /// Adds a JWKS URL to the specified project for verifying JWTs used as the authentication mechanism.<br/>
        /// The URL must be a valid HTTPS URL that returns a JSON Web Key Set.<br/>
        /// The `provider_name` field allows you to specify which authentication provider you're using (e.g., Clerk, Auth0, AWS Cognito).<br/>
        /// The `branch_id` scopes the JWKS URL to specific branches; if not specified, it applies to all branches.<br/>
        /// The `role_names` scopes the URL to specific roles; if not specified, default roles are used (`authenticator`, `authenticated`, `anonymous`).<br/>
        /// The `jwt_audience` specifies which `aud` values are accepted in JWTs.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.JWKSCreationOperation>> AddProjectJWKSAsResponseAsync(
            string projectId,

            global::Neon.AddProjectJWKSRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add JWKS URL<br/>
        /// Adds a JWKS URL to the specified project for verifying JWTs used as the authentication mechanism.<br/>
        /// The URL must be a valid HTTPS URL that returns a JSON Web Key Set.<br/>
        /// The `provider_name` field allows you to specify which authentication provider you're using (e.g., Clerk, Auth0, AWS Cognito).<br/>
        /// The `branch_id` scopes the JWKS URL to specific branches; if not specified, it applies to all branches.<br/>
        /// The `role_names` scopes the URL to specific roles; if not specified, default roles are used (`authenticator`, `authenticated`, `anonymous`).<br/>
        /// The `jwt_audience` specifies which `aud` values are accepted in JWTs.
        /// </summary>
        /// <param name="projectId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.JWKSCreationOperation> AddProjectJWKSAsync(
            string projectId,
            string jwksUrl,
            string providerName,
            string? branchId = default,
            string? jwtAudience = default,
            bool? skipRoleCreation = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}