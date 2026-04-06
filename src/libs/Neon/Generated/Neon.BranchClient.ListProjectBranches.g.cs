
#nullable enable

namespace Neon
{
    public partial class BranchClient
    {
        partial void PrepareListProjectBranchesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? search,
            ref global::Neon.ListProjectBranchesSortBy? sortBy,
            ref string? cursor,
            ref global::Neon.ListProjectBranchesSortOrder? sortOrder,
            ref int? limit,
            ref string projectId);
        partial void PrepareListProjectBranchesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? search,
            global::Neon.ListProjectBranchesSortBy? sortBy,
            string? cursor,
            global::Neon.ListProjectBranchesSortOrder? sortOrder,
            int? limit,
            string projectId);
        partial void ProcessListProjectBranchesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListProjectBranchesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List branches<br/>
        /// Retrieves a list of branches for the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// Each Neon project has a root branch named `main`.<br/>
        /// A `branch_id` value has a `br-` prefix.<br/>
        /// A project may contain child branches that were branched from `main` or from another branch.<br/>
        /// A parent branch is identified by the `parent_id` value, which is the `id` of the parent branch.<br/>
        /// For related information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy">
        /// Default Value: updated_at
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="limit"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>> ListProjectBranchesAsync(
            string projectId,
            string? search = default,
            global::Neon.ListProjectBranchesSortBy? sortBy = default,
            string? cursor = default,
            global::Neon.ListProjectBranchesSortOrder? sortOrder = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListProjectBranchesArguments(
                httpClient: HttpClient,
                search: ref search,
                sortBy: ref sortBy,
                cursor: ref cursor,
                sortOrder: ref sortOrder,
                limit: ref limit,
                projectId: ref projectId);

            var __pathBuilder = new global::Neon.PathBuilder(
                path: $"/projects/{projectId}/branches",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("sort_order", sortOrder?.ToValueString())
                .AddOptionalParameter("limit", limit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListProjectBranchesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                search: search,
                sortBy: sortBy,
                cursor: cursor,
                sortOrder: sortOrder,
                limit: limit,
                projectId: projectId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListProjectBranchesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // General Error.  The request may or may not be safe to retry, depending on the HTTP method, response status code, and whether a response was received.  - If no response is returned from the API, a network error or timeout likely occurred. - In some cases, the request may have reached the server and been successfully processed, but the response failed to reach the client. As a result, retrying non-idempotent requests can lead to unintended results.  The following HTTP methods are considered non-idempotent: `POST`, `PATCH`, `DELETE`, and `PUT`. Retrying these methods is generally **not safe**. The following methods are considered idempotent: `GET`, `HEAD`, and `OPTIONS`. Retrying these methods is **safe** in the event of a network error or timeout.  Any request that returns a `503 Service Unavailable` response is always safe to retry.  Any request that returns a `423 Locked` response is safe to retry. `423 Locked` indicates that the resource is temporarily locked, for example, due to another operation in progress. 
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::Neon.GeneralError? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::Neon.GeneralError.FromJson(__content_default, JsonSerializerContext);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Neon.GeneralError.FromJson(__content_default, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::Neon.ApiException<global::Neon.GeneralError>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListProjectBranchesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Neon.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Neon.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}