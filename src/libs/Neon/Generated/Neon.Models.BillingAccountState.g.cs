
#nullable enable

namespace Neon
{
    /// <summary>
    /// State of the billing account.
    /// </summary>
    public enum BillingAccountState
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deactivated,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingAccountStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingAccountState value)
        {
            return value switch
            {
                BillingAccountState.Unknown => "UNKNOWN",
                BillingAccountState.Active => "active",
                BillingAccountState.Deactivated => "deactivated",
                BillingAccountState.Deleted => "deleted",
                BillingAccountState.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingAccountState? ToEnum(string value)
        {
            return value switch
            {
                "UNKNOWN" => BillingAccountState.Unknown,
                "active" => BillingAccountState.Active,
                "deactivated" => BillingAccountState.Deactivated,
                "deleted" => BillingAccountState.Deleted,
                "suspended" => BillingAccountState.Suspended,
                _ => null,
            };
        }
    }
}