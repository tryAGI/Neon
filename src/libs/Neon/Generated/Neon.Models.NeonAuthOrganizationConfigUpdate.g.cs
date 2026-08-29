
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOrganizationConfigUpdate
    {
        /// <summary>
        /// Controls whether the organization plugin is active for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum organizations a user can belong to (created or joined). At the limit, the user cannot create or join more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_limit")]
        public int? OrganizationLimit { get; set; }

        /// <summary>
        /// Maximum members per organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership_limit")]
        public int? MembershipLimit { get; set; }

        /// <summary>
        /// Role of the organization's creator. `owner`: full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter))]
        public global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole? CreatorRole { get; set; }

        /// <summary>
        /// When true, invited users receive an email containing an accept link. Requires that the invited user has a verified email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_invitation_email")]
        public bool? SendInvitationEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOrganizationConfigUpdate" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Controls whether the organization plugin is active for the organization.
        /// </param>
        /// <param name="organizationLimit">
        /// Maximum organizations a user can belong to (created or joined). At the limit, the user cannot create or join more.
        /// </param>
        /// <param name="membershipLimit">
        /// Maximum members per organization.
        /// </param>
        /// <param name="creatorRole">
        /// Role of the organization's creator. `owner`: full control, including deleting the org and transferring ownership. `admin`: manage members and settings only.
        /// </param>
        /// <param name="sendInvitationEmail">
        /// When true, invited users receive an email containing an accept link. Requires that the invited user has a verified email address.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOrganizationConfigUpdate(
            bool? enabled,
            int? organizationLimit,
            int? membershipLimit,
            global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole? creatorRole,
            bool? sendInvitationEmail)
        {
            this.Enabled = enabled;
            this.OrganizationLimit = organizationLimit;
            this.MembershipLimit = membershipLimit;
            this.CreatorRole = creatorRole;
            this.SendInvitationEmail = sendInvitationEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOrganizationConfigUpdate" /> class.
        /// </summary>
        public NeonAuthOrganizationConfigUpdate()
        {
        }

    }
}