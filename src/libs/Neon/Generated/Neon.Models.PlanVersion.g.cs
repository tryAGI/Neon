
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlanVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Major { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanVersion" /> class.
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlanVersion(
            int major,
            int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanVersion" /> class.
        /// </summary>
        public PlanVersion()
        {
        }
    }
}