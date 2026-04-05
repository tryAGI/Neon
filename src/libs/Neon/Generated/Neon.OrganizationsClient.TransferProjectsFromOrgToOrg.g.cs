
#nullable enable

namespace Neon
{
    public partial class OrganizationsClient
    {
        partial void PrepareTransferProjectsFromOrgToOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sourceOrgId,
            global::Neon.TransferProjectsToOrganizationRequest request);
        partial void PrepareTransferProjectsFromOrgToOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sourceOrgId,
            global::Neon.TransferProjectsToOrganizationRequest request);
        partial void ProcessTransferProjectsFromOrgToOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTransferProjectsFromOrgToOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Transfer projects between organizations<br/>
        /// Transfers selected projects, identified by their IDs, from your organization to another specified organization.
        /// </summary>
        /// <param name="sourceOrgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> TransferProjectsFromOrgToOrgAsync(
            string sourceOrgId,

            global::Neon.TransferProjectsToOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTransferProjectsFromOrgToOrgArguments(
                httpClient: HttpClient,
                sourceOrgId: ref sourceOrgId,
                request: request);

            var __pathBuilder = new global::Neon.PathBuilder(
                path: $"/organizations/{sourceOrgId}/projects/transfer",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTransferProjectsFromOrgToOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sourceOrgId: sourceOrgId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTransferProjectsFromOrgToOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Transfer failed - the target organization has too many projects or its plan is incompatible with the source organization. Reduce projects or upgrade the organization.
            if ((int)__response.StatusCode == 406)
            {
                string? __content_406 = null;
                global::System.Exception? __exception_406 = null;
                global::Neon.LimitsUnsatisfiedResponse? __value_406 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_406 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_406 = global::Neon.LimitsUnsatisfiedResponse.FromJson(__content_406, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_406 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_406 = global::Neon.LimitsUnsatisfiedResponse.FromJson(__content_406, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_406 = __ex;
                }

                throw new global::Neon.ApiException<global::Neon.LimitsUnsatisfiedResponse>(
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
            // One or more of the provided project IDs have GitHub or Vercel integrations installed. Transferring integration projects is currently not supported
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Neon.ProjectsWithIntegrationResponse? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Neon.ProjectsWithIntegrationResponse.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Neon.ProjectsWithIntegrationResponse.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Neon.ApiException<global::Neon.ProjectsWithIntegrationResponse>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                        __value_default = global::Neon.GeneralError.FromJson(__content_default, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Neon.GeneralError.FromJson(__content_default, JsonSerializerOptions);
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
                ProcessTransferProjectsFromOrgToOrgResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Neon.EmptyResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Neon.EmptyResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Transfer projects between organizations<br/>
        /// Transfers selected projects, identified by their IDs, from your organization to another specified organization.
        /// </summary>
        /// <param name="sourceOrgId"></param>
        /// <param name="destinationOrgId">
        /// The destination organization identifier
        /// </param>
        /// <param name="projectIds">
        /// The list of projects ids to transfer. Maximum of 400 project ids
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> TransferProjectsFromOrgToOrgAsync(
            string sourceOrgId,
            string destinationOrgId,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neon.TransferProjectsToOrganizationRequest
            {
                DestinationOrgId = destinationOrgId,
                ProjectIds = projectIds,
            };

            return await TransferProjectsFromOrgToOrgAsync(
                sourceOrgId: sourceOrgId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}