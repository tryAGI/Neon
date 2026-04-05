
#nullable enable

namespace Neon
{
    /// <summary>
    /// An action that is currently restricted for the branch and the reason why.
    /// </summary>
    public sealed partial class BranchRestrictedAction
    {
        /// <summary>
        /// The name of a restricted action. Possible values include `restore`, `delete-rw-endpoint`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A human-readable explanation of why the action is restricted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictedAction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of a restricted action. Possible values include `restore`, `delete-rw-endpoint`.
        /// </param>
        /// <param name="reason">
        /// A human-readable explanation of why the action is restricted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchRestrictedAction(
            string name,
            string reason)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictedAction" /> class.
        /// </summary>
        public BranchRestrictedAction()
        {
        }
    }
}