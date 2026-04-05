
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthOrganizationConfig
    {
        /// <summary>
        /// Whether the organization plugin is enabled<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Maximum number of organizations a user can create<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OrganizationLimit { get; set; }

        /// <summary>
        /// Maximum number of members per organization<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MembershipLimit { get; set; }

        /// <summary>
        /// The role assigned to the user who creates an organization<br/>
        /// Default Value: owner
        /// </summary>
        /// <default>global::Neon.NeonAuthOrganizationConfigCreatorRole.Owner</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthOrganizationConfigCreatorRole CreatorRole { get; set; } = global::Neon.NeonAuthOrganizationConfigCreatorRole.Owner;

        /// <summary>
        /// Whether to send invitation emails when inviting members to an organization<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_invitation_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SendInvitationEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOrganizationConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the organization plugin is enabled<br/>
        /// Default Value: true
        /// </param>
        /// <param name="organizationLimit">
        /// Maximum number of organizations a user can create<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="membershipLimit">
        /// Maximum number of members per organization<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="creatorRole">
        /// The role assigned to the user who creates an organization<br/>
        /// Default Value: owner
        /// </param>
        /// <param name="sendInvitationEmail">
        /// Whether to send invitation emails when inviting members to an organization<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOrganizationConfig(
            bool enabled,
            int organizationLimit,
            int membershipLimit,
            global::Neon.NeonAuthOrganizationConfigCreatorRole creatorRole,
            bool sendInvitationEmail)
        {
            this.Enabled = enabled;
            this.OrganizationLimit = organizationLimit;
            this.MembershipLimit = membershipLimit;
            this.CreatorRole = creatorRole;
            this.SendInvitationEmail = sendInvitationEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOrganizationConfig" /> class.
        /// </summary>
        public NeonAuthOrganizationConfig()
        {
        }
    }
}