#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Transfer projects between organizations<br/>
        /// Transfers selected projects, identified by their IDs, from your organization to another specified organization.
        /// </summary>
        /// <param name="sourceOrgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> TransferProjectsFromOrgToOrgAsync(
            string sourceOrgId,

            global::Neon.TransferProjectsToOrganizationRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer projects between organizations<br/>
        /// Transfers selected projects, identified by their IDs, from your organization to another specified organization.
        /// </summary>
        /// <param name="sourceOrgId"></param>
        /// <param name="destinationOrgId">
        /// The destination organization identifier
        /// </param>
        /// <param name="projectIds">
        /// The list of projects ids to transfer. Maximum of 400 project ids
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> TransferProjectsFromOrgToOrgAsync(
            string sourceOrgId,
            string destinationOrgId,
            global::System.Collections.Generic.IList<string> projectIds,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}