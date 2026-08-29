#nullable enable

namespace Neon
{
    public partial interface IDataAPIClient
    {
        /// <summary>
        /// Create Neon Data API<br/>
        /// Creates a new instance of Neon Data API in the specified branch.<br/>
        /// The Data API exposes a REST interface over the branch database. The `database_name` path parameter determines which database the API serves.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DataAPICreateResponse> CreateProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DataAPICreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Neon Data API<br/>
        /// Creates a new instance of Neon Data API in the specified branch.<br/>
        /// The Data API exposes a REST interface over the branch database. The `database_name` path parameter determines which database the API serves.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.DataAPICreateResponse>> CreateProjectBranchDataAPIAsResponseAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DataAPICreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Neon Data API<br/>
        /// Creates a new instance of Neon Data API in the specified branch.<br/>
        /// The Data API exposes a REST interface over the branch database. The `database_name` path parameter determines which database the API serves.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="authProvider">
        /// Authentication provider for the Neon Data API. `neon_auth`: use Neon's built-in managed authentication (no JWKS configuration required). `external`: use an external JWT provider, which requires `jwks_url`. When omitted, no auth provider is configured (existing setup is kept).
        /// </param>
        /// <param name="jwksUrl">
        /// URL of the JWKS endpoint used to verify JWTs for this Data API. Required when configuring JWT-based authentication; omit when using a non-JWT auth provider.
        /// </param>
        /// <param name="providerName">
        /// Display name for the authentication provider. Accepted values include "Clerk", "Stytch", and "Auth0", but any non-empty string is valid. Optional field.
        /// </param>
        /// <param name="jwtAudience">
        /// Expected `aud` claim in incoming JWTs. When set, tokens with a different audience are rejected; tokens with no audience are still accepted. Omit to skip audience validation.
        /// </param>
        /// <param name="addDefaultGrants">
        /// Grant all permissions to the tables in the public schema to authenticated users<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipAuthSchema">
        /// Skip creating the auth schema and RLS functions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="settings">
        /// Configuration settings for the Neon Data API
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DataAPICreateResponse> CreateProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.DataAPICreateRequestAuthProvider? authProvider = default,
            string? jwksUrl = default,
            string? providerName = default,
            string? jwtAudience = default,
            bool? addDefaultGrants = default,
            bool? skipAuthSchema = default,
            global::Neon.DataAPISettings? settings = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}