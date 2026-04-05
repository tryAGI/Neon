#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve organization details<br/>
        /// Retrieves information about the specified organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Organization> GetOrganizationAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}