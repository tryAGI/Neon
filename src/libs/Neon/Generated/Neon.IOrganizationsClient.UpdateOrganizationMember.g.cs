#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update role for organization member<br/>
        /// Only an admin can perform this action.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Member> UpdateOrganizationMemberAsync(
            string orgId,
            string memberId,

            global::Neon.OrganizationMemberUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update role for organization member<br/>
        /// Only an admin can perform this action.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="role">
        /// The role of the organization member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Member> UpdateOrganizationMemberAsync(
            string orgId,
            string memberId,
            global::Neon.MemberRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}