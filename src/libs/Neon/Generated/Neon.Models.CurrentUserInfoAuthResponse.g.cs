
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CurrentUserInfoAuthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password_stored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PasswordStored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount> AuthAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.LinkedAuthAccount> LinkedAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserInfoAuthResponse" /> class.
        /// </summary>
        /// <param name="passwordStored"></param>
        /// <param name="authAccounts"></param>
        /// <param name="linkedAccounts"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentUserInfoAuthResponse(
            bool passwordStored,
            global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount> authAccounts,
            global::System.Collections.Generic.IList<global::Neon.LinkedAuthAccount> linkedAccounts,
            string provider)
        {
            this.PasswordStored = passwordStored;
            this.AuthAccounts = authAccounts ?? throw new global::System.ArgumentNullException(nameof(authAccounts));
            this.LinkedAccounts = linkedAccounts ?? throw new global::System.ArgumentNullException(nameof(linkedAccounts));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserInfoAuthResponse" /> class.
        /// </summary>
        public CurrentUserInfoAuthResponse()
        {
        }
    }
}