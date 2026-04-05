
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSnapshotResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Snapshot Snapshot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSnapshotResponse" /> class.
        /// </summary>
        /// <param name="snapshot"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSnapshotResponse(
            global::Neon.Snapshot snapshot)
        {
            this.Snapshot = snapshot ?? throw new global::System.ArgumentNullException(nameof(snapshot));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSnapshotResponse" /> class.
        /// </summary>
        public UpdateSnapshotResponse()
        {
        }
    }
}