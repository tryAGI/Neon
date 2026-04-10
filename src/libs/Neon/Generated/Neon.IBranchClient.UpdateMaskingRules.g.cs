#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Update masking rules<br/>
        /// Updates the masking rules for the specified anonymized branch.<br/>
        /// Masking rules define how sensitive data should be anonymized using PostgreSQL Anonymizer.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.MaskingRulesResponse> UpdateMaskingRulesAsync(
            string projectId,
            string branchId,

            global::Neon.MaskingRulesUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update masking rules<br/>
        /// Updates the masking rules for the specified anonymized branch.<br/>
        /// Masking rules define how sensitive data should be anonymized using PostgreSQL Anonymizer.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="maskingRules">
        /// List of masking rules to apply to the branch.<br/>
        /// This will replace all existing masking rules for the branch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.MaskingRulesResponse> UpdateMaskingRulesAsync(
            string projectId,
            string branchId,
            global::System.Collections.Generic.IList<global::Neon.MaskingRule> maskingRules,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}