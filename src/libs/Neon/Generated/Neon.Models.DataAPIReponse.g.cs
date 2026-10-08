
#nullable enable

namespace Neon
{
    /// <summary>
    /// Neon Data API response
    /// </summary>
    public sealed partial class DataAPIReponse
    {
        /// <summary>
        /// The URL of the Neon Data API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The status of the Neon Data API deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Configuration settings for the Data API (SubZero only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.DataAPISettings? Settings { get; set; }

        /// <summary>
        /// List of available database schemas (SubZero only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_schemas")]
        public global::System.Collections.Generic.IList<string>? AvailableSchemas { get; set; }

        /// <summary>
        /// When `settings` and `available_schemas` were read from the database. While the<br/>
        /// compute is suspended they are served from that read, so a change made directly in<br/>
        /// the database since then shows up in the first response served while the compute is<br/>
        /// active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observed_at")]
        public global::System.DateTime? ObservedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPIReponse" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the Neon Data API
        /// </param>
        /// <param name="status">
        /// The status of the Neon Data API deployment
        /// </param>
        /// <param name="settings">
        /// Configuration settings for the Data API (SubZero only)
        /// </param>
        /// <param name="availableSchemas">
        /// List of available database schemas (SubZero only)
        /// </param>
        /// <param name="observedAt">
        /// When `settings` and `available_schemas` were read from the database. While the<br/>
        /// compute is suspended they are served from that read, so a change made directly in<br/>
        /// the database since then shows up in the first response served while the compute is<br/>
        /// active.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAPIReponse(
            string url,
            string status,
            global::Neon.DataAPISettings? settings,
            global::System.Collections.Generic.IList<string>? availableSchemas,
            global::System.DateTime? observedAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Settings = settings;
            this.AvailableSchemas = availableSchemas;
            this.ObservedAt = observedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPIReponse" /> class.
        /// </summary>
        public DataAPIReponse()
        {
        }

    }
}