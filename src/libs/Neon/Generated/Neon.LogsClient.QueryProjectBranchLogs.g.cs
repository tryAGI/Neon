
#nullable enable

namespace Neon
{
    public partial class LogsClient
    {


        private static readonly global::Neon.EndPointSecurityRequirement s_QueryProjectBranchLogsSecurityRequirement0 =
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
        private static readonly global::Neon.EndPointSecurityRequirement[] s_QueryProjectBranchLogsSecurityRequirements =
            new global::Neon.EndPointSecurityRequirement[]
            {                s_QueryProjectBranchLogsSecurityRequirement0,
            };
        partial void PrepareQueryProjectBranchLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string branchId,
            global::Neon.ProjectBranchLogsQueryRequest request);
        partial void PrepareQueryProjectBranchLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string branchId,
            global::Neon.ProjectBranchLogsQueryRequest request);
        partial void ProcessQueryProjectBranchLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueryProjectBranchLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query branch logs<br/>
        /// Returns logs emitted by services running on the specified branch,<br/>
        /// ordered by timestamp according to `sort_order`.<br/>
        /// All supplied filters are combined with `AND`: a record is returned only<br/>
        /// when it matches every filter. `minimum_severity` and `severity_text` are<br/>
        /// independent filters, so setting both requires a record to clear the<br/>
        /// severity floor *and* match the exact severity text.<br/>
        /// Supply `logql` instead of the structured filters to run a raw LogQL<br/>
        /// expression. Combining it with any structured filter is rejected rather<br/>
        /// than silently ignored; `limit`, `sort_order`, and the time window still<br/>
        /// apply, because those bound the query rather than form part of the<br/>
        /// expression.<br/>
        /// Give the window either as `since` — a duration ending at `end_time`, or<br/>
        /// at the current time when `end_time` is omitted — or as an explicit<br/>
        /// `start_time`. Supplying both is rejected.<br/>
        /// A single response holds at most 1,000 records. When `is_truncated` is<br/>
        /// `true`, pass the returned `next_cursor` back as `cursor` to fetch the<br/>
        /// next page, repeating the time range and every filter unchanged.<br/>
        /// If no time range is supplied, the query covers the previous hour. The<br/>
        /// maximum supported time range is seven days. `end_time` is exclusive.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogsQueryResponse> QueryProjectBranchLogsAsync(
            string projectId,
            string branchId,

            global::Neon.ProjectBranchLogsQueryRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await QueryProjectBranchLogsAsResponseAsync(
                projectId: projectId,
                branchId: branchId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Query branch logs<br/>
        /// Returns logs emitted by services running on the specified branch,<br/>
        /// ordered by timestamp according to `sort_order`.<br/>
        /// All supplied filters are combined with `AND`: a record is returned only<br/>
        /// when it matches every filter. `minimum_severity` and `severity_text` are<br/>
        /// independent filters, so setting both requires a record to clear the<br/>
        /// severity floor *and* match the exact severity text.<br/>
        /// Supply `logql` instead of the structured filters to run a raw LogQL<br/>
        /// expression. Combining it with any structured filter is rejected rather<br/>
        /// than silently ignored; `limit`, `sort_order`, and the time window still<br/>
        /// apply, because those bound the query rather than form part of the<br/>
        /// expression.<br/>
        /// Give the window either as `since` — a duration ending at `end_time`, or<br/>
        /// at the current time when `end_time` is omitted — or as an explicit<br/>
        /// `start_time`. Supplying both is rejected.<br/>
        /// A single response holds at most 1,000 records. When `is_truncated` is<br/>
        /// `true`, pass the returned `next_cursor` back as `cursor` to fetch the<br/>
        /// next page, repeating the time range and every filter unchanged.<br/>
        /// If no time range is supplied, the query covers the previous hour. The<br/>
        /// maximum supported time range is seven days. `end_time` is exclusive.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogsQueryResponse>> QueryProjectBranchLogsAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.ProjectBranchLogsQueryRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQueryProjectBranchLogsArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                branchId: ref branchId,
                request: request);


            var __authorizations = global::Neon.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_QueryProjectBranchLogsSecurityRequirements,
                operationName: "QueryProjectBranchLogsAsync");

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
                                path: $"/projects/{projectId}/branches/{branchId}/logs/query",
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Neon.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareQueryProjectBranchLogsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectId: projectId!,
                    branchId: branchId!,
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
                                operationId: "QueryProjectBranchLogs",
                                methodName: "QueryProjectBranchLogsAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/query\"",
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
                                operationId: "QueryProjectBranchLogs",
                                methodName: "QueryProjectBranchLogsAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/query\"",
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
                                operationId: "QueryProjectBranchLogs",
                                methodName: "QueryProjectBranchLogsAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/query\"",
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
                ProcessQueryProjectBranchLogsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Neon.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Neon.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QueryProjectBranchLogs",
                                methodName: "QueryProjectBranchLogsAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/query\"",
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
                                operationId: "QueryProjectBranchLogs",
                                methodName: "QueryProjectBranchLogsAsync",
                                pathTemplate: "$\"/projects/{projectId}/branches/{branchId}/logs/query\"",
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
                            // The query could not be served as written. The body is always `ProjectBranchLogsInvalidQuery` — see `reason` for the exact cause.
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
                                ProcessQueryProjectBranchLogsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Neon.ProjectBranchLogsQueryResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogsQueryResponse>(
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

                                    var __value = await global::Neon.ProjectBranchLogsQueryResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogsQueryResponse>(
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
        /// Query branch logs<br/>
        /// Returns logs emitted by services running on the specified branch,<br/>
        /// ordered by timestamp according to `sort_order`.<br/>
        /// All supplied filters are combined with `AND`: a record is returned only<br/>
        /// when it matches every filter. `minimum_severity` and `severity_text` are<br/>
        /// independent filters, so setting both requires a record to clear the<br/>
        /// severity floor *and* match the exact severity text.<br/>
        /// Supply `logql` instead of the structured filters to run a raw LogQL<br/>
        /// expression. Combining it with any structured filter is rejected rather<br/>
        /// than silently ignored; `limit`, `sort_order`, and the time window still<br/>
        /// apply, because those bound the query rather than form part of the<br/>
        /// expression.<br/>
        /// Give the window either as `since` — a duration ending at `end_time`, or<br/>
        /// at the current time when `end_time` is omitted — or as an explicit<br/>
        /// `start_time`. Supplying both is rejected.<br/>
        /// A single response holds at most 1,000 records. When `is_truncated` is<br/>
        /// `true`, pass the returned `next_cursor` back as `cursor` to fetch the<br/>
        /// next page, repeating the time range and every filter unchanged.<br/>
        /// If no time range is supplied, the query covers the previous hour. The<br/>
        /// maximum supported time range is seven days. `end_time` is exclusive.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="since">
        /// Length of the query window, ending at `end_time` or at the current<br/>
        /// time when `end_time` is omitted. Mutually exclusive with<br/>
        /// `start_time`. Prefer this over computing absolute bounds when the<br/>
        /// caller only means "the last hour".
        /// </param>
        /// <param name="startTime">
        /// Inclusive beginning of the query window. Mutually exclusive with<br/>
        /// `since`. Defaults to one hour before `end_time`, or one hour before<br/>
        /// the current time when both bounds are omitted.
        /// </param>
        /// <param name="endTime">
        /// Exclusive end of the query window. Defaults to the current time.
        /// </param>
        /// <param name="limit">
        /// Maximum number of log records to return per page.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor returned as `next_cursor` by a previous<br/>
        /// call. Resume the query after the last record of the previous page,<br/>
        /// repeating the time range and every filter unchanged.
        /// </param>
        /// <param name="sortOrder">
        /// Order matching records by timestamp. `desc`, the default, returns<br/>
        /// the newest records first.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="serviceName">
        /// Match the OpenTelemetry `service.name` resource attribute exactly.
        /// </param>
        /// <param name="scopeName">
        /// Match the OpenTelemetry instrumentation scope name exactly.
        /// </param>
        /// <param name="minimumSeverity">
        /// An OpenTelemetry severity level. A minimum severity includes every<br/>
        /// higher level in this order: `trace`, `debug`, `info`, `warn`, `error`,<br/>
        /// `fatal`.
        /// </param>
        /// <param name="severityText">
        /// Match the OpenTelemetry severity text exactly.
        /// </param>
        /// <param name="bodyContains">
        /// Match records whose rendered `message` contains this case-sensitive<br/>
        /// substring.<br/>
        /// Records with a structured body are matched against their JSON<br/>
        /// rendering, so the substring meets JSON syntax rather than prose: a<br/>
        /// bare key name such as `operation` matches every record carrying that<br/>
        /// key, and `http_status: 200` matches none, because the rendering<br/>
        /// contains `"http_status":200` with no space.
        /// </param>
        /// <param name="traceId">
        /// Match records associated with this OpenTelemetry trace ID. W3C Trace<br/>
        /// Context defines a trace ID as 32 lowercase hex digits, and that is<br/>
        /// what is stored, so an uppercase value is rejected rather than<br/>
        /// silently matching nothing.
        /// </param>
        /// <param name="logql">
        /// Escape hatch for selections the structured filters cannot express: a<br/>
        /// raw LogQL expression, evaluated against this branch's log stream.<br/>
        /// Only stream selectors and line filters are accepted — no<br/>
        /// aggregations and no parser stages. Supplying this alongside any<br/>
        /// structured filter is rejected with `conflicting_filters` rather than<br/>
        /// silently ignoring one of them. `limit`, `sort_order`, and the time<br/>
        /// window still apply.<br/>
        /// This field passes the underlying query language through to the<br/>
        /// caller, so unlike the rest of this contract it may change as that<br/>
        /// backend changes. Prefer the structured filters where they suffice.<br/>
        /// Example: {entity_type="function"} |~ "(?i)timeout"
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogsQueryResponse> QueryProjectBranchLogsAsync(
            string projectId,
            string branchId,
            string? since = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            string? cursor = default,
            global::Neon.ProjectBranchLogsQueryRequestSortOrder? sortOrder = default,
            global::Neon.ProjectBranchLogSource? source = default,
            string? serviceName = default,
            string? scopeName = default,
            global::Neon.ProjectBranchLogSeverity? minimumSeverity = default,
            string? severityText = default,
            string? bodyContains = default,
            string? traceId = default,
            string? logql = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neon.ProjectBranchLogsQueryRequest
            {
                Since = since,
                StartTime = startTime,
                EndTime = endTime,
                Limit = limit,
                Cursor = cursor,
                SortOrder = sortOrder,
                Source = source,
                ServiceName = serviceName,
                ScopeName = scopeName,
                MinimumSeverity = minimumSeverity,
                SeverityText = severityText,
                BodyContains = bodyContains,
                TraceId = traceId,
                Logql = logql,
            };

            return await QueryProjectBranchLogsAsync(
                projectId: projectId,
                branchId: branchId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}