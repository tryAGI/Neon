
#nullable enable

namespace Neon
{
    /// <summary>
    /// Type of application integration
    /// </summary>
    public enum ApplicationType
    {
        /// <summary>
        /// 
        /// </summary>
        Datadog,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Opentelemetry,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplicationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplicationType value)
        {
            return value switch
            {
                ApplicationType.Datadog => "datadog",
                ApplicationType.Github => "github",
                ApplicationType.Opentelemetry => "opentelemetry",
                ApplicationType.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplicationType? ToEnum(string value)
        {
            return value switch
            {
                "datadog" => ApplicationType.Datadog,
                "github" => ApplicationType.Github,
                "opentelemetry" => ApplicationType.Opentelemetry,
                "vercel" => ApplicationType.Vercel,
                _ => null,
            };
        }
    }
}