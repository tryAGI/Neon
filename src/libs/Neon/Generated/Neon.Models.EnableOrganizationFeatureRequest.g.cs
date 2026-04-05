
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnableOrganizationFeatureRequest
    {
        /// <summary>
        /// The feature to enable for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EnableOrganizationFeatureRequestFeatureJsonConverter))]
        public global::Neon.EnableOrganizationFeatureRequestFeature Feature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableOrganizationFeatureRequest" /> class.
        /// </summary>
        /// <param name="feature">
        /// The feature to enable for the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnableOrganizationFeatureRequest(
            global::Neon.EnableOrganizationFeatureRequestFeature feature)
        {
            this.Feature = feature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableOrganizationFeatureRequest" /> class.
        /// </summary>
        public EnableOrganizationFeatureRequest()
        {
        }
    }
}