
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Snapshot
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsn")]
        public string? Lsn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        public string? SourceBranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual")]
        public bool? Manual { get; set; }

        /// <summary>
        /// Full logical size of the snapshot in bytes at the time it was taken.<br/>
        /// When absent, the logical size has not been calculated yet and the snapshot is not being charged.<br/>
        /// When present, a value of 0 means the snapshot is not being charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_size")]
        public long? FullSize { get; set; }

        /// <summary>
        /// Incremental storage size in bytes since the previous scheduled snapshot, when the snapshot is billed on incremental (diff) usage.<br/>
        /// When absent, either the incremental size has not been calculated yet and the snapshot is not being charged, or the snapshot is charged at full logical size (in that case `full_size` is set).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_size")]
        public long? DiffSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="lsn"></param>
        /// <param name="timestamp"></param>
        /// <param name="sourceBranchId"></param>
        /// <param name="expiresAt"></param>
        /// <param name="manual"></param>
        /// <param name="fullSize">
        /// Full logical size of the snapshot in bytes at the time it was taken.<br/>
        /// When absent, the logical size has not been calculated yet and the snapshot is not being charged.<br/>
        /// When present, a value of 0 means the snapshot is not being charged.
        /// </param>
        /// <param name="diffSize">
        /// Incremental storage size in bytes since the previous scheduled snapshot, when the snapshot is billed on incremental (diff) usage.<br/>
        /// When absent, either the incremental size has not been calculated yet and the snapshot is not being charged, or the snapshot is charged at full logical size (in that case `full_size` is set).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Snapshot(
            string id,
            string name,
            string createdAt,
            string? lsn,
            string? timestamp,
            string? sourceBranchId,
            string? expiresAt,
            bool? manual,
            long? fullSize,
            long? diffSize)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Lsn = lsn;
            this.Timestamp = timestamp;
            this.SourceBranchId = sourceBranchId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ExpiresAt = expiresAt;
            this.Manual = manual;
            this.FullSize = fullSize;
            this.DiffSize = diffSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        public Snapshot()
        {
        }
    }
}