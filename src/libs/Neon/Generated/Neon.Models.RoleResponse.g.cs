
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoleResponse
    {
        /// <summary>
        /// Example: {"branch_id":"br-wispy-meadow-118737","name":"casey","protected":false,"created_at":"2022-11-23T17:42:25Z","updated_at":"2022-11-23T17:42:25Z"}
        /// </summary>
        /// <example>{"branch_id":"br-wispy-meadow-118737","name":"casey","protected":false,"created_at":"2022-11-23T17:42:25Z","updated_at":"2022-11-23T17:42:25Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        /// <param name="role">
        /// Example: {"branch_id":"br-wispy-meadow-118737","name":"casey","protected":false,"created_at":"2022-11-23T17:42:25Z","updated_at":"2022-11-23T17:42:25Z"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleResponse(
            global::Neon.Role role)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleResponse" /> class.
        /// </summary>
        public RoleResponse()
        {
        }
    }
}