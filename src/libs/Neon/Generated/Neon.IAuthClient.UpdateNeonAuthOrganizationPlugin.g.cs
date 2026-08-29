#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update organization plugin configuration<br/>
        /// Updates the organization plugin configuration for Neon Auth.<br/>
        /// The organization plugin enables multi-tenant organization support.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOrganizationConfig> UpdateNeonAuthOrganizationPluginAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOrganizationConfigUpdate request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization plugin configuration<br/>
        /// Updates the organization plugin configuration for Neon Auth.<br/>
        /// The organization plugin enables multi-tenant organization support.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOrganizationConfig>> UpdateNeonAuthOrganizationPluginAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOrganizationConfigUpdate request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization plugin configuration<br/>
        /// Updates the organization plugin configuration for Neon Auth.<br/>
        /// The organization plugin enables multi-tenant organization support.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Controls whether the organization plugin is active for the organization.
        /// </param>
        /// <param name="organizationLimit">
        /// Maximum organizations a user can belong to (created or joined). At the limit, the user cannot create or join more.
        /// </param>
        /// <param name="membershipLimit">
        /// Maximum members per organization.
        /// </param>
        /// <param name="creatorRole">
        /// Role of the organization's creator. `owner`: full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.
        /// </param>
        /// <param name="sendInvitationEmail">
        /// When true, invited users receive an email containing an accept link. Requires that the invited user has a verified email address.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOrganizationConfig> UpdateNeonAuthOrganizationPluginAsync(
            string projectId,
            string branchId,
            bool? enabled = default,
            int? organizationLimit = default,
            int? membershipLimit = default,
            global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole? creatorRole = default,
            bool? sendInvitationEmail = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}