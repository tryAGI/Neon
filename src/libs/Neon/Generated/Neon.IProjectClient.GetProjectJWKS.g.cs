#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List JWKS URLs<br/>
        /// Returns the JWKS URLs available for verifying JWTs used as the authentication mechanism for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectJWKSResponse> GetProjectJWKSAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}