
#nullable enable

namespace Neon
{
    /// <summary>
    /// Update Neon Data API
    /// </summary>
    public sealed partial class DataAPIUpdateRequest
    {
        /// <summary>
        /// Configuration settings for the Neon Data API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.DataAPISettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPIUpdateRequest" /> class.
        /// </summary>
        /// <param name="settings">
        /// Configuration settings for the Neon Data API
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAPIUpdateRequest(
            global::Neon.DataAPISettings? settings)
        {
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPIUpdateRequest" /> class.
        /// </summary>
        public DataAPIUpdateRequest()
        {
        }
    }
}