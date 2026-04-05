
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoleCreateRequestRole
    {
        /// <summary>
        /// The role name. Cannot exceed 63 bytes in length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether to create a role that cannot login.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_login")]
        public bool? NoLogin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreateRequestRole" /> class.
        /// </summary>
        /// <param name="name">
        /// The role name. Cannot exceed 63 bytes in length.
        /// </param>
        /// <param name="noLogin">
        /// Whether to create a role that cannot login.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleCreateRequestRole(
            string name,
            bool? noLogin)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NoLogin = noLogin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreateRequestRole" /> class.
        /// </summary>
        public RoleCreateRequestRole()
        {
        }
    }
}