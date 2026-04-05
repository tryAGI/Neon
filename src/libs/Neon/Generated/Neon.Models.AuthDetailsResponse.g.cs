
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// 
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
        /// <param name="accountId"></param>
        /// <param name="authMethod"></param>
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