
#nullable enable

namespace Neon
{
    /// <summary>
    /// The replacement secret material for an existing credential, returned<br/>
    /// exactly once. `token_id`, `scopes`, `branch_id` and `created_at` are<br/>
    /// unchanged by the rotation — only `api_token` and<br/>
    /// `s3_secret_access_key` are new.
    /// </summary>
    public sealed partial class RotateCredentialResponse
    {
        /// <summary>
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;), unchanged by the<br/>
        /// rotation. Doubles as the `AWS_ACCESS_KEY_ID` for SigV4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// First 12 hex chars of token_id; safe to log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id_short")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenIdShort { get; set; }

        /// <summary>
        /// Customer-supplied label carried on the credential. Absent when none was set at issuance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The new Bearer token; returned exactly once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiToken { get; set; }

        /// <summary>
        /// The new nsk_live_&lt;64 hex&gt; AWS_SECRET_ACCESS_KEY; returned exactly once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3SecretAccessKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.GrantedCredentialScope> Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// Always `user`: only customer-managed credentials are rotatable<br/>
        /// through this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.RotateCredentialResponsePrincipalTypeJsonConverter))]
        public global::Neon.RotateCredentialResponsePrincipalType PrincipalType { get; set; }

        /// <summary>
        /// When the credential was originally issued. Rotation replaces the<br/>
        /// secrets in place and does not reset this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the credential expires; absent means never expires. Rotation<br/>
        /// does not extend it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateCredentialResponse" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;), unchanged by the<br/>
        /// rotation. Doubles as the `AWS_ACCESS_KEY_ID` for SigV4.
        /// </param>
        /// <param name="tokenIdShort">
        /// First 12 hex chars of token_id; safe to log.
        /// </param>
        /// <param name="apiToken">
        /// The new Bearer token; returned exactly once.
        /// </param>
        /// <param name="s3SecretAccessKey">
        /// The new nsk_live_&lt;64 hex&gt; AWS_SECRET_ACCESS_KEY; returned exactly once.
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="branchId"></param>
        /// <param name="createdAt">
        /// When the credential was originally issued. Rotation replaces the<br/>
        /// secrets in place and does not reset this.
        /// </param>
        /// <param name="name">
        /// Customer-supplied label carried on the credential. Absent when none was set at issuance.
        /// </param>
        /// <param name="principalType">
        /// Always `user`: only customer-managed credentials are rotatable<br/>
        /// through this endpoint.
        /// </param>
        /// <param name="expiresAt">
        /// When the credential expires; absent means never expires. Rotation<br/>
        /// does not extend it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateCredentialResponse(
            string tokenId,
            string tokenIdShort,
            string apiToken,
            string s3SecretAccessKey,
            global::System.Collections.Generic.IList<global::Neon.GrantedCredentialScope> scopes,
            string branchId,
            global::System.DateTime createdAt,
            string? name,
            global::Neon.RotateCredentialResponsePrincipalType principalType,
            global::System.DateTime? expiresAt)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.TokenIdShort = tokenIdShort ?? throw new global::System.ArgumentNullException(nameof(tokenIdShort));
            this.Name = name;
            this.ApiToken = apiToken ?? throw new global::System.ArgumentNullException(nameof(apiToken));
            this.S3SecretAccessKey = s3SecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(s3SecretAccessKey));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.PrincipalType = principalType;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateCredentialResponse" /> class.
        /// </summary>
        public RotateCredentialResponse()
        {
        }

    }
}