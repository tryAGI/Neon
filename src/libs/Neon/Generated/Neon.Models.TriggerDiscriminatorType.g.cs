
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerDiscriminatorType value)
        {
            return value switch
            {
                TriggerDiscriminatorType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => TriggerDiscriminatorType.Schedule,
                _ => null,
            };
        }
    }
}