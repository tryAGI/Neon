
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomDomainsListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.CustomDomain> CustomDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomainsListResponse" /> class.
        /// </summary>
        /// <param name="customDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomDomainsListResponse(
            global::System.Collections.Generic.IList<global::Neon.CustomDomain> customDomains)
        {
            this.CustomDomains = customDomains ?? throw new global::System.ArgumentNullException(nameof(customDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDomainsListResponse" /> class.
        /// </summary>
        public CustomDomainsListResponse()
        {
        }

    }
}