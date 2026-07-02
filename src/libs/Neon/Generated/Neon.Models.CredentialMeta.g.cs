
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialMeta
    {
        /// <summary>
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id_short")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenIdShort { get; set; }

        /// <summary>
        /// Customer-supplied label; absent when not provided at issuance.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrincipalType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_id")]
        public string? FunctionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// When the credential expires; absent means never expires. The<br/>
        /// verifier refuses to authenticate after `expires_at &lt;= now()`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialMeta" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;).
        /// </param>
        /// <param name="tokenIdShort"></param>
        /// <param name="scopes"></param>
        /// <param name="principalType"></param>
        /// <param name="createdAt"></param>
        /// <param name="name">
        /// Customer-supplied label; absent when not provided at issuance.
        /// </param>
        /// <param name="branchId"></param>
        /// <param name="functionId"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="revokedAt"></param>
        /// <param name="expiresAt">
        /// When the credential expires; absent means never expires. The<br/>
        /// verifier refuses to authenticate after `expires_at &lt;= now()`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialMeta(
            string tokenId,
            string tokenIdShort,
            global::System.Collections.Generic.IList<global::Neon.CredentialScope> scopes,
            string principalType,
            global::System.DateTime createdAt,
            string? name,
            string? branchId,
            string? functionId,
            global::System.DateTime? lastUsedAt,
            global::System.DateTime? revokedAt,
            global::System.DateTime? expiresAt)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.TokenIdShort = tokenIdShort ?? throw new global::System.ArgumentNullException(nameof(tokenIdShort));
            this.Name = name;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.BranchId = branchId;
            this.PrincipalType = principalType ?? throw new global::System.ArgumentNullException(nameof(principalType));
            this.FunctionId = functionId;
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.RevokedAt = revokedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialMeta" /> class.
        /// </summary>
        public CredentialMeta()
        {
        }

    }
}