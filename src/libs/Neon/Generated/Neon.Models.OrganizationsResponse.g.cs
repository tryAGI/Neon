
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.Organization> Organizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsResponse" /> class.
        /// </summary>
        /// <param name="organizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationsResponse(
            global::System.Collections.Generic.IList<global::Neon.Organization> organizations)
        {
            this.Organizations = organizations ?? throw new global::System.ArgumentNullException(nameof(organizations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsResponse" /> class.
        /// </summary>
        public OrganizationsResponse()
        {
        }
    }
}