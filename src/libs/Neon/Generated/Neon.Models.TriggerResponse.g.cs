
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TriggerResponse
    {
        /// <summary>
        /// A branch-effective trigger discriminated by `type`. The supported trigger<br/>
        /// types are `schedule` and `storage_object_created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.TriggerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Trigger Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerResponse" /> class.
        /// </summary>
        /// <param name="trigger">
        /// A branch-effective trigger discriminated by `type`. The supported trigger<br/>
        /// types are `schedule` and `storage_object_created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerResponse(
            global::Neon.Trigger trigger)
        {
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerResponse" /> class.
        /// </summary>
        public TriggerResponse()
        {
        }

    }
}