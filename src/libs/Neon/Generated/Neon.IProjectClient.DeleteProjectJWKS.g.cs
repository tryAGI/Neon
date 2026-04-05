#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Delete JWKS URL<br/>
        /// Deletes a JWKS URL from the specified project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="jwksId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Jwks> DeleteProjectJWKSAsync(
            string projectId,
            string jwksId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}