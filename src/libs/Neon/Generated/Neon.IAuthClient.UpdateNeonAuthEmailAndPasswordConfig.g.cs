#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update email and password configuration<br/>
        /// Updates the email and password authentication configuration for Neon Auth
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthEmailAndPasswordConfig> UpdateNeonAuthEmailAndPasswordConfigAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthEmailAndPasswordConfigUpdate request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthEmailAndPasswordConfig> UpdateNeonAuthEmailAndPasswordConfigAsync(
            string projectId,
            string branchId,
            bool? enabled = default,
            global::Neon.NeonAuthEmailVerificationMethod? emailVerificationMethod = default,
            bool? requireEmailVerification = default,
            bool? autoSignInAfterVerification = default,
            bool? sendVerificationEmailOnSignUp = default,
            bool? sendVerificationEmailOnSignIn = default,
            bool? disableSignUp = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}