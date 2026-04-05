
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateNeonAuthUserRoleRequest
    {
        /// <summary>
        /// Array of roles to assign to the user<br/>
        /// Example: [admin]
        /// </summary>
        /// <example>[admin]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNeonAuthUserRoleRequest" /> class.
        /// </summary>
        /// <param name="roles">
        /// Array of roles to assign to the user<br/>
        /// Example: [admin]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateNeonAuthUserRoleRequest(
            global::System.Collections.Generic.IList<string> roles)
        {
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNeonAuthUserRoleRequest" /> class.
        /// </summary>
        public UpdateNeonAuthUserRoleRequest()
        {
        }
    }
}