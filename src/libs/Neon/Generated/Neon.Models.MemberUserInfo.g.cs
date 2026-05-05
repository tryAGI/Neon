
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemberUserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Whether the member has MFA (TOTP) enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_mfa")]
        public bool? HasMfa { get; set; }

        /// <summary>
        /// Timestamp of when the user account was deactivated.<br/>
        /// Absent for active users. When present, the UI should render a<br/>
        /// "Deactivated" badge inline next to the member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivated_at")]
        public global::System.DateTime? DeactivatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberUserInfo" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="hasMfa">
        /// Whether the member has MFA (TOTP) enabled
        /// </param>
        /// <param name="deactivatedAt">
        /// Timestamp of when the user account was deactivated.<br/>
        /// Absent for active users. When present, the UI should render a<br/>
        /// "Deactivated" badge inline next to the member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemberUserInfo(
            string email,
            bool? hasMfa,
            global::System.DateTime? deactivatedAt)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.HasMfa = hasMfa;
            this.DeactivatedAt = deactivatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberUserInfo" /> class.
        /// </summary>
        public MemberUserInfo()
        {
        }
    }
}