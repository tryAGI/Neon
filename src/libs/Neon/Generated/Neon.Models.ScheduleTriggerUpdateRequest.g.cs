
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScheduleTriggerUpdateRequest
    {
        /// <summary>
        /// Trigger type discriminator; it does not change the trigger type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ScheduleTriggerUpdateRequestTypeJsonConverter))]
        public global::Neon.ScheduleTriggerUpdateRequestType Type { get; set; }

        /// <summary>
        /// Replacement branch-local Function slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_slug")]
        public string? FunctionSlug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_path")]
        public string? FunctionPath { get; set; }

        /// <summary>
        /// A numeric five-field cron schedule interpreted in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::Neon.FunctionTriggerSchedule? Schedule { get; set; }

        /// <summary>
        /// True enables and false disables future scheduling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTriggerUpdateRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Trigger type discriminator; it does not change the trigger type.
        /// </param>
        /// <param name="functionSlug">
        /// Replacement branch-local Function slug.
        /// </param>
        /// <param name="name"></param>
        /// <param name="functionPath"></param>
        /// <param name="schedule">
        /// A numeric five-field cron schedule interpreted in UTC.
        /// </param>
        /// <param name="enabled">
        /// True enables and false disables future scheduling.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleTriggerUpdateRequest(
            global::Neon.ScheduleTriggerUpdateRequestType type,
            string? functionSlug,
            string? name,
            string? functionPath,
            global::Neon.FunctionTriggerSchedule? schedule,
            bool? enabled)
        {
            this.Type = type;
            this.FunctionSlug = functionSlug;
            this.Name = name;
            this.FunctionPath = functionPath;
            this.Schedule = schedule;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTriggerUpdateRequest" /> class.
        /// </summary>
        public ScheduleTriggerUpdateRequest()
        {
        }

    }
}