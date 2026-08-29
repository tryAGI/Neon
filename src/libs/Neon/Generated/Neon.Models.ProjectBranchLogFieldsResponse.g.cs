
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogFieldsResponse
    {
        /// <summary>
        /// Log field names observed on this branch, each usable as `field_name`<br/>
        /// on the log field-values endpoint. Computed per branch rather than<br/>
        /// fixed by this specification, so clients should not assume a<br/>
        /// particular set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogFieldsResponse" /> class.
        /// </summary>
        /// <param name="fields">
        /// Log field names observed on this branch, each usable as `field_name`<br/>
        /// on the log field-values endpoint. Computed per branch rather than<br/>
        /// fixed by this specification, so clients should not assume a<br/>
        /// particular set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogFieldsResponse(
            global::System.Collections.Generic.IList<string> fields)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogFieldsResponse" /> class.
        /// </summary>
        public ProjectBranchLogFieldsResponse()
        {
        }

    }
}