
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LimitsUnsatisfiedResponseLimit
    {
        /// <summary>
        /// Identifier of the unsatisfied limit. Possible values are:<br/>
        /// - subscription_type<br/>
        /// - projects_count<br/>
        /// - project_region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Actual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsUnsatisfiedResponseLimit" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifier of the unsatisfied limit. Possible values are:<br/>
        /// - subscription_type<br/>
        /// - projects_count<br/>
        /// - project_region
        /// </param>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LimitsUnsatisfiedResponseLimit(
            string name,
            string expected,
            string actual)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Expected = expected ?? throw new global::System.ArgumentNullException(nameof(expected));
            this.Actual = actual ?? throw new global::System.ArgumentNullException(nameof(actual));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsUnsatisfiedResponseLimit" /> class.
        /// </summary>
        public LimitsUnsatisfiedResponseLimit()
        {
        }
    }
}