
#nullable enable

namespace Neon
{
    /// <summary>
    /// A maintenance window is a time period during which Neon may perform maintenance on the project's infrastructure.<br/>
    /// During this time, the project's compute endpoints may be unavailable and existing connections can be<br/>
    /// interrupted.
    /// </summary>
    public sealed partial class MaintenanceWindow
    {
        /// <summary>
        /// A list of weekdays when the maintenance window is active.<br/>
        /// Encoded as ints, where 1 - Monday, and 7 - Sunday.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekdays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Weekdays { get; set; }

        /// <summary>
        /// Start time of the maintenance window, in the format of "HH:MM". Uses UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// End time of the maintenance window, in the format of "HH:MM". Uses UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaintenanceWindow" /> class.
        /// </summary>
        /// <param name="weekdays">
        /// A list of weekdays when the maintenance window is active.<br/>
        /// Encoded as ints, where 1 - Monday, and 7 - Sunday.
        /// </param>
        /// <param name="startTime">
        /// Start time of the maintenance window, in the format of "HH:MM". Uses UTC.
        /// </param>
        /// <param name="endTime">
        /// End time of the maintenance window, in the format of "HH:MM". Uses UTC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaintenanceWindow(
            global::System.Collections.Generic.IList<int> weekdays,
            string startTime,
            string endTime)
        {
            this.Weekdays = weekdays ?? throw new global::System.ArgumentNullException(nameof(weekdays));
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaintenanceWindow" /> class.
        /// </summary>
        public MaintenanceWindow()
        {
        }
    }
}