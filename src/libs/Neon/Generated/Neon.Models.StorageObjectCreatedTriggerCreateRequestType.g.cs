
#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger type discriminator.
    /// </summary>
    public enum StorageObjectCreatedTriggerCreateRequestType
    {
        /// <summary>
        ///
        /// </summary>
        StorageObjectCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageObjectCreatedTriggerCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageObjectCreatedTriggerCreateRequestType value)
        {
            return value switch
            {
                StorageObjectCreatedTriggerCreateRequestType.StorageObjectCreated => "storage_object_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageObjectCreatedTriggerCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "storage_object_created" => StorageObjectCreatedTriggerCreateRequestType.StorageObjectCreated,
                _ => null,
            };
        }
    }
}