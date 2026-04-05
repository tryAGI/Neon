
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthEmailAndPasswordConfig
    {
        /// <summary>
        /// Whether email and password authentication is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The email verification method to use.<br/>
        /// - `link`: Sends a verification link via email<br/>
        /// - `otp`: Sends a one-time password (OTP) via email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verification_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthEmailVerificationMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthEmailVerificationMethod EmailVerificationMethod { get; set; }

        /// <summary>
        /// Whether email verification is required before users can sign in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_email_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireEmailVerification { get; set; }

        /// <summary>
        /// Whether users are automatically signed in after verifying their email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sign_in_after_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoSignInAfterVerification { get; set; }

        /// <summary>
        /// Whether to send a verification email when users sign up
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_verification_email_on_sign_up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SendVerificationEmailOnSignUp { get; set; }

        /// <summary>
        /// Whether to send a verification email when users sign in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_verification_email_on_sign_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SendVerificationEmailOnSignIn { get; set; }

        /// <summary>
        /// Whether to disable new user sign ups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_sign_up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableSignUp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthEmailAndPasswordConfig" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthEmailAndPasswordConfig(
            bool enabled,
            global::Neon.NeonAuthEmailVerificationMethod emailVerificationMethod,
            bool requireEmailVerification,
            bool autoSignInAfterVerification,
            bool sendVerificationEmailOnSignUp,
            bool sendVerificationEmailOnSignIn,
            bool disableSignUp)
        {
            this.Enabled = enabled;
            this.EmailVerificationMethod = emailVerificationMethod;
            this.RequireEmailVerification = requireEmailVerification;
            this.AutoSignInAfterVerification = autoSignInAfterVerification;
            this.SendVerificationEmailOnSignUp = sendVerificationEmailOnSignUp;
            this.SendVerificationEmailOnSignIn = sendVerificationEmailOnSignIn;
            this.DisableSignUp = disableSignUp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthEmailAndPasswordConfig" /> class.
        /// </summary>
        public NeonAuthEmailAndPasswordConfig()
        {
        }
    }
}