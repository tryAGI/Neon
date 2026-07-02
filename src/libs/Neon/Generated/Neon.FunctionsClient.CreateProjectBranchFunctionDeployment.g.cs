
#nullable enable

namespace Neon
{
    public partial class FunctionsClient
    {


        private static readonly global::Neon.EndPointSecurityRequirement s_CreateProjectBranchFunctionDeploymentSecurityRequirement0 =
            new global::Neon.EndPointSecurityRequirement
            {
                Authorizations = new global::Neon.EndPointAuthorizationRequirement[]
                {                    new global::Neon.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Neon.EndPointSecurityRequirement[] s_CreateProjectBranchFunctionDeploymentSecurityRequirements =
            new global::Neon.EndPointSecurityRequirement[]
            {                s_CreateProjectBranchFunctionDeploymentSecurityRequirement0,
            };
        partial void PrepareCreateProjectBranchFunctionDeploymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string branchId,
            ref string slug,
            global::Neon.FunctionDeployRequest request);
        partial void PrepareCreateProjectBranchFunctionDeploymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string branchId,
            string slug,
            global::Neon.FunctionDeployRequest request);
        partial void ProcessCreateProjectBranchFunctionDeploymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateProjectBranchFunctionDeploymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Neon.NeonFunctionDeploymentResponse> CreateProjectBranchFunctionDeploymentAsync(
            string projectId,
            string branchId,
            string slug,

            global::Neon.FunctionDeployRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateProjectBranchFunctionDeploymentAsResponseAsync(
                projectId: projectId,
                branchId: branchId,
                slug: slug,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonFunctionDeploymentResponse>> CreateProjectBranchFunctionDeploymentAsResponseAsync(
            string projectId,
            string branchId,
            string slug,

            global::Neon.FunctionDeployRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateProjectBranchFunctionDeploymentArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                branchId: ref branchId,
                slug: ref slug,
                request: request);


            var __authorizations = global::Neon.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateProjectBranchFunctionDeploymentSecurityRequirements,
                operationName: "CreateProjectBranchFunctionDeploymentAsync");

            using var __timeoutCancellationTokenSource = global::Neon.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Neon.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Neon.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Neon.PathBuilder(
                                path: $"/projects/{projectId}/branches/{branchId}/functions/{slug}/deployments",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Neon.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(projectId ?? string.Empty),
                                name: "\"project_id\"");

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(branchId ?? string.Empty),
                                name: "\"branch_id\"");

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(slug ?? string.Empty),
                                name: "\"slug\"");

                            if (request.Zip != default)
                            {

                                var __contentZip = new global::System.Net.Http.ByteArrayContent(request.Zip ?? global::System.Array.Empty<byte>());
                                __contentZip.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Zipname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Zipname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentZip,
                                    name: "\"zip\"",
                                    fileName: request.Zipname != null ? $"\"{request.Zipname}\"" : string.Empty);
                                if (__contentZip.Headers.ContentDisposition != null)
                                {
                                    __contentZip.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Runtime != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Runtime).HasValue ? (request.Runtime).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"runtime\"");

                            }
                            if (request.Environment != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Environment ?? string.Empty),
                                    name: "\"environment\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Neon.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateProjectBranchFunctionDeploymentRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectId: projectId!,
                    branchId: branchId!,
                    slug: slug!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Neon.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateProjectBranchFunctionDeployment",
                                methodName: "CreateProjectBranchFunctionDeploymentAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/functions/{slug}/deployments\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Neon.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Neon.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateProjectBranchFunctionDeployment",
                                methodName: "CreateProjectBranchFunctionDeploymentAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/functions/{slug}/deployments\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Neon.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Neon.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Neon.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Neon.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateProjectBranchFunctionDeployment",
                                methodName: "CreateProjectBranchFunctionDeploymentAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/functions/{slug}/deployments\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Neon.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateProjectBranchFunctionDeploymentResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Neon.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateProjectBranchFunctionDeployment",
                                methodName: "CreateProjectBranchFunctionDeploymentAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/functions/{slug}/deployments\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Neon.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateProjectBranchFunctionDeployment",
                                methodName: "CreateProjectBranchFunctionDeploymentAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/functions/{slug}/deployments\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // General Error.  The request may or may not be safe to retry, depending on the HTTP method, response status code, and whether a response was received.  - If no response is returned from the API, a network error or timeout likely occurred. - In some cases, the request may have reached the server and been successfully processed, but the response failed to reach the client. As a result, retrying non-idempotent requests can lead to unintended results.  The following HTTP methods are considered non-idempotent: `POST`, `PATCH`, `DELETE`, and `PUT`. Retrying these methods is generally **not safe**. The following methods are considered idempotent: `GET`, `HEAD`, and `OPTIONS`. Retrying these methods is **safe** in the event of a network error or timeout.  Any request that returns a `503 Service Unavailable` response is always safe to retry.  Any request that returns a `423 Locked` response is safe to retry. `423 Locked` indicates that the resource is temporarily locked, for example, due to another operation in progress. 
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                global::Neon.GeneralError? __value_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::Neon.GeneralError.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_default = global::Neon.GeneralError.FromJson(__content_default, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }


                                throw global::Neon.ApiException<global::Neon.GeneralError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    responseBody: __content_default,
                                    responseObject: __value_default,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateProjectBranchFunctionDeploymentResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Neon.NeonFunctionDeploymentResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Neon.AutoSDKHttpResponse<global::Neon.NeonFunctionDeploymentResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Neon.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Neon.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Neon.NeonFunctionDeploymentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Neon.AutoSDKHttpResponse<global::Neon.NeonFunctionDeploymentResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Neon.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Neon.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Neon.NeonFunctionDeploymentResponse> CreateProjectBranchFunctionDeploymentAsync(
            string projectId,
            string branchId,
            string slug,
            byte[]? zip = default,
            string? zipname = default,
            global::Neon.FunctionDeployRequestRuntime? runtime = default,
            string? environment = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neon.FunctionDeployRequest
            {
                Zip = zip,
                Zipname = zipname,
                Runtime = runtime,
                Environment = environment,
            };

            return await CreateProjectBranchFunctionDeploymentAsync(
                projectId: projectId,
                branchId: branchId,
                slug: slug,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}