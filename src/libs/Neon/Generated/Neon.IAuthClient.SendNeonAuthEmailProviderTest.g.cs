#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Send test email using the saved email provider<br/>
        /// Sends a test email using the branch's already-saved custom SMTP configuration. Only the<br/>
        /// `recipient_email` is provided — the stored SMTP settings and password are used server-side,<br/>
        /// so the caller does not need to re-supply (or be able to read) the password. This avoids the<br/>
        /// GET response's masked password being sent back, which would fail SMTP authentication.<br/>
        /// Requires a configured custom SMTP provider on a Better Auth integration. A shared provider,<br/>
        /// a missing configuration, or a non-Better-Auth integration is rejected.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SendNeonAuthTestEmailResponse> SendNeonAuthEmailProviderTestAsync(
            string projectId,
            string branchId,

            global::Neon.SendNeonAuthEmailProviderTestRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send test email using the saved email provider<br/>
        /// Sends a test email using the branch's already-saved custom SMTP configuration. Only the<br/>
        /// `recipient_email` is provided — the stored SMTP settings and password are used server-side,<br/>
        /// so the caller does not need to re-supply (or be able to read) the password. This avoids the<br/>
        /// GET response's masked password being sent back, which would fail SMTP authentication.<br/>
        /// Requires a configured custom SMTP provider on a Better Auth integration. A shared provider,<br/>
        /// a missing configuration, or a non-Better-Auth integration is rejected.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.SendNeonAuthTestEmailResponse>> SendNeonAuthEmailProviderTestAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.SendNeonAuthEmailProviderTestRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send test email using the saved email provider<br/>
        /// Sends a test email using the branch's already-saved custom SMTP configuration. Only the<br/>
        /// `recipient_email` is provided — the stored SMTP settings and password are used server-side,<br/>
        /// so the caller does not need to re-supply (or be able to read) the password. This avoids the<br/>
        /// GET response's masked password being sent back, which would fail SMTP authentication.<br/>
        /// Requires a configured custom SMTP provider on a Better Auth integration. A shared provider,<br/>
        /// a missing configuration, or a non-Better-Auth integration is rejected.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="recipientEmail">
        /// The email address to send the test email to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SendNeonAuthTestEmailResponse> SendNeonAuthEmailProviderTestAsync(
            string projectId,
            string branchId,
            string recipientEmail,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}