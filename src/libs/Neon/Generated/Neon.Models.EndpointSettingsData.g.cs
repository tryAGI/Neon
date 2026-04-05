
#nullable enable

namespace Neon
{
    /// <summary>
    /// A collection of settings for a compute endpoint
    /// </summary>
    public sealed partial class EndpointSettingsData
    {
        /// <summary>
        /// A raw representation of Postgres settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pg_settings")]
        public global::System.Collections.Generic.Dictionary<string, string>? PgSettings { get; set; }

        /// <summary>
        /// A raw representation of PgBouncer settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pgbouncer_settings")]
        public global::System.Collections.Generic.Dictionary<string, string>? PgbouncerSettings { get; set; }

        /// <summary>
        /// The shared libraries to preload into the project's compute instances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preload_libraries")]
        public global::Neon.PreloadLibraries? PreloadLibraries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointSettingsData" /> class.
        /// </summary>
        /// <param name="pgSettings">
        /// A raw representation of Postgres settings
        /// </param>
        /// <param name="pgbouncerSettings">
        /// A raw representation of PgBouncer settings
        /// </param>
        /// <param name="preloadLibraries">
        /// The shared libraries to preload into the project's compute instances.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointSettingsData(
            global::System.Collections.Generic.Dictionary<string, string>? pgSettings,
            global::System.Collections.Generic.Dictionary<string, string>? pgbouncerSettings,
            global::Neon.PreloadLibraries? preloadLibraries)
        {
            this.PgSettings = pgSettings;
            this.PgbouncerSettings = pgbouncerSettings;
            this.PreloadLibraries = preloadLibraries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointSettingsData" /> class.
        /// </summary>
        public EndpointSettingsData()
        {
        }
    }
}