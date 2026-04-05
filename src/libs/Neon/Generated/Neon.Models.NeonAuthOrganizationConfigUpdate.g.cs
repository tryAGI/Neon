
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthOrganizationConfigUpdate
    {
        /// <summary>
        /// Whether the organization plugin is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum number of organizations a user can create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_limit")]
        public int? OrganizationLimit { get; set; }

        /// <summary>
        /// Maximum number of members per organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership_limit")]
        public int? MembershipLimit { get; set; }

        /// <summary>
        /// The role assigned to the user who creates an organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter))]
        public global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole? CreatorRole { get; set; }

        /// <summary>
        /// Whether to send invitation emails when inviting members to an organization
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
        /// Whether the organization plugin is enabled
        /// </param>
        /// <param name="organizationLimit">
        /// Maximum number of organizations a user can create
        /// </param>
        /// <param name="membershipLimit">
        /// Maximum number of members per organization
        /// </param>
        /// <param name="creatorRole">
        /// The role assigned to the user who creates an organization
        /// </param>
        /// <param name="sendInvitationEmail">
        /// Whether to send invitation emails when inviting members to an organization
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