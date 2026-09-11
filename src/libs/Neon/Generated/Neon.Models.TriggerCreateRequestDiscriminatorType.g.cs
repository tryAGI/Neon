
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerCreateRequestDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
        /// <summary>
        ///
        /// </summary>
        StorageObjectCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerCreateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerCreateRequestDiscriminatorType value)
        {
            return value switch
            {
                TriggerCreateRequestDiscriminatorType.Schedule => "schedule",
                TriggerCreateRequestDiscriminatorType.StorageObjectCreated => "storage_object_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerCreateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => TriggerCreateRequestDiscriminatorType.Schedule,
                "storage_object_created" => TriggerCreateRequestDiscriminatorType.StorageObjectCreated,
                _ => null,
            };
        }
    }
}