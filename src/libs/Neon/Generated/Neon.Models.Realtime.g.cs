
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Realtime
    {
        /// <summary>
        /// Whether Realtime is enabled for the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether a provisioning, settings, rotation or deprovisioning change is still being applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pending { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_url")]
        public string? InvocationUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Realtime" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether Realtime is enabled for the branch.
        /// </param>
        /// <param name="pending">
        /// Whether a provisioning, settings, rotation or deprovisioning change is still being applied.
        /// </param>
        /// <param name="invocationUrl"></param>
        /// <param name="revision"></param>
        /// <param name="allowedOrigins"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Realtime(
            bool enabled,
            bool pending,
            string? invocationUrl,
            int? revision,
            global::System.Collections.Generic.IList<string>? allowedOrigins)
        {
            this.Enabled = enabled;
            this.Pending = pending;
            this.InvocationUrl = invocationUrl;
            this.Revision = revision;
            this.AllowedOrigins = allowedOrigins;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Realtime" /> class.
        /// </summary>
        public Realtime()
        {
        }

    }
}