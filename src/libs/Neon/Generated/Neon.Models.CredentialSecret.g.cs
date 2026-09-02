
#nullable enable

namespace Neon
{
    /// <summary>
    /// The live secrets of an existing credential, recovered on demand by the<br/>
    /// reveal endpoint. `api_token` and `s3_secret_access_key` are the same<br/>
    /// values handed back once at issuance.<br/>
    /// The field set is deliberately narrower than `CreateCredentialResponse`:<br/>
    /// it carries only what reveal can actually recover. `token_id_short`,<br/>
    /// `scopes`, `principal_type`, `created_at` and `expires_at` are metadata,<br/>
    /// not secrets — read them from the list endpoint instead.<br/>
    /// No `branch_id` is returned. Reveal is scoped by `(project_id,<br/>
    /// token_id)`, so the branch in the request path authorizes the call but<br/>
    /// is not proven to be the branch the credential was issued on. Echoing it<br/>
    /// back would assert an anchor this endpoint never verified. For a<br/>
    /// credential's true anchor branch, read `branch_id` from the list<br/>
    /// endpoint, which is branch-exact.
    /// </summary>
    public sealed partial class CredentialSecret
    {
        /// <summary>
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// Bearer token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiToken { get; set; }

        /// <summary>
        /// nsk_live_&lt;64 hex&gt;; the AWS_SECRET_ACCESS_KEY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3SecretAccessKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialSecret" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// Opaque credential id (e.g. nak_live_&lt;32hex&gt;).
        /// </param>
        /// <param name="apiToken">
        /// Bearer token.
        /// </param>
        /// <param name="s3SecretAccessKey">
        /// nsk_live_&lt;64 hex&gt;; the AWS_SECRET_ACCESS_KEY.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialSecret(
            string tokenId,
            string apiToken,
            string s3SecretAccessKey)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.ApiToken = apiToken ?? throw new global::System.ArgumentNullException(nameof(apiToken));
            this.S3SecretAccessKey = s3SecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(s3SecretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialSecret" /> class.
        /// </summary>
        public CredentialSecret()
        {
        }

    }
}