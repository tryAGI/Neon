
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationInvitationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.Invitation> Invitations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitationsResponse" /> class.
        /// </summary>
        /// <param name="invitations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInvitationsResponse(
            global::System.Collections.Generic.IList<global::Neon.Invitation> invitations)
        {
            this.Invitations = invitations ?? throw new global::System.ArgumentNullException(nameof(invitations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitationsResponse" /> class.
        /// </summary>
        public OrganizationInvitationsResponse()
        {
        }
    }
}