#nullable enable

namespace Neon
{
    public partial interface IRegionClient
    {
        /// <summary>
        /// List supported regions<br/>
        /// Lists supported Neon regions.<br/>
        /// **Note:** Not all regions are available to all organizations. Pass the `org_id`<br/>
        /// parameter to get an accurate list of regions available to your organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ActiveRegionsResponse> GetActiveRegionsAsync(
            string? orgId = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}