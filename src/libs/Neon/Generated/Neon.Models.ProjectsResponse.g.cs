
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.ProjectListItem> Projects { get; set; }

        /// <summary>
        /// A list of project IDs indicating which projects are known to exist, but whose details could not<br/>
        /// be fetched within the requested (or implicit) time limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailable_project_ids")]
        public global::System.Collections.Generic.IList<string>? UnavailableProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsResponse" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="unavailableProjectIds">
        /// A list of project IDs indicating which projects are known to exist, but whose details could not<br/>
        /// be fetched within the requested (or implicit) time limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsResponse(
            global::System.Collections.Generic.IList<global::Neon.ProjectListItem> projects,
            global::System.Collections.Generic.IList<string>? unavailableProjectIds)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.UnavailableProjectIds = unavailableProjectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsResponse" /> class.
        /// </summary>
        public ProjectsResponse()
        {
        }
    }
}