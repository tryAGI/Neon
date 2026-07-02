
#nullable enable

namespace Neon
{
    /// <summary>
    /// The transfer direction. `upload` returns a presigned `PUT` URL;<br/>
    /// `download` returns a presigned `GET` URL.
    /// </summary>
    public enum PresignRequestOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Download,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresignRequestOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresignRequestOperation value)
        {
            return value switch
            {
                PresignRequestOperation.Download => "download",
                PresignRequestOperation.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresignRequestOperation? ToEnum(string value)
        {
            return value switch
            {
                "download" => PresignRequestOperation.Download,
                "upload" => PresignRequestOperation.Upload,
                _ => null,
            };
        }
    }
}