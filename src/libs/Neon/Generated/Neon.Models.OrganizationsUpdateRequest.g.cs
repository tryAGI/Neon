
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationsUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, all members must have MFA enabled to access this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_mfa")]
        public bool? RequireMfa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requireMfa">
        /// If true, all members must have MFA enabled to access this organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationsUpdateRequest(
            string? name,
            bool? requireMfa)
        {
            this.Name = name;
            this.RequireMfa = requireMfa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsUpdateRequest" /> class.
        /// </summary>
        public OrganizationsUpdateRequest()
        {
        }

    }
}