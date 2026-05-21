
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthPhoneNumberConfigUpdate
    {
        /// <summary>
        /// Whether the phone number plugin is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time in seconds before the OTP expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otp_expires_in")]
        public int? OtpExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthPhoneNumberConfigUpdate" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the phone number plugin is enabled
        /// </param>
        /// <param name="otpExpiresIn">
        /// Time in seconds before the OTP expires
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthPhoneNumberConfigUpdate(
            bool? enabled,
            int? otpExpiresIn)
        {
            this.Enabled = enabled;
            this.OtpExpiresIn = otpExpiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthPhoneNumberConfigUpdate" /> class.
        /// </summary>
        public NeonAuthPhoneNumberConfigUpdate()
        {
        }

    }
}