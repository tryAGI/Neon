
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Member
    {
        /// <summary>
        /// The organization member's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The Neon user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// The Neon organization ID. Returned as `id` from `GET /users/me/organizations`.<br/>
        /// Example: org-cool-darkness-12345678
        /// </summary>
        /// <example>org-cool-darkness-12345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Organization member's role. `admin`: full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.MemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.MemberRole Role { get; set; }

        /// <summary>
        /// Timestamp when the user joined the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_at")]
        public global::System.DateTime? JoinedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        /// <param name="id">
        /// The organization member's ID.
        /// </param>
        /// <param name="userId">
        /// The Neon user ID.
        /// </param>
        /// <param name="orgId">
        /// The Neon organization ID. Returned as `id` from `GET /users/me/organizations`.<br/>
        /// Example: org-cool-darkness-12345678
        /// </param>
        /// <param name="role">
        /// Organization member's role. `admin`: full administrative access. `editor` (and its legacy alias `member`): standard access governed by project permissions. `viewer` and `collaborator`: additional scoped project roles. Some values may not be available for all organizations.
        /// </param>
        /// <param name="joinedAt">
        /// Timestamp when the user joined the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Member(
            global::System.Guid id,
            global::System.Guid userId,
            string orgId,
            global::Neon.MemberRole role,
            global::System.DateTime? joinedAt)
        {
            this.Id = id;
            this.UserId = userId;
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Role = role;
            this.JoinedAt = joinedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        public Member()
        {
        }

    }
}