
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpdateRequestProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.ProjectSettingsData? Settings { get; set; }

        /// <summary>
        /// The project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A collection of settings for a Neon endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_endpoint_settings")]
        public global::Neon.DefaultEndpointSettings? DefaultEndpointSettings { get; set; }

        /// <summary>
        /// The number of seconds to retain the shared history for all branches in this project.<br/>
        /// The default is 1 day (604800 seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_retention_seconds")]
        public int? HistoryRetentionSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateRequestProject" /> class.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="name">
        /// The project name
        /// </param>
        /// <param name="defaultEndpointSettings">
        /// A collection of settings for a Neon endpoint
        /// </param>
        /// <param name="historyRetentionSeconds">
        /// The number of seconds to retain the shared history for all branches in this project.<br/>
        /// The default is 1 day (604800 seconds).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpdateRequestProject(
            global::Neon.ProjectSettingsData? settings,
            string? name,
            global::Neon.DefaultEndpointSettings? defaultEndpointSettings,
            int? historyRetentionSeconds)
        {
            this.Settings = settings;
            this.Name = name;
            this.DefaultEndpointSettings = defaultEndpointSettings;
            this.HistoryRetentionSeconds = historyRetentionSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateRequestProject" /> class.
        /// </summary>
        public ProjectUpdateRequestProject()
        {
        }
    }
}