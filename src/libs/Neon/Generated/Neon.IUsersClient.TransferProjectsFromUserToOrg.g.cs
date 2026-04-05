#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Transfer projects from personal account to organization<br/>
        /// Transfers selected projects, identified by their IDs, from your personal account to a specified organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> TransferProjectsFromUserToOrgAsync(

            global::Neon.TransferProjectsToOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer projects from personal account to organization<br/>
        /// Transfers selected projects, identified by their IDs, from your personal account to a specified organization.
        /// </summary>
        /// <param name="destinationOrgId">
        /// The destination organization identifier
        /// </param>
        /// <param name="projectIds">
        /// The list of projects ids to transfer. Maximum of 400 project ids
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> TransferProjectsFromUserToOrgAsync(
            string destinationOrgId,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}