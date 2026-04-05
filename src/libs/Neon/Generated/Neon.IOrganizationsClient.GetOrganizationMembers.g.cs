#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve organization members details<br/>
        /// Retrieves a paginated list of members for the specified organization.
        /// </summary>
        /// <param name="sortBy">
        /// Default Value: joined_at
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="limit"></param>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>> GetOrganizationMembersAsync(
            string orgId,
            global::Neon.GetOrganizationMembersSortBy? sortBy = default,
            string? cursor = default,
            global::Neon.GetOrganizationMembersSortOrder? sortOrder = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}