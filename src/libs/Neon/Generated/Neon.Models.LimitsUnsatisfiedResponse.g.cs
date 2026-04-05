
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"limits":[{"name":"projects_count","actual":"2","expected":"1"},{"name":"subscription_type","actual":"launch","expected":"scale"}]}
    /// </summary>
    public sealed partial class LimitsUnsatisfiedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.LimitsUnsatisfiedResponseLimit> Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsUnsatisfiedResponse" /> class.
        /// </summary>
        /// <param name="limits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LimitsUnsatisfiedResponse(
            global::System.Collections.Generic.IList<global::Neon.LimitsUnsatisfiedResponseLimit> limits)
        {
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsUnsatisfiedResponse" /> class.
        /// </summary>
        public LimitsUnsatisfiedResponse()
        {
        }
    }
}