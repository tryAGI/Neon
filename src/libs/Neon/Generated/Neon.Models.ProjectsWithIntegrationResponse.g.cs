
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"projects":[{"id":"round-frog-53611540","integration":"github"},{"id":"long-leaf-72329067","integration":"vercel"}]}
    /// </summary>
    public sealed partial class ProjectsWithIntegrationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.ProjectsWithIntegrationResponseProject> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsWithIntegrationResponse" /> class.
        /// </summary>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsWithIntegrationResponse(
            global::System.Collections.Generic.IList<global::Neon.ProjectsWithIntegrationResponseProject> projects)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsWithIntegrationResponse" /> class.
        /// </summary>
        public ProjectsWithIntegrationResponse()
        {
        }
    }
}