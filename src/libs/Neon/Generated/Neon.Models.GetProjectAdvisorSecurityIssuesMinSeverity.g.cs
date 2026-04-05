
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectAdvisorSecurityIssuesMinSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectAdvisorSecurityIssuesMinSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectAdvisorSecurityIssuesMinSeverity value)
        {
            return value switch
            {
                GetProjectAdvisorSecurityIssuesMinSeverity.Error => "ERROR",
                GetProjectAdvisorSecurityIssuesMinSeverity.Info => "INFO",
                GetProjectAdvisorSecurityIssuesMinSeverity.Warn => "WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectAdvisorSecurityIssuesMinSeverity? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => GetProjectAdvisorSecurityIssuesMinSeverity.Error,
                "INFO" => GetProjectAdvisorSecurityIssuesMinSeverity.Info,
                "WARN" => GetProjectAdvisorSecurityIssuesMinSeverity.Warn,
                _ => null,
            };
        }
    }
}