
#nullable enable

namespace Neon
{
    /// <summary>
    /// Fields to update on the snapshot. Updatable fields include `name` and `expires_at`.
    /// </summary>
    public sealed partial class SnapshotUpdateRequestSnapshot
    {
        /// <summary>
        /// Human-readable label for the snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The date and time when the snapshot will expire.<br/>
        /// Omit to leave the current expiration unchanged. Send `null` to<br/>
        /// clear the expiration so the snapshot never expires. A future<br/>
        /// timestamp sets the absolute expiration.<br/>
        /// Example: 2030-06-09T18:02:16Z
        /// </summary>
        /// <example>2030-06-09T18:02:16Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotUpdateRequestSnapshot" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable label for the snapshot.
        /// </param>
        /// <param name="expiresAt">
        /// The date and time when the snapshot will expire.<br/>
        /// Omit to leave the current expiration unchanged. Send `null` to<br/>
        /// clear the expiration so the snapshot never expires. A future<br/>
        /// timestamp sets the absolute expiration.<br/>
        /// Example: 2030-06-09T18:02:16Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnapshotUpdateRequestSnapshot(
            string? name,
            global::System.DateTime? expiresAt)
        {
            this.Name = name;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotUpdateRequestSnapshot" /> class.
        /// </summary>
        public SnapshotUpdateRequestSnapshot()
        {
        }

    }
}