
#nullable enable

namespace Neon
{
    /// <summary>
    /// Map of project IDs to their installed applications. Each key is a project ID; each value is an array of application types (for example, `vercel`, `github`).
    /// </summary>
    public sealed partial class ProjectsApplicationsMapResponseApplications
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}