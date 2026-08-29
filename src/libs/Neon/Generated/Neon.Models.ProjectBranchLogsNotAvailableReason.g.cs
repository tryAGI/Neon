
#nullable enable

namespace Neon
{
    /// <summary>
    /// Machine-readable reason why logs cannot be read:<br/>
    /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
    ///   have access to it.<br/>
    /// - `telemetry_not_enabled`: the branch exists but is not collecting telemetry, so it<br/>
    ///   has no logs to serve.
    /// </summary>
    public enum ProjectBranchLogsNotAvailableReason
    {
        /// <summary>
        /// the project or branch does not exist, or the caller does not
        /// </summary>
        BranchNotFound,
        /// <summary>
        /// the branch exists but is not collecting telemetry, so it
        /// </summary>
        TelemetryNotEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectBranchLogsNotAvailableReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectBranchLogsNotAvailableReason value)
        {
            return value switch
            {
                ProjectBranchLogsNotAvailableReason.BranchNotFound => "branch_not_found",
                ProjectBranchLogsNotAvailableReason.TelemetryNotEnabled => "telemetry_not_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectBranchLogsNotAvailableReason? ToEnum(string value)
        {
            return value switch
            {
                "branch_not_found" => ProjectBranchLogsNotAvailableReason.BranchNotFound,
                "telemetry_not_enabled" => ProjectBranchLogsNotAvailableReason.TelemetryNotEnabled,
                _ => null,
            };
        }
    }
}