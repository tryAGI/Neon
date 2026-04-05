
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Invitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Email of the invited user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Organization id as it is stored in Neon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// UUID for the user_id who extended the invitation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InvitedBy { get; set; }

        /// <summary>
        /// Timestamp when the invitation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime InvitedAt { get; set; }

        /// <summary>
        /// The role of the organization member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.MemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.MemberRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invitation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email">
        /// Email of the invited user
        /// </param>
        /// <param name="orgId">
        /// Organization id as it is stored in Neon
        /// </param>
        /// <param name="invitedBy">
        /// UUID for the user_id who extended the invitation
        /// </param>
        /// <param name="invitedAt">
        /// Timestamp when the invitation was created
        /// </param>
        /// <param name="role">
        /// The role of the organization member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invitation(
            global::System.Guid id,
            string email,
            string orgId,
            global::System.Guid invitedBy,
            global::System.DateTime invitedAt,
            global::Neon.MemberRole role)
        {
            this.Id = id;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.InvitedBy = invitedBy;
            this.InvitedAt = invitedAt;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invitation" /> class.
        /// </summary>
        public Invitation()
        {
        }
    }
}