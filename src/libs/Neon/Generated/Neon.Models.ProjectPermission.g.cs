
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectPermission
    {
        /// <summary>
        /// The project permission's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address of the user who has been granted access to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_to_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantedToEmail { get; set; }

        /// <summary>
        /// Timestamp when the permission was granted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime GrantedAt { get; set; }

        /// <summary>
        /// Timestamp when the permission was revoked. Null if the permission is still active.
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
        /// <param name="id">
        /// The project permission's ID.
        /// </param>
        /// <param name="grantedToEmail">
        /// Email address of the user who has been granted access to the project.
        /// </param>
        /// <param name="grantedAt">
        /// Timestamp when the permission was granted.
        /// </param>
        /// <param name="revokedAt">
        /// Timestamp when the permission was revoked. Null if the permission is still active.
        /// </param>
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