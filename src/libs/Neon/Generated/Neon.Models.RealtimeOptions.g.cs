
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeOptions
    {
        /// <summary>
        /// The browser origins allowed to connect, each `http` or `https` with a host and optional port<br/>
        /// and no path. An empty list, or `*` alone, allows any origin. Omitted keeps the current or<br/>
        /// inherited value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeOptions" /> class.
        /// </summary>
        /// <param name="allowedOrigins">
        /// The browser origins allowed to connect, each `http` or `https` with a host and optional port<br/>
        /// and no path. An empty list, or `*` alone, allows any origin. Omitted keeps the current or<br/>
        /// inherited value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeOptions(
            global::System.Collections.Generic.IList<string>? allowedOrigins)
        {
            this.AllowedOrigins = allowedOrigins;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeOptions" /> class.
        /// </summary>
        public RealtimeOptions()
        {
        }

    }
}