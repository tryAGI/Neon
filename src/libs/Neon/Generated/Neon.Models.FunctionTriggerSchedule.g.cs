
#nullable enable

namespace Neon
{
    /// <summary>
    /// A numeric five-field cron schedule interpreted in UTC.
    /// </summary>
    public sealed partial class FunctionTriggerSchedule
    {
        /// <summary>
        /// Numeric five-field cron expression (minute through day-of-week), interpreted in UTC.<br/>
        /// Example: 0 9 * * 1-5
        /// </summary>
        /// <example>0 9 * * 1-5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cron { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTriggerSchedule" /> class.
        /// </summary>
        /// <param name="cron">
        /// Numeric five-field cron expression (minute through day-of-week), interpreted in UTC.<br/>
        /// Example: 0 9 * * 1-5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionTriggerSchedule(
            string cron)
        {
            this.Cron = cron ?? throw new global::System.ArgumentNullException(nameof(cron));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTriggerSchedule" /> class.
        /// </summary>
        public FunctionTriggerSchedule()
        {
        }

    }
}