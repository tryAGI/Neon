
#nullable enable

namespace Neon
{
    /// <summary>
    /// Controls anonymous access to objects in the bucket.<br/>
    /// - `private`: all reads and writes require authenticated requests (default).<br/>
    /// - `public_read`: anonymous `GetObject`/`HeadObject` requests succeed; listing,<br/>
    ///   writes, and deletes still require authenticated requests.
    /// </summary>
    public enum BucketAccessLevel
    {
        /// <summary>
        /// all reads and writes require authenticated requests (default).
        /// </summary>
        Private,
        /// <summary>
        /// anonymous `GetObject`/`HeadObject` requests succeed; listing,
        /// </summary>
        PublicRead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketAccessLevel value)
        {
            return value switch
            {
                BucketAccessLevel.Private => "private",
                BucketAccessLevel.PublicRead => "public_read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "private" => BucketAccessLevel.Private,
                "public_read" => BucketAccessLevel.PublicRead,
                _ => null,
            };
        }
    }
}