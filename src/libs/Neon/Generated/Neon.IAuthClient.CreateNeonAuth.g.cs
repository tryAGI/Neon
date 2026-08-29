#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Enable Neon Auth for the branch<br/>
        /// Enables Neon Auth for the specified branch by connecting it to an authentication provider.<br/>
        /// Creating the integration provisions the `neon_auth` schema in the branch database, which stores user identity data synchronized from the provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthAsync(
            string projectId,
            string branchId,

            global::Neon.EnableNeonAuthIntegrationRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Neon Auth for the branch<br/>
        /// Enables Neon Auth for the specified branch by connecting it to an authentication provider.<br/>
        /// Creating the integration provisions the `neon_auth` schema in the branch database, which stores user identity data synchronized from the provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthCreateIntegrationResponse>> CreateNeonAuthAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.EnableNeonAuthIntegrationRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Neon Auth for the branch<br/>
        /// Enables Neon Auth for the specified branch by connecting it to an authentication provider.<br/>
        /// Creating the integration provisions the `neon_auth` schema in the branch database, which stores user identity data synchronized from the provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="databaseName">
        /// Name of the database to enable Neon Auth on. When omitted, the integration uses the project's default database.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthAsync(
            string projectId,
            string branchId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string? databaseName = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}