
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.AnnotationObjectData Object { get; set; }

        /// <summary>
        /// A free-form map of string key-value pairs for attaching metadata to a resource (for example, a git commit reference). Maximum 50 entries.<br/>
        /// Example: {"github-commit-ref":"github-branch-name"}
        /// </summary>
        /// <example>{"github-commit-ref":"github-branch-name"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Value { get; set; }

        /// <summary>
        /// Timestamp when the annotation was created, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of the most recent update to the annotation, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationData" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="value">
        /// A free-form map of string key-value pairs for attaching metadata to a resource (for example, a git commit reference). Maximum 50 entries.<br/>
        /// Example: {"github-commit-ref":"github-branch-name"}
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the annotation was created, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of the most recent update to the annotation, in RFC 3339 format (UTC).<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationData(
            global::Neon.AnnotationObjectData @object,
            global::System.Collections.Generic.Dictionary<string, string> value,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationData" /> class.
        /// </summary>
        public AnnotationData()
        {
        }

    }
}