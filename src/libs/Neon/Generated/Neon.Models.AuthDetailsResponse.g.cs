
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthDetailsResponse
    {
        /// <summary>
        /// The ID of the account associated with this authentication record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// Authentication method used for the request:<br/>
        /// - `keycloak`: Keycloak identity provider authentication.<br/>
        /// - `session_cookie`: Browser session cookie authentication.<br/>
        /// - `api_key_user`: API key scoped to a user account.<br/>
        /// - `api_key_org`: API key scoped to an organization.<br/>
        /// - `oauth`: OAuth-based authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.AuthDetailsResponseAuthMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.AuthDetailsResponseAuthMethod AuthMethod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_data")]
        public string? AuthData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDetailsResponse" /> class.
        /// </summary>
        /// <param name="accountId">
        /// The ID of the account associated with this authentication record.
        /// </param>
        /// <param name="authMethod">
        /// Authentication method used for the request:<br/>
        /// - `keycloak`: Keycloak identity provider authentication.<br/>
        /// - `session_cookie`: Browser session cookie authentication.<br/>
        /// - `api_key_user`: API key scoped to a user account.<br/>
        /// - `api_key_org`: API key scoped to an organization.<br/>
        /// - `oauth`: OAuth-based authentication.
        /// </param>
        /// <param name="authData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthDetailsResponse(
            string accountId,
            global::Neon.AuthDetailsResponseAuthMethod authMethod,
            string? authData)
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.AuthMethod = authMethod;
            this.AuthData = authData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthDetailsResponse" /> class.
        /// </summary>
        public AuthDetailsResponse()
        {
        }

    }
}