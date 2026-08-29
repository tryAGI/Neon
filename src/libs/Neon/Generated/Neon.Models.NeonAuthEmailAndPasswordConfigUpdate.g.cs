
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthEmailAndPasswordConfigUpdate
    {
        /// <summary>
        /// Controls whether email and password authentication is enabled for this project. When omitted from an update request, the current value is unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The email verification method to use.<br/>
        /// - `link`: Sends a verification link via email<br/>
        /// - `otp`: Sends a one-time password (OTP) via email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verification_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthEmailVerificationMethodJsonConverter))]
        public global::Neon.NeonAuthEmailVerificationMethod? EmailVerificationMethod { get; set; }

        /// <summary>
        /// When true, users must verify their email address before they can sign in. Omitting this field from an update request leaves the current value unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_email_verification")]
        public bool? RequireEmailVerification { get; set; }

        /// <summary>
        /// Whether users are automatically signed in after verifying their email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sign_in_after_verification")]
        public bool? AutoSignInAfterVerification { get; set; }

        /// <summary>
        /// Whether to send a verification email when users sign up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_verification_email_on_sign_up")]
        public bool? SendVerificationEmailOnSignUp { get; set; }

        /// <summary>
        /// Whether to send a verification email when a user with an unverified email signs in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_verification_email_on_sign_in")]
        public bool? SendVerificationEmailOnSignIn { get; set; }

        /// <summary>
        /// Whether to disable new user sign ups. When omitted, the current setting is not changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_sign_up")]
        public bool? DisableSignUp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthEmailAndPasswordConfigUpdate" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Controls whether email and password authentication is enabled for this project. When omitted from an update request, the current value is unchanged.
        /// </param>
        /// <param name="emailVerificationMethod">
        /// The email verification method to use.<br/>
        /// - `link`: Sends a verification link via email<br/>
        /// - `otp`: Sends a one-time password (OTP) via email
        /// </param>
        /// <param name="requireEmailVerification">
        /// When true, users must verify their email address before they can sign in. Omitting this field from an update request leaves the current value unchanged.
        /// </param>
        /// <param name="autoSignInAfterVerification">
        /// Whether users are automatically signed in after verifying their email
        /// </param>
        /// <param name="sendVerificationEmailOnSignUp">
        /// Whether to send a verification email when users sign up.
        /// </param>
        /// <param name="sendVerificationEmailOnSignIn">
        /// Whether to send a verification email when a user with an unverified email signs in.
        /// </param>
        /// <param name="disableSignUp">
        /// Whether to disable new user sign ups. When omitted, the current setting is not changed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthEmailAndPasswordConfigUpdate(
            bool? enabled,
            global::Neon.NeonAuthEmailVerificationMethod? emailVerificationMethod,
            bool? requireEmailVerification,
            bool? autoSignInAfterVerification,
            bool? sendVerificationEmailOnSignUp,
            bool? sendVerificationEmailOnSignIn,
            bool? disableSignUp)
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
        /// Initializes a new instance of the <see cref="NeonAuthEmailAndPasswordConfigUpdate" /> class.
        /// </summary>
        public NeonAuthEmailAndPasswordConfigUpdate()
        {
        }

    }
}