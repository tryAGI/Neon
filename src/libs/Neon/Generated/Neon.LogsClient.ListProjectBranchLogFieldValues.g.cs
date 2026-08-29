
#nullable enable

namespace Neon
{
    public partial class LogsClient
    {


        private static readonly global::Neon.EndPointSecurityRequirement s_ListProjectBranchLogFieldValuesSecurityRequirement0 =
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
        private static readonly global::Neon.EndPointSecurityRequirement[] s_ListProjectBranchLogFieldValuesSecurityRequirements =
            new global::Neon.EndPointSecurityRequirement[]
            {                s_ListProjectBranchLogFieldValuesSecurityRequirement0,
            };
        partial void PrepareListProjectBranchLogFieldValuesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? since,
            ref global::System.DateTime? startTime,
            ref global::System.DateTime? endTime,
            ref global::Neon.ProjectBranchLogSource? source,
            ref int? limit,
            ref string projectId,
            ref string branchId,
            ref string fieldName);
        partial void PrepareListProjectBranchLogFieldValuesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? since,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::Neon.ProjectBranchLogSource? source,
            int? limit,
            string projectId,
            string branchId,
            string fieldName);
        partial void ProcessListProjectBranchLogFieldValuesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListProjectBranchLogFieldValuesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List branch log field values<br/>
        /// Lists the distinct values observed for a low-cardinality log field in<br/>
        /// the requested time range. Call the log fields endpoint first to learn<br/>
        /// which `field_name` values this branch supports; a field that branch has<br/>
        /// never emitted is rejected with `unknown_field`.<br/>
        /// Give the window either as `since` or as an explicit `start_time`;<br/>
        /// supplying both is rejected. If neither is given, the previous six hours<br/>
        /// are used. The maximum supported time range is seven days.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="since">
        /// A length of time as a count and a unit, for example `30m`, `6h`, or<br/>
        /// `7d`. Valid units are `ms`, `s`, `m`, `h`, and `d`.<br/>
        /// Example: 1h
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="fieldName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogFieldValuesResponse> ListProjectBranchLogFieldValuesAsync(
            string projectId,
            string branchId,
            string fieldName,
            string? since = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Neon.ProjectBranchLogSource? source = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListProjectBranchLogFieldValuesAsResponseAsync(
                projectId: projectId,
                branchId: branchId,
                fieldName: fieldName,
                since: since,
                startTime: startTime,
                endTime: endTime,
                source: source,
                limit: limit,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List branch log field values<br/>
        /// Lists the distinct values observed for a low-cardinality log field in<br/>
        /// the requested time range. Call the log fields endpoint first to learn<br/>
        /// which `field_name` values this branch supports; a field that branch has<br/>
        /// never emitted is rejected with `unknown_field`.<br/>
        /// Give the window either as `since` or as an explicit `start_time`;<br/>
        /// supplying both is rejected. If neither is given, the previous six hours<br/>
        /// are used. The maximum supported time range is seven days.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="since">
        /// A length of time as a count and a unit, for example `30m`, `6h`, or<br/>
        /// `7d`. Valid units are `ms`, `s`, `m`, `h`, and `d`.<br/>
        /// Example: 1h
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="fieldName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogFieldValuesResponse>> ListProjectBranchLogFieldValuesAsResponseAsync(
            string projectId,
            string branchId,
            string fieldName,
            string? since = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Neon.ProjectBranchLogSource? source = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListProjectBranchLogFieldValuesArguments(
                httpClient: HttpClient,
                since: ref since,
                startTime: ref startTime,
                endTime: ref endTime,
                source: ref source,
                limit: ref limit,
                projectId: ref projectId,
                branchId: ref branchId,
                fieldName: ref fieldName);


            var __authorizations = global::Neon.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListProjectBranchLogFieldValuesSecurityRequirements,
                operationName: "ListProjectBranchLogFieldValuesAsync");

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
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Neon.PathBuilder(
                                path: $"/projects/{projectId}/branches/{branchId}/logs/fields/{fieldName}/values",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("since", since)
                                .AddOptionalParameter("start_time", startTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("end_time", endTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("source", source?.ToValueString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Neon.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Neon.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListProjectBranchLogFieldValuesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    since: since,
                    startTime: startTime,
                    endTime: endTime,
                    source: source,
                    limit: limit,
                    projectId: projectId!,
                    branchId: branchId!,
                    fieldName: fieldName!);

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
                                operationId: "ListProjectBranchLogFieldValues",
                                methodName: "ListProjectBranchLogFieldValuesAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/fields/{fieldName}/values\"",
                                httpMethod: "GET",
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
                                operationId: "ListProjectBranchLogFieldValues",
                                methodName: "ListProjectBranchLogFieldValuesAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/fields/{fieldName}/values\"",
                                httpMethod: "GET",
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
                                operationId: "ListProjectBranchLogFieldValues",
                                methodName: "ListProjectBranchLogFieldValuesAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/fields/{fieldName}/values\"",
                                httpMethod: "GET",
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
                ProcessListProjectBranchLogFieldValuesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Neon.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListProjectBranchLogFieldValues",
                                methodName: "ListProjectBranchLogFieldValuesAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/fields/{fieldName}/values\"",
                                httpMethod: "GET",
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
                                operationId: "ListProjectBranchLogFieldValues",
                                methodName: "ListProjectBranchLogFieldValuesAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/fields/{fieldName}/values\"",
                                httpMethod: "GET",
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
                            // The lookup could not be served as written. The body is always `ProjectBranchLogsInvalidQuery` — see `reason` for the exact cause.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Neon.ProjectBranchLogsInvalidQuery? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Neon.ProjectBranchLogsInvalidQuery.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Neon.ProjectBranchLogsInvalidQuery.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Neon.ApiException<global::Neon.ProjectBranchLogsInvalidQuery>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Logs are not available for this branch, or the project/branch was not found. The body is always `ProjectBranchLogsNotAvailable` — see `reason` for the exact cause.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Neon.ProjectBranchLogsNotAvailable? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Neon.ProjectBranchLogsNotAvailable.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Neon.ProjectBranchLogsNotAvailable.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Neon.ApiException<global::Neon.ProjectBranchLogsNotAvailable>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessListProjectBranchLogFieldValuesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Neon.ProjectBranchLogFieldValuesResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogFieldValuesResponse>(
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

                                    var __value = await global::Neon.ProjectBranchLogFieldValuesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogFieldValuesResponse>(
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
    }
}