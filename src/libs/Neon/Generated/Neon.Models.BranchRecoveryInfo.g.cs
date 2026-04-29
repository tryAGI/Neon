
#nullable enable

namespace Neon
{
    /// <summary>
    /// Recovery information for a deleted branch. Only present when listing deleted branches<br/>
    /// with `include_deleted=true`.<br/>
    /// This is part of the Branch Recovery feature, which is in preview and not available to all users.
    /// </summary>
    public sealed partial class BranchRecoveryInfo
    {
        /// <summary>
        /// Timestamp when the branch was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DeletedAt { get; set; }

        /// <summary>
        /// Timestamp when the recovery window expires and the branch will be permanently deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recoverable_until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RecoverableUntil { get; set; }

        /// <summary>
        /// How the branch was deleted: 'user' for manual deletion, 'ttl' for TTL expiration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BranchRecoveryInfoDeletionMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BranchRecoveryInfoDeletionMethod DeletionMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRecoveryInfo" /> class.
        /// </summary>
        /// <param name="deletedAt">
        /// Timestamp when the branch was deleted
        /// </param>
        /// <param name="recoverableUntil">
        /// Timestamp when the recovery window expires and the branch will be permanently deleted
        /// </param>
        /// <param name="deletionMethod">
        /// How the branch was deleted: 'user' for manual deletion, 'ttl' for TTL expiration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchRecoveryInfo(
            global::System.DateTime deletedAt,
            global::System.DateTime recoverableUntil,
            global::Neon.BranchRecoveryInfoDeletionMethod deletionMethod)
        {
            this.DeletedAt = deletedAt;
            this.RecoverableUntil = recoverableUntil;
            this.DeletionMethod = deletionMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRecoveryInfo" /> class.
        /// </summary>
        public BranchRecoveryInfo()
        {
        }
    }
}