
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonFunctionsListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.NeonFunction> Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunctionsListResponse" /> class.
        /// </summary>
        /// <param name="functions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonFunctionsListResponse(
            global::System.Collections.Generic.IList<global::Neon.NeonFunction> functions)
        {
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunctionsListResponse" /> class.
        /// </summary>
        public NeonFunctionsListResponse()
        {
        }

    }
}