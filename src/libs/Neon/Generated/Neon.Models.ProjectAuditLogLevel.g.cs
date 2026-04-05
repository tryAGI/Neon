
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectAuditLogLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Base,
        /// <summary>
        /// 
        /// </summary>
        Extended,
        /// <summary>
        /// 
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAuditLogLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAuditLogLevel value)
        {
            return value switch
            {
                ProjectAuditLogLevel.Base => "base",
                ProjectAuditLogLevel.Extended => "extended",
                ProjectAuditLogLevel.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAuditLogLevel? ToEnum(string value)
        {
            return value switch
            {
                "base" => ProjectAuditLogLevel.Base,
                "extended" => ProjectAuditLogLevel.Extended,
                "full" => ProjectAuditLogLevel.Full,
                _ => null,
            };
        }
    }
}