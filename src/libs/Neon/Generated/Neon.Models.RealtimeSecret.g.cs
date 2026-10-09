
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSecret
    {
        /// <summary>
        /// The key the application backend issues Realtime tokens with, `nrt_live_1` followed by the unpadded base64url 32-byte AES-256-GCM key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Whether a change is still being applied. After a rotation, the secret changes when this becomes false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSecret" /> class.
        /// </summary>
        /// <param name="secret">
        /// The key the application backend issues Realtime tokens with, `nrt_live_1` followed by the unpadded base64url 32-byte AES-256-GCM key.
        /// </param>
        /// <param name="pending">
        /// Whether a change is still being applied. After a rotation, the secret changes when this becomes false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSecret(
            string secret,
            bool pending)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.Pending = pending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSecret" /> class.
        /// </summary>
        public RealtimeSecret()
        {
        }

    }
}