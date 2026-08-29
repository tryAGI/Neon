
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AvailablePreloadLibrary
    {
        /// <summary>
        /// Name of the Postgres shared preload library as it appears in the `shared_preload_libraries` parameter (for example, `pg_stat_statements`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LibraryName { get; set; }

        /// <summary>
        /// Human-readable explanation of the library's purpose and behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether this library is loaded by default in the `shared_preload_libraries` configuration for new compute endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Marks the library as experimental. Experimental libraries may be unstable, subject to breaking changes, or not recommended for production use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_experimental")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsExperimental { get; set; }

        /// <summary>
        /// Version of the preload library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePreloadLibrary" /> class.
        /// </summary>
        /// <param name="libraryName">
        /// Name of the Postgres shared preload library as it appears in the `shared_preload_libraries` parameter (for example, `pg_stat_statements`).
        /// </param>
        /// <param name="description">
        /// Human-readable explanation of the library's purpose and behavior.
        /// </param>
        /// <param name="isDefault">
        /// Whether this library is loaded by default in the `shared_preload_libraries` configuration for new compute endpoints.
        /// </param>
        /// <param name="isExperimental">
        /// Marks the library as experimental. Experimental libraries may be unstable, subject to breaking changes, or not recommended for production use.
        /// </param>
        /// <param name="version">
        /// Version of the preload library.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailablePreloadLibrary(
            string libraryName,
            string description,
            bool isDefault,
            bool isExperimental,
            string version)
        {
            this.LibraryName = libraryName ?? throw new global::System.ArgumentNullException(nameof(libraryName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsDefault = isDefault;
            this.IsExperimental = isExperimental;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePreloadLibrary" /> class.
        /// </summary>
        public AvailablePreloadLibrary()
        {
        }

    }
}