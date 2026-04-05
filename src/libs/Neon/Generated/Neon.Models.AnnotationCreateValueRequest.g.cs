
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationCreateValueRequest
    {
        /// <summary>
        /// Annotation properties.<br/>
        /// Example: {"github-commit-ref":"github-branch-name"}
        /// </summary>
        /// <example>{"github-commit-ref":"github-branch-name"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_value")]
        public global::System.Collections.Generic.Dictionary<string, string>? AnnotationValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationCreateValueRequest" /> class.
        /// </summary>
        /// <param name="annotationValue">
        /// Annotation properties.<br/>
        /// Example: {"github-commit-ref":"github-branch-name"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationCreateValueRequest(
            global::System.Collections.Generic.Dictionary<string, string>? annotationValue)
        {
            this.AnnotationValue = annotationValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationCreateValueRequest" /> class.
        /// </summary>
        public AnnotationCreateValueRequest()
        {
        }
    }
}