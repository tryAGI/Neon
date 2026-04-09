
#nullable enable

namespace Neon
{
    public partial class SnapshotClient
    {


        private static readonly global::Neon.EndPointSecurityRequirement s_RestoreSnapshotSecurityRequirement0 =
            new global::Neon.EndPointSecurityRequirement
            {
                Authorizations = new global::Neon.EndPointAuthorizationRequirement[]
                {                    new global::Neon.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Neon.EndPointSecurityRequirement[] s_RestoreSnapshotSecurityRequirements =
            new global::Neon.EndPointSecurityRequirement[]
            {                s_RestoreSnapshotSecurityRequirement0,
            };
        partial void PrepareRestoreSnapshotArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? name,
            ref string projectId,
            ref string snapshotId,
            global::Neon.RestoreSnapshotRequest request);
        partial void PrepareRestoreSnapshotRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? name,
            string projectId,
            string snapshotId,
            global::Neon.RestoreSnapshotRequest request);
        partial void ProcessRestoreSnapshotResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRestoreSnapshotResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Restore snapshot<br/>
        /// Restore the specified snapshot to a new branch and optionally finalize the restore operation.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="snapshotId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>> RestoreSnapshotAsync(
            string projectId,
            string snapshotId,

            global::Neon.RestoreSnapshotRequest request,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRestoreSnapshotArguments(
                httpClient: HttpClient,
                name: ref name,
                projectId: ref projectId,
                snapshotId: ref snapshotId,
                request: request);


            var __authorizations = global::Neon.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RestoreSnapshotSecurityRequirements,
                operationName: "RestoreSnapshotAsync");

            var __pathBuilder = new global::Neon.PathBuilder(
                path: $"/projects/{projectId}/snapshots/{snapshotId}/restore",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("name", name) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRestoreSnapshotRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                projectId: projectId,
                snapshotId: snapshotId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRestoreSnapshotResponse(
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
                ProcessRestoreSnapshotResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Restore snapshot<br/>
        /// Restore the specified snapshot to a new branch and optionally finalize the restore operation.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="snapshotId"></param>
        /// <param name="requestName">
        /// A name for the newly restored branch.<br/>
        /// If omitted, a default name will be generated.
        /// </param>
        /// <param name="targetBranchId">
        /// The ID of the branch to restore the snapshot into.<br/>
        /// If not specified, the branch from which the snapshot was originally<br/>
        /// created (`snapshot.source_branch_id`) will be used.
        /// </param>
        /// <param name="finalizeRestore">
        /// Set to `true` to finalize the restore operation immediately.<br/>
        /// This will complete the restore and move any associated computes to the new branch,<br/>
        /// similar to the `finalizeRestoreBranch` operation.<br/>
        /// Defaults to `false` to allow previewing the restored snapshot data first.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>> RestoreSnapshotAsync(
            string projectId,
            string snapshotId,
            string? name = default,
            string? requestName = default,
            string? targetBranchId = default,
            bool? finalizeRestore = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neon.RestoreSnapshotRequest
            {
                Name = requestName,
                TargetBranchId = targetBranchId,
                FinalizeRestore = finalizeRestore,
            };

            return await RestoreSnapshotAsync(
                name: name,
                projectId: projectId,
                snapshotId: snapshotId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}