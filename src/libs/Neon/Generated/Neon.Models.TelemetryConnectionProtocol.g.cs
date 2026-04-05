
#nullable enable

namespace Neon
{
    /// <summary>
    /// Required. Communication protocol used to send telemetry data. Options: grpc, http.
    /// </summary>
    public enum TelemetryConnectionProtocol
    {
        /// <summary>
        /// grpc, http.
        /// </summary>
        Grpc,
        /// <summary>
        /// grpc, http.
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelemetryConnectionProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelemetryConnectionProtocol value)
        {
            return value switch
            {
                TelemetryConnectionProtocol.Grpc => "grpc",
                TelemetryConnectionProtocol.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelemetryConnectionProtocol? ToEnum(string value)
        {
            return value switch
            {
                "grpc" => TelemetryConnectionProtocol.Grpc,
                "http" => TelemetryConnectionProtocol.Http,
                _ => null,
            };
        }
    }
}