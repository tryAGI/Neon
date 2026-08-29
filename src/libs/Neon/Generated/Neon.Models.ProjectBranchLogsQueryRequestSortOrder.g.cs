
#nullable enable

namespace Neon
{
    /// <summary>
    /// Order matching records by timestamp. `desc`, the default, returns<br/>
    /// the newest records first.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ProjectBranchLogsQueryRequestSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectBranchLogsQueryRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectBranchLogsQueryRequestSortOrder value)
        {
            return value switch
            {
                ProjectBranchLogsQueryRequestSortOrder.Asc => "asc",
                ProjectBranchLogsQueryRequestSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectBranchLogsQueryRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ProjectBranchLogsQueryRequestSortOrder.Asc,
                "desc" => ProjectBranchLogsQueryRequestSortOrder.Desc,
                _ => null,
            };
        }
    }
}