
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCredentialResponse
    {
        /// <summary>
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;).
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
        /// Customer-supplied label, echoed back from the request. Absent when not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Bearer token; returned exactly once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiToken { get; set; }

        /// <summary>
        /// nsk_live_&lt;64 hex&gt;; the AWS_SECRET_ACCESS_KEY, returned exactly once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3SecretAccessKey { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the credential expires; absent means never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialResponse" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;).
        /// </param>
        /// <param name="tokenIdShort">
        /// First 12 hex chars of token_id; safe to log.
        /// </param>
        /// <param name="apiToken">
        /// Bearer token; returned exactly once.
        /// </param>
        /// <param name="s3SecretAccessKey">
        /// nsk_live_&lt;64 hex&gt;; the AWS_SECRET_ACCESS_KEY, returned exactly once.
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="branchId"></param>
        /// <param name="createdAt"></param>
        /// <param name="name">
        /// Customer-supplied label, echoed back from the request. Absent when not provided.
        /// </param>
        /// <param name="expiresAt">
        /// When the credential expires; absent means never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCredentialResponse(
            string tokenId,
            string tokenIdShort,
            string apiToken,
            string s3SecretAccessKey,
            global::System.Collections.Generic.IList<global::Neon.CredentialScope> scopes,
            string branchId,
            global::System.DateTime createdAt,
            string? name,
            global::System.DateTime? expiresAt)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.TokenIdShort = tokenIdShort ?? throw new global::System.ArgumentNullException(nameof(tokenIdShort));
            this.Name = name;
            this.ApiToken = apiToken ?? throw new global::System.ArgumentNullException(nameof(apiToken));
            this.S3SecretAccessKey = s3SecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(s3SecretAccessKey));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialResponse" /> class.
        /// </summary>
        public CreateCredentialResponse()
        {
        }

    }
}