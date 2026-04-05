
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.AnnotationData Annotation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationResponse" /> class.
        /// </summary>
        /// <param name="annotation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationResponse(
            global::Neon.AnnotationData annotation)
        {
            this.Annotation = annotation ?? throw new global::System.ArgumentNullException(nameof(annotation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationResponse" /> class.
        /// </summary>
        public AnnotationResponse()
        {
        }
    }
}