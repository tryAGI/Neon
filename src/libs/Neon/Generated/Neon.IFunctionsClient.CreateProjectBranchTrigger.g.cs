#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Create a trigger<br/>
        /// Creates a trigger for a Function visible on the branch. The required<br/>
        /// `type` discriminator selects the trigger-specific configuration. The<br/>
        /// only currently supported type is `schedule`, whose cron is a numeric<br/>
        /// five-field expression and timezone is an IANA timezone name.<br/>
        /// The name must be unique among triggers visible on the branch, including<br/>
        /// inherited triggers.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.TriggerResponse> CreateProjectBranchTriggerAsync(
            string projectId,
            string branchId,

            global::Neon.TriggerCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a trigger<br/>
        /// Creates a trigger for a Function visible on the branch. The required<br/>
        /// `type` discriminator selects the trigger-specific configuration. The<br/>
        /// only currently supported type is `schedule`, whose cron is a numeric<br/>
        /// five-field expression and timezone is an IANA timezone name.<br/>
        /// The name must be unique among triggers visible on the branch, including<br/>
        /// inherited triggers.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.TriggerResponse>> CreateProjectBranchTriggerAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.TriggerCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}