
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonFunctionUpdateRequest
    {
        /// <summary>
        /// New display name for the function. `null` clears the display<br/>
        /// name; the function's `name` then falls back to its slug. Leading<br/>
        /// and trailing whitespace is trimmed; a whitespace-only name is<br/>
        /// rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunctionUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New display name for the function. `null` clears the display<br/>
        /// name; the function's `name` then falls back to its slug. Leading<br/>
        /// and trailing whitespace is trimmed; a whitespace-only name is<br/>
        /// rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonFunctionUpdateRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunctionUpdateRequest" /> class.
        /// </summary>
        public NeonFunctionUpdateRequest()
        {
        }

    }
}