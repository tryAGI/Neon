
#nullable enable

namespace Neon
{
    /// <summary>
    /// Lifecycle state of the compute endpoint. `init`: being initialized. `active`: running and accepting connections. `idle`: suspended (scaled to zero).
    /// </summary>
    public enum EndpointState
    {
        /// <summary>
        /// being initialized. `active`: running and accepting connections. `idle`: suspended (scaled to zero).
        /// </summary>
        Active,
        /// <summary>
        /// being initialized. `active`: running and accepting connections. `idle`: suspended (scaled to zero).
        /// </summary>
        Idle,
        /// <summary>
        /// being initialized. `active`: running and accepting connections. `idle`: suspended (scaled to zero).
        /// </summary>
        Init,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndpointStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointState value)
        {
            return value switch
            {
                EndpointState.Active => "active",
                EndpointState.Idle => "idle",
                EndpointState.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointState? ToEnum(string value)
        {
            return value switch
            {
                "active" => EndpointState.Active,
                "idle" => EndpointState.Idle,
                "init" => EndpointState.Init,
                _ => null,
            };
        }
    }
}