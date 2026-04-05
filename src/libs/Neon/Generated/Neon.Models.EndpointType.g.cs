
#nullable enable

namespace Neon
{
    /// <summary>
    /// The compute endpoint type. Either `read_write` or `read_only`.
    /// </summary>
    public enum EndpointType
    {
        /// <summary>
        /// 
        /// </summary>
        ReadOnly,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointType value)
        {
            return value switch
            {
                EndpointType.ReadOnly => "read_only",
                EndpointType.ReadWrite => "read_write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointType? ToEnum(string value)
        {
            return value switch
            {
                "read_only" => EndpointType.ReadOnly,
                "read_write" => EndpointType.ReadWrite,
                _ => null,
            };
        }
    }
}