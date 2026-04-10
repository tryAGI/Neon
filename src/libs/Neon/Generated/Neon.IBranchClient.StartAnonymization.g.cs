#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Start anonymization<br/>
        /// Starts the anonymization process for an anonymized branch that is in the initialized, error, or anonymized state.<br/>
        /// This will apply all defined masking rules to anonymize sensitive data in the branch databases.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// The branch must be an anonymized branch to start anonymization.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AnonymizedBranchStatusResponse> StartAnonymizationAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}