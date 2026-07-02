
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCredentialRequest
    {
        /// <summary>
        /// Free-form customer label for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.CredentialScope> Scopes { get; set; }

        /// <summary>
        /// Principal type for the credential. Only `user` is customer-managed<br/>
        /// and accepted here. `function` and `system` credentials are<br/>
        /// platform-internal (e.g. function-serve auto-mint, presign signer)<br/>
        /// and are never issued through the customer-facing API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.CreateCredentialRequestPrincipalTypeJsonConverter))]
        public global::Neon.CreateCredentialRequestPrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialRequest" /> class.
        /// </summary>
        /// <param name="scopes"></param>
        /// <param name="name">
        /// Free-form customer label for the credential.
        /// </param>
        /// <param name="principalType">
        /// Principal type for the credential. Only `user` is customer-managed<br/>
        /// and accepted here. `function` and `system` credentials are<br/>
        /// platform-internal (e.g. function-serve auto-mint, presign signer)<br/>
        /// and are never issued through the customer-facing API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCredentialRequest(
            global::System.Collections.Generic.IList<global::Neon.CredentialScope> scopes,
            string? name,
            global::Neon.CreateCredentialRequestPrincipalType principalType)
        {
            this.Name = name;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.PrincipalType = principalType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialRequest" /> class.
        /// </summary>
        public CreateCredentialRequest()
        {
        }

    }
}