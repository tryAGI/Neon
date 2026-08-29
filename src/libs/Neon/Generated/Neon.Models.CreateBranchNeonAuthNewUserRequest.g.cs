
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBranchNeonAuthNewUserRequest
    {
        /// <summary>
        /// Email address of the new Neon Auth user to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Display name for the new user. Optional. Pair with the required email field when creating a new user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBranchNeonAuthNewUserRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Email address of the new Neon Auth user to create.
        /// </param>
        /// <param name="name">
        /// Display name for the new user. Optional. Pair with the required email field when creating a new user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBranchNeonAuthNewUserRequest(
            string email,
            string? name)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBranchNeonAuthNewUserRequest" /> class.
        /// </summary>
        public CreateBranchNeonAuthNewUserRequest()
        {
        }

    }
}