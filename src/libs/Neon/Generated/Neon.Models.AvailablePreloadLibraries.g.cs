
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AvailablePreloadLibraries
    {
        /// <summary>
        /// Preload libraries available for the project's Postgres version. Each entry includes `library_name`, `description`, `is_default`, `is_experimental`, and `version`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("libraries")]
        public global::System.Collections.Generic.IList<global::Neon.AvailablePreloadLibrary>? Libraries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePreloadLibraries" /> class.
        /// </summary>
        /// <param name="libraries">
        /// Preload libraries available for the project's Postgres version. Each entry includes `library_name`, `description`, `is_default`, `is_experimental`, and `version`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailablePreloadLibraries(
            global::System.Collections.Generic.IList<global::Neon.AvailablePreloadLibrary>? libraries)
        {
            this.Libraries = libraries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePreloadLibraries" /> class.
        /// </summary>
        public AvailablePreloadLibraries()
        {
        }

    }
}