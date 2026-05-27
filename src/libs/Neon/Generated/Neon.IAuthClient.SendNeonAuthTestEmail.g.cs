#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Send test email<br/>
        /// Sends a test email using the configured email server settings to verify SMTP connectivity and credentials.<br/>
        /// The request body must include the SMTP server settings<br/>
        /// (`host`, `port`, `username`, `password`, `sender_email`, `sender_name`) and the `recipient_email` address.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SendNeonAuthTestEmailResponse> SendNeonAuthTestEmailAsync(
            string projectId,
            string branchId,

            global::Neon.SendNeonAuthTestEmailRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send test email<br/>
        /// Sends a test email using the configured email server settings to verify SMTP connectivity and credentials.<br/>
        /// The request body must include the SMTP server settings<br/>
        /// (`host`, `port`, `username`, `password`, `sender_email`, `sender_name`) and the `recipient_email` address.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.SendNeonAuthTestEmailResponse>> SendNeonAuthTestEmailAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.SendNeonAuthTestEmailRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send test email<br/>
        /// Sends a test email using the configured email server settings to verify SMTP connectivity and credentials.<br/>
        /// The request body must include the SMTP server settings<br/>
        /// (`host`, `port`, `username`, `password`, `sender_email`, `sender_name`) and the `recipient_email` address.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SendNeonAuthTestEmailResponse> SendNeonAuthTestEmailAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}