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
        /// **Note**: This endpoint is currently in Beta.
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
        /// **Note**: This endpoint is currently in Beta.
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
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="slug"></param>
        /// <param name="zip">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.<br/>
        /// Place `index.mjs` or `index.js` at the archive root, without a<br/>
        /// containing directory. If both exist, `index.mjs` is loaded. Export a<br/>
        /// request handler function or an object with a `fetch` method. Use<br/>
        /// `export default` for ESM or `module.exports` for CommonJS; prefer<br/>
        /// `index.mjs` for ESM.<br/>
        /// Upload JavaScript ready to run on Node.js 24. Compile TypeScript<br/>
        /// before uploading. Bundle dependencies into the entry module, or<br/>
        /// include the required modules and assets in the archive with their<br/>
        /// relative paths preserved (including `node_modules` for external<br/>
        /// packages). Node.js built-in modules do not need to be bundled.<br/>
        /// The API does not transpile, bundle, or install dependencies.<br/>
        /// The ZIP is limited to 32 MiB compressed and 128 MiB extracted, with<br/>
        /// at most 32,768 entries and 64 MiB per file. Bundle large dependency<br/>
        /// trees to keep the archive small. ZIPs larger than 32 MiB are rejected<br/>
        /// with HTTP 413 before creating a deployment. The extracted-size,<br/>
        /// entry-count, and per-file limits are enforced during the asynchronous<br/>
        /// build; an accepted upload that exceeds them fails the build.<br/>
        /// For example, a self-contained ESM bundle needs only `index.mjs`<br/>
        /// at the ZIP root. The Neon CLI bundles source into this layout by<br/>
        /// default; `neon function deploy --no-bundle` packages a prebuilt<br/>
        /// directory or an entry file named `index.mjs` or `index.js`.
        /// </param>
        /// <param name="zipname">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.<br/>
        /// Place `index.mjs` or `index.js` at the archive root, without a<br/>
        /// containing directory. If both exist, `index.mjs` is loaded. Export a<br/>
        /// request handler function or an object with a `fetch` method. Use<br/>
        /// `export default` for ESM or `module.exports` for CommonJS; prefer<br/>
        /// `index.mjs` for ESM.<br/>
        /// Upload JavaScript ready to run on Node.js 24. Compile TypeScript<br/>
        /// before uploading. Bundle dependencies into the entry module, or<br/>
        /// include the required modules and assets in the archive with their<br/>
        /// relative paths preserved (including `node_modules` for external<br/>
        /// packages). Node.js built-in modules do not need to be bundled.<br/>
        /// The API does not transpile, bundle, or install dependencies.<br/>
        /// The ZIP is limited to 32 MiB compressed and 128 MiB extracted, with<br/>
        /// at most 32,768 entries and 64 MiB per file. Bundle large dependency<br/>
        /// trees to keep the archive small. ZIPs larger than 32 MiB are rejected<br/>
        /// with HTTP 413 before creating a deployment. The extracted-size,<br/>
        /// entry-count, and per-file limits are enforced during the asynchronous<br/>
        /// build; an accepted upload that exceeds them fails the build.<br/>
        /// For example, a self-contained ESM bundle needs only `index.mjs`<br/>
        /// at the ZIP root. The Neon CLI bundles source into this layout by<br/>
        /// default; `neon function deploy --no-bundle` packages a prebuilt<br/>
        /// directory or an entry file named `index.mjs` or `index.js`.
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