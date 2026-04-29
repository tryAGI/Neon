
#nullable enable

namespace Neon
{
    /// <summary>
    /// How the branch was deleted: 'user' for manual deletion, 'ttl' for TTL expiration
    /// </summary>
    public enum BranchRecoveryInfoDeletionMethod
    {
        /// <summary>
        /// 'user' for manual deletion, 'ttl' for TTL expiration
        /// </summary>
        Ttl,
        /// <summary>
        /// 'user' for manual deletion, 'ttl' for TTL expiration
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchRecoveryInfoDeletionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchRecoveryInfoDeletionMethod value)
        {
            return value switch
            {
                BranchRecoveryInfoDeletionMethod.Ttl => "ttl",
                BranchRecoveryInfoDeletionMethod.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchRecoveryInfoDeletionMethod? ToEnum(string value)
        {
            return value switch
            {
                "ttl" => BranchRecoveryInfoDeletionMethod.Ttl,
                "user" => BranchRecoveryInfoDeletionMethod.User,
                _ => null,
            };
        }
    }
}