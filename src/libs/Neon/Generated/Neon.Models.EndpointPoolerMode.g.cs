
#nullable enable

namespace Neon
{
    /// <summary>
    /// DEPRECATED. The connection pooler mode. Neon supports PgBouncer in `transaction` mode only. This schema is deprecated and will be removed after 2026-06-20.
    /// </summary>
    public enum EndpointPoolerMode
    {
        /// <summary>
        /// 
        /// </summary>
        Transaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndpointPoolerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointPoolerMode value)
        {
            return value switch
            {
                EndpointPoolerMode.Transaction => "transaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointPoolerMode? ToEnum(string value)
        {
            return value switch
            {
                "transaction" => EndpointPoolerMode.Transaction,
                _ => null,
            };
        }
    }
}