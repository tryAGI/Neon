
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationCreateRequestOrganization
    {
        /// <summary>
        /// The organization name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Emails with roles to invite to the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitations")]
        public global::System.Collections.Generic.IList<global::Neon.InvitationCreateRequest>? Invitations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateRequestOrganization" /> class.
        /// </summary>
        /// <param name="name">
        /// The organization name
        /// </param>
        /// <param name="invitations">
        /// Emails with roles to invite to the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCreateRequestOrganization(
            string? name,
            global::System.Collections.Generic.IList<global::Neon.InvitationCreateRequest>? invitations)
        {
            this.Name = name;
            this.Invitations = invitations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateRequestOrganization" /> class.
        /// </summary>
        public OrganizationCreateRequestOrganization()
        {
        }
    }
}