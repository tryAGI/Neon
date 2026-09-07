
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TriggersListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.Trigger> Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersListResponse" /> class.
        /// </summary>
        /// <param name="triggers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggersListResponse(
            global::System.Collections.Generic.IList<global::Neon.Trigger> triggers)
        {
            this.Triggers = triggers ?? throw new global::System.ArgumentNullException(nameof(triggers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersListResponse" /> class.
        /// </summary>
        public TriggersListResponse()
        {
        }

    }
}