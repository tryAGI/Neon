
#nullable enable

namespace Neon
{
    public partial class AuthClient
    {
        partial void PrepareUpdateNeonAuthEmailAndPasswordConfigArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string branchId,
            global::Neon.NeonAuthEmailAndPasswordConfigUpdate request);
        partial void PrepareUpdateNeonAuthEmailAndPasswordConfigRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string branchId,
            global::Neon.NeonAuthEmailAndPasswordConfigUpdate request);
        partial void ProcessUpdateNeonAuthEmailAndPasswordConfigResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateNeonAuthEmailAndPasswordConfigResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update email and password configuration<br/>
        /// Updates the email and password authentication configuration for Neon Auth
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.NeonAuthEmailAndPasswordConfig> UpdateNeonAuthEmailAndPasswordConfigAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthEmailAndPasswordConfigUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateNeonAuthEmailAndPasswordConfigArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                branchId: ref branchId,
                request: request);

            var __pathBuilder = new global::Neon.PathBuilder(
                path: $"/projects/{projectId}/branches/{branchId}/auth/email_and_password",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdateNeonAuthEmailAndPasswordConfigRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                branchId: branchId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateNeonAuthEmailAndPasswordConfigResponse(
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
                ProcessUpdateNeonAuthEmailAndPasswordConfigResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Neon.NeonAuthEmailAndPasswordConfig.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Neon.NeonAuthEmailAndPasswordConfig.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update email and password configuration<br/>
        /// Updates the email and password authentication configuration for Neon Auth
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Whether email and password authentication is enabled
        /// </param>
        /// <param name="emailVerificationMethod">
        /// The email verification method to use.<br/>
        /// - `link`: Sends a verification link via email<br/>
        /// - `otp`: Sends a one-time password (OTP) via email
        /// </param>
        /// <param name="requireEmailVerification">
        /// Whether email verification is required before users can sign in
        /// </param>
        /// <param name="autoSignInAfterVerification">
        /// Whether users are automatically signed in after verifying their email
        /// </param>
        /// <param name="sendVerificationEmailOnSignUp">
        /// Whether to send a verification email when users sign up
        /// </param>
        /// <param name="sendVerificationEmailOnSignIn">
        /// Whether to send a verification email when users sign in
        /// </param>
        /// <param name="disableSignUp">
        /// Whether to disable new user sign ups
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Neon.NeonAuthEmailAndPasswordConfig> UpdateNeonAuthEmailAndPasswordConfigAsync(
            string projectId,
            string branchId,
            bool? enabled = default,
            global::Neon.NeonAuthEmailVerificationMethod? emailVerificationMethod = default,
            bool? requireEmailVerification = default,
            bool? autoSignInAfterVerification = default,
            bool? sendVerificationEmailOnSignUp = default,
            bool? sendVerificationEmailOnSignIn = default,
            bool? disableSignUp = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Neon.NeonAuthEmailAndPasswordConfigUpdate
            {
                Enabled = enabled,
                EmailVerificationMethod = emailVerificationMethod,
                RequireEmailVerification = requireEmailVerification,
                AutoSignInAfterVerification = autoSignInAfterVerification,
                SendVerificationEmailOnSignUp = sendVerificationEmailOnSignUp,
                SendVerificationEmailOnSignIn = sendVerificationEmailOnSignIn,
                DisableSignUp = disableSignUp,
            };

            return await UpdateNeonAuthEmailAndPasswordConfigAsync(
                projectId: projectId,
                branchId: branchId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}