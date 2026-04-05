
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"branch_id":"br-wispy-meadow-118737","name":"casey","protected":false,"created_at":"2022-11-23T17:42:25Z","updated_at":"2022-11-23T17:42:25Z"}
    /// </summary>
    public sealed partial class Role
    {
        /// <summary>
        /// The ID of the branch to which the role belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// The role name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The role password
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Whether or not the role is system-protected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        public bool? Protected { get; set; }

        /// <summary>
        /// Authentication method configured for this role. Valid options: `password`, `oauth`, `no_login`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication_method")]
        public string? AuthenticationMethod { get; set; }

        /// <summary>
        /// A timestamp indicating when the role was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the role was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="branchId">
        /// The ID of the branch to which the role belongs
        /// </param>
        /// <param name="name">
        /// The role name
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the role was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the role was last updated
        /// </param>
        /// <param name="password">
        /// The role password
        /// </param>
        /// <param name="protected">
        /// Whether or not the role is system-protected
        /// </param>
        /// <param name="authenticationMethod">
        /// Authentication method configured for this role. Valid options: `password`, `oauth`, `no_login`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Role(
            string branchId,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? password,
            bool? @protected,
            string? authenticationMethod)
        {
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Password = password;
            this.Protected = @protected;
            this.AuthenticationMethod = authenticationMethod;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        public Role()
        {
        }
    }
}