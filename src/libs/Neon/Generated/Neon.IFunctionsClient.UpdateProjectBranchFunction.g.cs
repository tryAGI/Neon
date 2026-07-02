#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Update a function<br/>
        /// Updates the function's mutable metadata — currently only the display<br/>
        /// `name`. A string sets the display name; `null` clears it, after which<br/>
        /// the function's `name` falls back to its slug. Leading and trailing<br/>
        /// whitespace is trimmed; a whitespace-only name is rejected. Acts only<br/>
        /// on a function owned by the branch: a slug that is only inherited from<br/>
        /// an ancestor branch returns 404 — rename it on the branch that owns<br/>
        /// it. Like every other change on a branch, a rename is isolated per<br/>
        /// branch: a branch forked before the rename keeps the name it had at<br/>
        /// fork time.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonFunctionResponse> UpdateProjectBranchFunctionAsync(
            string projectId,
            string branchId,
            string slug,

            global::Neon.NeonFunctionUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a function<br/>
        /// Updates the function's mutable metadata — currently only the display<br/>
        /// `name`. A string sets the display name; `null` clears it, after which<br/>
        /// the function's `name` falls back to its slug. Leading and trailing<br/>
        /// whitespace is trimmed; a whitespace-only name is rejected. Acts only<br/>
        /// on a function owned by the branch: a slug that is only inherited from<br/>
        /// an ancestor branch returns 404 — rename it on the branch that owns<br/>
        /// it. Like every other change on a branch, a rename is isolated per<br/>
        /// branch: a branch forked before the rename keeps the name it had at<br/>
        /// fork time.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonFunctionResponse>> UpdateProjectBranchFunctionAsResponseAsync(
            string projectId,
            string branchId,
            string slug,

            global::Neon.NeonFunctionUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a function<br/>
        /// Updates the function's mutable metadata — currently only the display<br/>
        /// `name`. A string sets the display name; `null` clears it, after which<br/>
        /// the function's `name` falls back to its slug. Leading and trailing<br/>
        /// whitespace is trimmed; a whitespace-only name is rejected. Acts only<br/>
        /// on a function owned by the branch: a slug that is only inherited from<br/>
        /// an ancestor branch returns 404 — rename it on the branch that owns<br/>
        /// it. Like every other change on a branch, a rename is isolated per<br/>
        /// branch: a branch forked before the rename keeps the name it had at<br/>
        /// fork time.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="name">
        /// New display name for the function. `null` clears the display<br/>
        /// name; the function's `name` then falls back to its slug. Leading<br/>
        /// and trailing whitespace is trimmed; a whitespace-only name is<br/>
        /// rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonFunctionResponse> UpdateProjectBranchFunctionAsync(
            string projectId,
            string branchId,
            string slug,
            string? name = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}