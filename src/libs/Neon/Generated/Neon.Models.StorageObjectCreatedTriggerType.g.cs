
#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger type discriminator.
    /// </summary>
    public enum StorageObjectCreatedTriggerType
    {
        /// <summary>
        ///
        /// </summary>
        StorageObjectCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageObjectCreatedTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageObjectCreatedTriggerType value)
        {
            return value switch
            {
                StorageObjectCreatedTriggerType.StorageObjectCreated => "storage_object_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageObjectCreatedTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "storage_object_created" => StorageObjectCreatedTriggerType.StorageObjectCreated,
                _ => null,
            };
        }
    }
}