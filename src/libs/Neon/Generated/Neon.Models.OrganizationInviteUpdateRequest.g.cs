
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationInviteUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The role of the organization member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.MemberRoleJsonConverter))]
        public global::Neon.MemberRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resend")]
        public bool? Resend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInviteUpdateRequest" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="role">
        /// The role of the organization member
        /// </param>
        /// <param name="resend"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInviteUpdateRequest(
            string? email,
            global::Neon.MemberRole? role,
            bool? resend)
        {
            this.Email = email;
            this.Role = role;
            this.Resend = resend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInviteUpdateRequest" /> class.
        /// </summary>
        public OrganizationInviteUpdateRequest()
        {
        }
    }
}