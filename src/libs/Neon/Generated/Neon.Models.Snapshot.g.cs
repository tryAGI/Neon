
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Snapshot
    {
        /// <summary>
        /// The snapshot ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label for the snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// WAL position (Log Sequence Number) at which the snapshot was captured, in Postgres LSN format (for example, `0/3000000`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsn")]
        public string? Lsn { get; set; }

        /// <summary>
        /// Point in time captured by the snapshot, in RFC 3339 format (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Branch from which this snapshot was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        public string? SourceBranchId { get; set; }

        /// <summary>
        /// Timestamp when the snapshot was created, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when the snapshot expires and is eligible for deletion. Null if the snapshot does not have an expiry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// True if the snapshot was created manually rather than by a schedule.
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
        /// Incremental Postgres storage size in bytes since the previous scheduled snapshot, when the snapshot is billed on incremental (diff) usage.<br/>
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
        /// <param name="id">
        /// The snapshot ID.
        /// </param>
        /// <param name="name">
        /// Human-readable label for the snapshot.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the snapshot was created, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </param>
        /// <param name="lsn">
        /// WAL position (Log Sequence Number) at which the snapshot was captured, in Postgres LSN format (for example, `0/3000000`).
        /// </param>
        /// <param name="timestamp">
        /// Point in time captured by the snapshot, in RFC 3339 format (UTC).
        /// </param>
        /// <param name="sourceBranchId">
        /// Branch from which this snapshot was created.
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 timestamp when the snapshot expires and is eligible for deletion. Null if the snapshot does not have an expiry.
        /// </param>
        /// <param name="manual">
        /// True if the snapshot was created manually rather than by a schedule.
        /// </param>
        /// <param name="fullSize">
        /// Full logical size of the snapshot in bytes at the time it was taken.<br/>
        /// When absent, the logical size has not been calculated yet and the snapshot is not being charged.<br/>
        /// When present, a value of 0 means the snapshot is not being charged.
        /// </param>
        /// <param name="diffSize">
        /// Incremental Postgres storage size in bytes since the previous scheduled snapshot, when the snapshot is billed on incremental (diff) usage.<br/>
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