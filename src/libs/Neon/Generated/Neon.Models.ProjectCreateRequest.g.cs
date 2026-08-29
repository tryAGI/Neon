
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectCreateRequest
    {
        /// <summary>
        /// Configuration for the new project, including name, region, and Postgres compute and storage settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ProjectCreateRequestProject Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequest" /> class.
        /// </summary>
        /// <param name="project">
        /// Configuration for the new project, including name, region, and Postgres compute and storage settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCreateRequest(
            global::Neon.ProjectCreateRequestProject project)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequest" /> class.
        /// </summary>
        public ProjectCreateRequest()
        {
        }

    }
}