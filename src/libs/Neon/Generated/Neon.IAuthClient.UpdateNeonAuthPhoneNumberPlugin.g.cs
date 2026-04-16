#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update phone number plugin configuration<br/>
        /// Updates the phone number plugin configuration for Neon Auth.<br/>
        /// The phone number plugin enables phone-based OTP authentication.<br/>
        /// OTP codes are delivered via the `send.otp` webhook event with `delivery_preference: "sms"`.<br/>
        /// A webhook must be configured with the `send.otp` event enabled for SMS delivery to work.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthPhoneNumberConfig> UpdateNeonAuthPhoneNumberPluginAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthPhoneNumberConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update phone number plugin configuration<br/>
        /// Updates the phone number plugin configuration for Neon Auth.<br/>
        /// The phone number plugin enables phone-based OTP authentication.<br/>
        /// OTP codes are delivered via the `send.otp` webhook event with `delivery_preference: "sms"`.<br/>
        /// A webhook must be configured with the `send.otp` event enabled for SMS delivery to work.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Whether the phone number plugin is enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="otpExpiresIn">
        /// Time in seconds before the OTP expires<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="allowedAttempts">
        /// Maximum number of OTP verification attempts before lockout<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthPhoneNumberConfig> UpdateNeonAuthPhoneNumberPluginAsync(
            string projectId,
            string branchId,
            bool enabled,
            int? otpExpiresIn = default,
            int? allowedAttempts = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}