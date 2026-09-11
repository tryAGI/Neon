
#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger type discriminator; it does not change the trigger type.
    /// </summary>
    public enum StorageObjectCreatedTriggerUpdateRequestType
    {
        /// <summary>
        ///
        /// </summary>
        StorageObjectCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageObjectCreatedTriggerUpdateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageObjectCreatedTriggerUpdateRequestType value)
        {
            return value switch
            {
                StorageObjectCreatedTriggerUpdateRequestType.StorageObjectCreated => "storage_object_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageObjectCreatedTriggerUpdateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "storage_object_created" => StorageObjectCreatedTriggerUpdateRequestType.StorageObjectCreated,
                _ => null,
            };
        }
    }
}