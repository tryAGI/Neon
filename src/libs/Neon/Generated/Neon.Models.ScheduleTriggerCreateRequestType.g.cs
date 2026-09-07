
#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger type discriminator.
    /// </summary>
    public enum ScheduleTriggerCreateRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduleTriggerCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduleTriggerCreateRequestType value)
        {
            return value switch
            {
                ScheduleTriggerCreateRequestType.Schedule => "schedule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduleTriggerCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => ScheduleTriggerCreateRequestType.Schedule,
                _ => null,
            };
        }
    }
}