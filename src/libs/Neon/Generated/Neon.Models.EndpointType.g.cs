
#nullable enable

namespace Neon
{
    /// <summary>
    /// Compute endpoint type. `read_write`: the primary read-write endpoint (one per branch). `read_only`: a read replica endpoint (multiple allowed per branch).
    /// </summary>
    public enum EndpointType
    {
        /// <summary>
        /// the primary read-write endpoint (one per branch). `read_only`: a read replica endpoint (multiple allowed per branch).
        /// </summary>
        ReadOnly,
        /// <summary>
        /// the primary read-write endpoint (one per branch). `read_only`: a read replica endpoint (multiple allowed per branch).
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