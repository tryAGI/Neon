#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Rotate an OAuth client secret<br/>
        /// Generates a new secret for a confidential OAuth client and invalidates the previous one.<br/>
        /// The new secret is shown only once.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthClientSecret> RotateNeonAuthOAuthClientSecretAsync(
            string projectId,
            string branchId,
            string clientId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate an OAuth client secret<br/>
        /// Generates a new secret for a confidential OAuth client and invalidates the previous one.<br/>
        /// The new secret is shown only once.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOAuthClientSecret>> RotateNeonAuthOAuthClientSecretAsResponseAsync(
            string projectId,
            string branchId,
            string clientId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}