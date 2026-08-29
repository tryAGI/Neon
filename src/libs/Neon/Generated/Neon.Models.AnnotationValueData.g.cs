
#nullable enable

namespace Neon
{
    /// <summary>
    /// A free-form map of string key-value pairs for attaching metadata to a resource (for example, a git commit reference). Maximum 50 entries.<br/>
    /// Example: {"github-commit-ref":"github-branch-name"}
    /// </summary>
    public sealed partial class AnnotationValueData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}