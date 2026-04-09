
#nullable enable

namespace Neon
{
    public partial class ProjectClient
    {


        private static readonly global::Neon.EndPointSecurityRequirement s_AcceptProjectTransferRequestSecurityRequirement0 =
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
        private static readonly global::Neon.EndPointSecurityRequirement[] s_AcceptProjectTransferRequestSecurityRequirements =
            new global::Neon.EndPointSecurityRequirement[]
            {                s_AcceptProjectTransferRequestSecurityRequirement0,
            };
        partial void PrepareAcceptProjectTransferRequestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string requestId,
            global::Neon.AcceptProjectTransferRequestRequest request);
        partial void PrepareAcceptProjectTransferRequestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string requestId,
            global::Neon.AcceptProjectTransferRequestRequest request);
        partial void ProcessAcceptProjectTransferRequestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Accept a project transfer request<br/>
        /// Accepts a transfer request for the specified project, transferring it to the specified organization<br/>
        /// or user. If org_id is not passed, the project will be transferred to the current user or organization account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AcceptProjectTransferRequestAsync(
            string projectId,
            string requestId,

            global::Neon.AcceptProjectTransferRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAcceptProjectTransferRequestArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                requestId: ref requestId,
                request: request);


            var __authorizations = global::Neon.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AcceptProjectTransferRequestSecurityRequirements,
                operationName: "AcceptProjectTransferRequestAsync");

            var __pathBuilder = new global::Neon.PathBuilder(
                path: $"/projects/{projectId}/transfer_requests/{requestId}",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareAcceptProjectTransferRequestRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                requestId: requestId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAcceptProjectTransferRequestResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Account doesn't satisfy the plan requirements to own the project
            if ((int)__response.StatusCode == 406)
            {
                string? __content_406 = null;
                global::System.Exception? __exception_406 = null;
                global::Neon.AcceptProjectTransferRequestSatisfiesPlanError? __value_406 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_406 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_406 = global::Neon.AcceptProjectTransferRequestSatisfiesPlanError.FromJson(__content_406, JsonSerializerContext);
                    }
                    else
                    {
                        __content_406 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_406 = global::Neon.AcceptProjectTransferRequestSatisfiesPlanError.FromJson(__content_406, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_406 = __ex;
                }

                throw new global::Neon.ApiException<global::Neon.AcceptProjectTransferRequestSatisfiesPlanError>(
                    message: __content_406 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_406,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_406,
                    ResponseObject = __value_406,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Accept a project transfer request<br/>
        /// Accepts a transfer request for the specified project, transferring it to the specified organization<br/>
        /// or user. If org_id is not passed, the project will be transferred to the current user or organization account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestId"></param>
        /// <param name="orgId">
        /// The Neon organization ID to transfer the project to. If not provided, the project will be<br/>
        /// transferred to the current user or organization account.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AcceptProjectTransferRequestAsync(
            string projectId,
            string requestId,
            string? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neon.AcceptProjectTransferRequestRequest
            {
                OrgId = orgId,
            };

            await AcceptProjectTransferRequestAsync(
                projectId: projectId,
                requestId: requestId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}