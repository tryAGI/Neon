
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum NeonAuthProviderProjectTransferStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthProviderProjectTransferStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthProviderProjectTransferStatus value)
        {
            return value switch
            {
                NeonAuthProviderProjectTransferStatus.Finished => "finished",
                NeonAuthProviderProjectTransferStatus.Initiated => "initiated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthProviderProjectTransferStatus? ToEnum(string value)
        {
            return value switch
            {
                "finished" => NeonAuthProviderProjectTransferStatus.Finished,
                "initiated" => NeonAuthProviderProjectTransferStatus.Initiated,
                _ => null,
            };
        }
    }
}