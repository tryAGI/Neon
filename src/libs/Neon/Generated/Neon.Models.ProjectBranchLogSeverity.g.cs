
#nullable enable

namespace Neon
{
    /// <summary>
    /// An OpenTelemetry severity level. A minimum severity includes every<br/>
    /// higher level in this order: `trace`, `debug`, `info`, `warn`, `error`,<br/>
    /// `fatal`.
    /// </summary>
    public enum ProjectBranchLogSeverity
    {
        /// <summary>
        /// `trace`, `debug`, `info`, `warn`, `error`,
        /// </summary>
        Debug,
        /// <summary>
        /// `trace`, `debug`, `info`, `warn`, `error`,
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Fatal,
        /// <summary>
        /// `trace`, `debug`, `info`, `warn`, `error`,
        /// </summary>
        Info,
        /// <summary>
        /// `trace`, `debug`, `info`, `warn`, `error`,
        /// </summary>
        Trace,
        /// <summary>
        /// `trace`, `debug`, `info`, `warn`, `error`,
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectBranchLogSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectBranchLogSeverity value)
        {
            return value switch
            {
                ProjectBranchLogSeverity.Debug => "debug",
                ProjectBranchLogSeverity.Error => "error",
                ProjectBranchLogSeverity.Fatal => "fatal",
                ProjectBranchLogSeverity.Info => "info",
                ProjectBranchLogSeverity.Trace => "trace",
                ProjectBranchLogSeverity.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectBranchLogSeverity? ToEnum(string value)
        {
            return value switch
            {
                "debug" => ProjectBranchLogSeverity.Debug,
                "error" => ProjectBranchLogSeverity.Error,
                "fatal" => ProjectBranchLogSeverity.Fatal,
                "info" => ProjectBranchLogSeverity.Info,
                "trace" => ProjectBranchLogSeverity.Trace,
                "warn" => ProjectBranchLogSeverity.Warn,
                _ => null,
            };
        }
    }
}