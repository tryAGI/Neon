
#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger type discriminator; it does not change the trigger type.
    /// </summary>
    public enum ScheduleTriggerUpdateRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleTriggerUpdateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleTriggerUpdateRequestType value)
        {
            return value switch
            {
                ScheduleTriggerUpdateRequestType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleTriggerUpdateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => ScheduleTriggerUpdateRequestType.Schedule,
                _ => null,
            };
        }
    }
}