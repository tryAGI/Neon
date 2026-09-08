
#nullable enable

namespace Neon
{
    /// <summary>
    /// A branch-effective schedule trigger for a Function.
    /// </summary>
    public sealed partial class ScheduleTrigger
    {
        /// <summary>
        /// Trigger type discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ScheduleTriggerTypeJsonConverter))]
        public global::Neon.ScheduleTriggerType Type { get; set; }

        /// <summary>
        /// Opaque, server-minted project-wide trigger identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// The branch-local Function slug resolved when an occurrence is consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionSlug { get; set; }

        /// <summary>
        /// Human-readable trigger name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Path passed to the target Function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionPath { get; set; }

        /// <summary>
        /// A numeric five-field cron schedule interpreted in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.FunctionTriggerSchedule Schedule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Monotonic configuration version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Version { get; set; }

        /// <summary>
        /// Next scheduled occurrence as an RFC 3339 UTC timestamp, or null<br/>
        /// while disabled or inherited and not explicitly enabled on this branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_run_at")]
        public string? NextRunAt { get; set; }

        /// <summary>
        /// The public `branch_id` of the branch that authored the effective configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceBranchId { get; set; }

        /// <summary>
        /// True when the effective configuration was authored on an ancestor branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Inherited { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTrigger" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// Opaque, server-minted project-wide trigger identifier.
        /// </param>
        /// <param name="functionSlug">
        /// The branch-local Function slug resolved when an occurrence is consumed.
        /// </param>
        /// <param name="name">
        /// Human-readable trigger name.
        /// </param>
        /// <param name="functionPath">
        /// Path passed to the target Function.
        /// </param>
        /// <param name="schedule">
        /// A numeric five-field cron schedule interpreted in UTC.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="version">
        /// Monotonic configuration version.
        /// </param>
        /// <param name="sourceBranchId">
        /// The public `branch_id` of the branch that authored the effective configuration.
        /// </param>
        /// <param name="inherited">
        /// True when the effective configuration was authored on an ancestor branch.
        /// </param>
        /// <param name="type">
        /// Trigger type discriminator.
        /// </param>
        /// <param name="nextRunAt">
        /// Next scheduled occurrence as an RFC 3339 UTC timestamp, or null<br/>
        /// while disabled or inherited and not explicitly enabled on this branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleTrigger(
            string triggerId,
            string functionSlug,
            string name,
            string functionPath,
            global::Neon.FunctionTriggerSchedule schedule,
            bool enabled,
            long version,
            string sourceBranchId,
            bool inherited,
            global::Neon.ScheduleTriggerType type,
            string? nextRunAt)
        {
            this.Type = type;
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
            this.FunctionSlug = functionSlug ?? throw new global::System.ArgumentNullException(nameof(functionSlug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionPath = functionPath ?? throw new global::System.ArgumentNullException(nameof(functionPath));
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Enabled = enabled;
            this.Version = version;
            this.NextRunAt = nextRunAt;
            this.SourceBranchId = sourceBranchId ?? throw new global::System.ArgumentNullException(nameof(sourceBranchId));
            this.Inherited = inherited;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTrigger" /> class.
        /// </summary>
        public ScheduleTrigger()
        {
        }

    }
}