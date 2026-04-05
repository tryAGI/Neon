
#nullable enable

namespace Neon
{
    /// <summary>
    /// A map where key is a project ID and a value is a list of installed integrations.<br/>
    /// Example: {"integrations":{"winter-boat-259881":["vercel","github","datadog","opentelemetry"]}}
    /// </summary>
    public sealed partial class ProjectsIntegrationsMapResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Neon.ApplicationType>> Integrations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsIntegrationsMapResponse" /> class.
        /// </summary>
        /// <param name="integrations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsIntegrationsMapResponse(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Neon.ApplicationType>> integrations)
        {
            this.Integrations = integrations ?? throw new global::System.ArgumentNullException(nameof(integrations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsIntegrationsMapResponse" /> class.
        /// </summary>
        public ProjectsIntegrationsMapResponse()
        {
        }
    }
}