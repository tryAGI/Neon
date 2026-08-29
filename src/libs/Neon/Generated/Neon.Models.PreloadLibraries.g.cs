
#nullable enable

namespace Neon
{
    /// <summary>
    /// The shared libraries to preload into the project's compute instances.
    /// </summary>
    public sealed partial class PreloadLibraries
    {
        /// <summary>
        /// When true, the project's preload libraries include the platform default set in addition to any libraries listed in `enabled_libraries`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_defaults")]
        public bool? UseDefaults { get; set; }

        /// <summary>
        /// Names of shared preload libraries to enable for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_libraries")]
        public global::System.Collections.Generic.IList<string>? EnabledLibraries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreloadLibraries" /> class.
        /// </summary>
        /// <param name="useDefaults">
        /// When true, the project's preload libraries include the platform default set in addition to any libraries listed in `enabled_libraries`.
        /// </param>
        /// <param name="enabledLibraries">
        /// Names of shared preload libraries to enable for the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreloadLibraries(
            bool? useDefaults,
            global::System.Collections.Generic.IList<string>? enabledLibraries)
        {
            this.UseDefaults = useDefaults;
            this.EnabledLibraries = enabledLibraries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreloadLibraries" /> class.
        /// </summary>
        public PreloadLibraries()
        {
        }

    }
}