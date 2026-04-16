
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthPhoneNumberConfig
    {
        /// <summary>
        /// Whether the phone number plugin is enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Time in seconds before the OTP expires<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otp_expires_in")]
        public int? OtpExpiresIn { get; set; }

        /// <summary>
        /// Maximum number of OTP verification attempts before lockout<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_attempts")]
        public int? AllowedAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthPhoneNumberConfig" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthPhoneNumberConfig(
            bool enabled,
            int? otpExpiresIn,
            int? allowedAttempts)
        {
            this.Enabled = enabled;
            this.OtpExpiresIn = otpExpiresIn;
            this.AllowedAttempts = allowedAttempts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthPhoneNumberConfig" /> class.
        /// </summary>
        public NeonAuthPhoneNumberConfig()
        {
        }
    }
}