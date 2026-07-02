#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Deploy code to a function<br/>
        /// Creates a deployment for the function. Supply any subset of zip,<br/>
        /// environment, and runtime; omitted fields inherit the<br/>
        /// function's latest version. At least one field must be supplied. The<br/>
        /// first deployment of a function must include zip. The newest deployment<br/>
        /// becomes active.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonFunctionDeploymentResponse> CreateProjectBranchFunctionDeploymentAsync(
            string projectId,
            string branchId,
            string slug,

            global::Neon.FunctionDeployRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy code to a function<br/>
        /// Creates a deployment for the function. Supply any subset of zip,<br/>
        /// environment, and runtime; omitted fields inherit the<br/>
        /// function's latest version. At least one field must be supplied. The<br/>
        /// first deployment of a function must include zip. The newest deployment<br/>
        /// becomes active.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonFunctionDeploymentResponse>> CreateProjectBranchFunctionDeploymentAsResponseAsync(
            string projectId,
            string branchId,
            string slug,

            global::Neon.FunctionDeployRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy code to a function<br/>
        /// Creates a deployment for the function. Supply any subset of zip,<br/>
        /// environment, and runtime; omitted fields inherit the<br/>
        /// function's latest version. At least one field must be supplied. The<br/>
        /// first deployment of a function must include zip. The newest deployment<br/>
        /// becomes active.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="zip">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.
        /// </param>
        /// <param name="zipname">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.
        /// </param>
        /// <param name="runtime"></param>
        /// <param name="environment">
        /// Optional JSON object (a string-to-string map) of environment<br/>
        /// variables for the deployment, e.g. {"KEY":"VALUE"}. Carried as a<br/>
        /// JSON-encoded string because multipart form data does not support<br/>
        /// typed object parts.<br/>
        /// Values are write-only: they are encrypted at rest, and responses<br/>
        /// carry only the variable names (the `environment` array), never the<br/>
        /// values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonFunctionDeploymentResponse> CreateProjectBranchFunctionDeploymentAsync(
            string projectId,
            string branchId,
            string slug,
            byte[]? zip = default,
            string? zipname = default,
            global::Neon.FunctionDeployRequestRuntime? runtime = default,
            string? environment = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}