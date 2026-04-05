
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthIntegration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthProviderProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthProviderProjectOwnedBy OwnedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusJsonConverter))]
        public global::Neon.NeonAuthProviderProjectTransferStatus? TransferStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthIntegration" /> class.
        /// </summary>
        /// <param name="authProvider"></param>
        /// <param name="authProviderProjectId"></param>
        /// <param name="branchId"></param>
        /// <param name="dbName"></param>
        /// <param name="createdAt"></param>
        /// <param name="ownedBy"></param>
        /// <param name="jwksUrl"></param>
        /// <param name="transferStatus"></param>
        /// <param name="baseUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthIntegration(
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string authProviderProjectId,
            string branchId,
            string dbName,
            global::System.DateTime createdAt,
            global::Neon.NeonAuthProviderProjectOwnedBy ownedBy,
            string jwksUrl,
            global::Neon.NeonAuthProviderProjectTransferStatus? transferStatus,
            string? baseUrl)
        {
            this.AuthProvider = authProvider;
            this.AuthProviderProjectId = authProviderProjectId ?? throw new global::System.ArgumentNullException(nameof(authProviderProjectId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CreatedAt = createdAt;
            this.OwnedBy = ownedBy;
            this.TransferStatus = transferStatus;
            this.JwksUrl = jwksUrl ?? throw new global::System.ArgumentNullException(nameof(jwksUrl));
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthIntegration" /> class.
        /// </summary>
        public NeonAuthIntegration()
        {
        }
    }
}