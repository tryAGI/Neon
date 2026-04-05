
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackupSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.BackupScheduleItem> Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupSchedule" /> class.
        /// </summary>
        /// <param name="schedule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupSchedule(
            global::System.Collections.Generic.IList<global::Neon.BackupScheduleItem> schedule)
        {
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupSchedule" /> class.
        /// </summary>
        public BackupSchedule()
        {
        }
    }
}