
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScheduleTriggerCreateRequest
    {
        /// <summary>
        /// Trigger type discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ScheduleTriggerCreateRequestTypeJsonConverter))]
        public global::Neon.ScheduleTriggerCreateRequestType Type { get; set; }

        /// <summary>
        /// The branch-local Function slug to invoke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionSlug { get; set; }

        /// <summary>
        /// Human-readable name, unique among triggers visible on the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Path passed to the target Function. Defaults to `/`.<br/>
        /// Default Value: /
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_path")]
        public string? FunctionPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.FunctionTriggerSchedule Schedule { get; set; }

        /// <summary>
        /// Whether future occurrences should be scheduled.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTriggerCreateRequest" /> class.
        /// </summary>
        /// <param name="functionSlug">
        /// The branch-local Function slug to invoke.
        /// </param>
        /// <param name="name">
        /// Human-readable name, unique among triggers visible on the branch.
        /// </param>
        /// <param name="schedule"></param>
        /// <param name="type">
        /// Trigger type discriminator.
        /// </param>
        /// <param name="functionPath">
        /// Path passed to the target Function. Defaults to `/`.<br/>
        /// Default Value: /
        /// </param>
        /// <param name="enabled">
        /// Whether future occurrences should be scheduled.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleTriggerCreateRequest(
            string functionSlug,
            string name,
            global::Neon.FunctionTriggerSchedule schedule,
            global::Neon.ScheduleTriggerCreateRequestType type,
            string? functionPath,
            bool? enabled)
        {
            this.Type = type;
            this.FunctionSlug = functionSlug ?? throw new global::System.ArgumentNullException(nameof(functionSlug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionPath = functionPath;
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTriggerCreateRequest" /> class.
        /// </summary>
        public ScheduleTriggerCreateRequest()
        {
        }

    }
}