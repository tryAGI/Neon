#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve organization member details<br/>
        /// Retrieves information about the specified organization member.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Member> GetOrganizationMemberAsync(
            string orgId,
            string memberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}