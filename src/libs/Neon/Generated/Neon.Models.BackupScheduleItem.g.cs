
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackupScheduleItem
    {
        /// <summary>
        /// How often to take snapshots. Must be one of the following values:<br/>
        ///   - `hourly`<br/>
        ///   - `daily`<br/>
        ///   - `weekly`<br/>
        ///   - `monthly`<br/>
        ///   - `yearly`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Frequency { get; set; }

        /// <summary>
        /// The hour of the day to take the snapshot (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// The day of the week or month to take the snapshot (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        public int? Day { get; set; }

        /// <summary>
        /// The month of the year to take the snapshot (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month")]
        public int? Month { get; set; }

        /// <summary>
        /// How long to keep a snapshot (in seconds) before it's automatically deleted.<br/>
        /// If not set, the snapshot is kept indefinitely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_seconds")]
        public int? RetentionSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleItem" /> class.
        /// </summary>
        /// <param name="frequency">
        /// How often to take snapshots. Must be one of the following values:<br/>
        ///   - `hourly`<br/>
        ///   - `daily`<br/>
        ///   - `weekly`<br/>
        ///   - `monthly`<br/>
        ///   - `yearly`
        /// </param>
        /// <param name="hour">
        /// The hour of the day to take the snapshot (if applicable).
        /// </param>
        /// <param name="day">
        /// The day of the week or month to take the snapshot (if applicable).
        /// </param>
        /// <param name="month">
        /// The month of the year to take the snapshot (if applicable).
        /// </param>
        /// <param name="retentionSeconds">
        /// How long to keep a snapshot (in seconds) before it's automatically deleted.<br/>
        /// If not set, the snapshot is kept indefinitely.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupScheduleItem(
            string frequency,
            int? hour,
            int? day,
            int? month,
            int? retentionSeconds)
        {
            this.Frequency = frequency ?? throw new global::System.ArgumentNullException(nameof(frequency));
            this.Hour = hour;
            this.Day = day;
            this.Month = month;
            this.RetentionSeconds = retentionSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleItem" /> class.
        /// </summary>
        public BackupScheduleItem()
        {
        }
    }
}