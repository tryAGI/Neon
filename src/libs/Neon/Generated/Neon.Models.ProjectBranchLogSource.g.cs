
#nullable enable

namespace Neon
{
    /// <summary>
    /// The Neon service that emitted the log record.
    /// </summary>
    public enum ProjectBranchLogSource
    {
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        PgEndpoint,
        /// <summary>
        ///
        /// </summary>
        Storage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectBranchLogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectBranchLogSource value)
        {
            return value switch
            {
                ProjectBranchLogSource.Function => "function",
                ProjectBranchLogSource.PgEndpoint => "pg_endpoint",
                ProjectBranchLogSource.Storage => "storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectBranchLogSource? ToEnum(string value)
        {
            return value switch
            {
                "function" => ProjectBranchLogSource.Function,
                "pg_endpoint" => ProjectBranchLogSource.PgEndpoint,
                "storage" => ProjectBranchLogSource.Storage,
                _ => null,
            };
        }
    }
}