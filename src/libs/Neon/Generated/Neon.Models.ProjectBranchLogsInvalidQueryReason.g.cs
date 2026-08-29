
#nullable enable

namespace Neon
{
    /// <summary>
    /// Machine-readable reason why the request was rejected:<br/>
    /// - `time_range_too_large`: the requested window spans more than seven days.<br/>
    /// - `invalid_time_range`: `end_time` is not after `start_time`.<br/>
    /// - `conflicting_time_range`: both `since` and `start_time` were supplied.<br/>
    /// - `invalid_cursor`: the supplied `cursor` is malformed, expired, or was issued for a<br/>
    ///   different query.<br/>
    /// - `unknown_field`: the requested `field_name` is not one of the fields the log fields<br/>
    ///   endpoint reports for this branch.<br/>
    /// - `invalid_logql`: the supplied `logql` expression does not parse, or uses a<br/>
    ///   construct this endpoint does not accept.<br/>
    /// - `conflicting_filters`: `logql` was supplied alongside one or more structured<br/>
    ///   filters. Use one or the other.
    /// </summary>
    public enum ProjectBranchLogsInvalidQueryReason
    {
        /// <summary>
        /// `logql` was supplied alongside one or more structured
        /// </summary>
        ConflictingFilters,
        /// <summary>
        /// both `since` and `start_time` were supplied.
        /// </summary>
        ConflictingTimeRange,
        /// <summary>
        /// the supplied `cursor` is malformed, expired, or was issued for a
        /// </summary>
        InvalidCursor,
        /// <summary>
        /// the supplied `logql` expression does not parse, or uses a
        /// </summary>
        InvalidLogql,
        /// <summary>
        /// `end_time` is not after `start_time`.
        /// </summary>
        InvalidTimeRange,
        /// <summary>
        /// the requested window spans more than seven days.
        /// </summary>
        TimeRangeTooLarge,
        /// <summary>
        /// the requested `field_name` is not one of the fields the log fields
        /// </summary>
        UnknownField,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectBranchLogsInvalidQueryReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectBranchLogsInvalidQueryReason value)
        {
            return value switch
            {
                ProjectBranchLogsInvalidQueryReason.ConflictingFilters => "conflicting_filters",
                ProjectBranchLogsInvalidQueryReason.ConflictingTimeRange => "conflicting_time_range",
                ProjectBranchLogsInvalidQueryReason.InvalidCursor => "invalid_cursor",
                ProjectBranchLogsInvalidQueryReason.InvalidLogql => "invalid_logql",
                ProjectBranchLogsInvalidQueryReason.InvalidTimeRange => "invalid_time_range",
                ProjectBranchLogsInvalidQueryReason.TimeRangeTooLarge => "time_range_too_large",
                ProjectBranchLogsInvalidQueryReason.UnknownField => "unknown_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectBranchLogsInvalidQueryReason? ToEnum(string value)
        {
            return value switch
            {
                "conflicting_filters" => ProjectBranchLogsInvalidQueryReason.ConflictingFilters,
                "conflicting_time_range" => ProjectBranchLogsInvalidQueryReason.ConflictingTimeRange,
                "invalid_cursor" => ProjectBranchLogsInvalidQueryReason.InvalidCursor,
                "invalid_logql" => ProjectBranchLogsInvalidQueryReason.InvalidLogql,
                "invalid_time_range" => ProjectBranchLogsInvalidQueryReason.InvalidTimeRange,
                "time_range_too_large" => ProjectBranchLogsInvalidQueryReason.TimeRangeTooLarge,
                "unknown_field" => ProjectBranchLogsInvalidQueryReason.UnknownField,
                _ => null,
            };
        }
    }
}