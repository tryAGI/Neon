#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create organization invitations<br/>
        /// Creates invitations for a specific organization.<br/>
        /// If the invited user has an existing account, they automatically join as a member.<br/>
        /// If they don't yet have an account, they are invited to create one, after which they become a member.<br/>
        /// Each invited user receives an email notification.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OrganizationInvitationsResponse> CreateOrganizationInvitationsAsync(
            string orgId,

            global::Neon.OrganizationInvitesCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create organization invitations<br/>
        /// Creates invitations for a specific organization.<br/>
        /// If the invited user has an existing account, they automatically join as a member.<br/>
        /// If they don't yet have an account, they are invited to create one, after which they become a member.<br/>
        /// Each invited user receives an email notification.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="invitations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OrganizationInvitationsResponse> CreateOrganizationInvitationsAsync(
            string orgId,
            global::System.Collections.Generic.IList<global::Neon.OrganizationInviteCreateRequest> invitations,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}