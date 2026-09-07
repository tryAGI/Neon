
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerUpdateRequestDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerUpdateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerUpdateRequestDiscriminatorType value)
        {
            return value switch
            {
                TriggerUpdateRequestDiscriminatorType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerUpdateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => TriggerUpdateRequestDiscriminatorType.Schedule,
                _ => null,
            };
        }
    }
}