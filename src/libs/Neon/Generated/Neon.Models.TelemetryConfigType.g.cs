
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum TelemetryConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Metrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelemetryConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelemetryConfigType value)
        {
            return value switch
            {
                TelemetryConfigType.Logs => "logs",
                TelemetryConfigType.Metrics => "metrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelemetryConfigType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => TelemetryConfigType.Logs,
                "metrics" => TelemetryConfigType.Metrics,
                _ => null,
            };
        }
    }
}