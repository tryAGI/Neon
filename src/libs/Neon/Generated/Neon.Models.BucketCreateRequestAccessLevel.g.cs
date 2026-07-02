
#nullable enable

namespace Neon
{
    /// <summary>
    /// Access level for the bucket. Defaults to `private`. Set to `public_read`<br/>
    /// to allow anonymous `GetObject`/`HeadObject` on objects in this bucket.<br/>
    /// Default Value: private
    /// </summary>
    public enum BucketCreateRequestAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        PublicRead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketCreateRequestAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketCreateRequestAccessLevel value)
        {
            return value switch
            {
                BucketCreateRequestAccessLevel.Private => "private",
                BucketCreateRequestAccessLevel.PublicRead => "public_read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketCreateRequestAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "private" => BucketCreateRequestAccessLevel.Private,
                "public_read" => BucketCreateRequestAccessLevel.PublicRead,
                _ => null,
            };
        }
    }
}