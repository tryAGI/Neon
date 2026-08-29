
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetProjectMemberRoleRequest
    {
        /// <summary>
        /// Per-project role. `viewer` maps to `VIEWER`, `editor` maps to `EDITOR`,<br/>
        /// and `admin` maps to `ADMIN`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ProjectRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetProjectMemberRoleRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// Per-project role. `viewer` maps to `VIEWER`, `editor` maps to `EDITOR`,<br/>
        /// and `admin` maps to `ADMIN`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetProjectMemberRoleRequest(
            global::Neon.ProjectRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetProjectMemberRoleRequest" /> class.
        /// </summary>
        public SetProjectMemberRoleRequest()
        {
        }

    }
}