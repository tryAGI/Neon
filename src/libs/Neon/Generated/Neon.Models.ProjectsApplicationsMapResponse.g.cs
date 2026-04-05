
#nullable enable

namespace Neon
{
    /// <summary>
    /// A map where key is a project ID and a value is a list of installed applications.<br/>
    /// Example: {"applications":{"winter-boat-259881":["vercel","github","datadog","opentelemetry"]}}
    /// </summary>
    public sealed partial class ProjectsApplicationsMapResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Neon.ApplicationType>> Applications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsApplicationsMapResponse" /> class.
        /// </summary>
        /// <param name="applications"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsApplicationsMapResponse(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Neon.ApplicationType>> applications)
        {
            this.Applications = applications ?? throw new global::System.ArgumentNullException(nameof(applications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsApplicationsMapResponse" /> class.
        /// </summary>
        public ProjectsApplicationsMapResponse()
        {
        }
    }
}