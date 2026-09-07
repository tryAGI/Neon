
#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger type discriminator.
    /// </summary>
    public enum ScheduleTriggerType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleTriggerType value)
        {
            return value switch
            {
                ScheduleTriggerType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => ScheduleTriggerType.Schedule,
                _ => null,
            };
        }
    }
}