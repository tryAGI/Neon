
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsWithIntegrationResponseProject
    {
        /// <summary>
        /// The Neon project ID. Use as the `project_id` path parameter in other endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the external integration associated with the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsWithIntegrationResponseProject" /> class.
        /// </summary>
        /// <param name="id">
        /// The Neon project ID. Use as the `project_id` path parameter in other endpoints.
        /// </param>
        /// <param name="integration">
        /// Name of the external integration associated with the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsWithIntegrationResponseProject(
            string id,
            string integration)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsWithIntegrationResponseProject" /> class.
        /// </summary>
        public ProjectsWithIntegrationResponseProject()
        {
        }

    }
}