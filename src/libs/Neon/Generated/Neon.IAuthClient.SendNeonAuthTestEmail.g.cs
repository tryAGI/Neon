#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Send test email<br/>
        /// Sends a test email to the specified email address.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SendNeonAuthTestEmailResponse> SendNeonAuthTestEmailAsync(
            string projectId,
            string branchId,

            global::Neon.SendNeonAuthTestEmailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send test email<br/>
        /// Sends a test email to the specified email address.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SendNeonAuthTestEmailResponse> SendNeonAuthTestEmailAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}