#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve current user organizations list<br/>
        /// Retrieves information about the current Neon user's organizations
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OrganizationsResponse> GetCurrentUserOrganizationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}