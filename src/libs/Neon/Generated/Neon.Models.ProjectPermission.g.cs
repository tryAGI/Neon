
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_to_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantedToEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime GrantedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectPermission" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="grantedToEmail"></param>
        /// <param name="grantedAt"></param>
        /// <param name="revokedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectPermission(
            string id,
            string grantedToEmail,
            global::System.DateTime grantedAt,
            global::System.DateTime? revokedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.GrantedToEmail = grantedToEmail ?? throw new global::System.ArgumentNullException(nameof(grantedToEmail));
            this.GrantedAt = grantedAt;
            this.RevokedAt = revokedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectPermission" /> class.
        /// </summary>
        public ProjectPermission()
        {
        }
    }
}