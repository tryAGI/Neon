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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOrganizationConfig> UpdateNeonAuthOrganizationPluginAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOrganizationConfigUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization plugin configuration<br/>
        /// Updates the organization plugin configuration for Neon Auth.<br/>
        /// The organization plugin enables multi-tenant organization support.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Whether the organization plugin is enabled
        /// </param>
        /// <param name="organizationLimit">
        /// Maximum number of organizations a user can create
        /// </param>
        /// <param name="membershipLimit">
        /// Maximum number of members per organization
        /// </param>
        /// <param name="creatorRole">
        /// The role assigned to the user who creates an organization
        /// </param>
        /// <param name="sendInvitationEmail">
        /// Whether to send invitation emails when inviting members to an organization
        /// </param>
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}