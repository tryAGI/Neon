
#nullable enable

namespace Neon
{
    /// <summary>
    /// Type of subscription to Neon Cloud.<br/>
    /// Notice that for users without billing account this will be "UNKNOWN"
    /// </summary>
    public enum BillingSubscriptionType
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        AwsMarketplace,
        /// <summary>
        /// 
        /// </summary>
        Business,
        /// <summary>
        /// 
        /// </summary>
        DirectSales,
        /// <summary>
        /// 
        /// </summary>
        DirectSalesV3,
        /// <summary>
        /// 
        /// </summary>
        FreeV2,
        /// <summary>
        /// 
        /// </summary>
        FreeV3,
        /// <summary>
        /// 
        /// </summary>
        Launch,
        /// <summary>
        /// 
        /// </summary>
        LaunchV3,
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// 
        /// </summary>
        ScaleV3,
        /// <summary>
        /// 
        /// </summary>
        VercelPgLegacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingSubscriptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingSubscriptionType value)
        {
            return value switch
            {
                BillingSubscriptionType.Unknown => "UNKNOWN",
                BillingSubscriptionType.AwsMarketplace => "aws_marketplace",
                BillingSubscriptionType.Business => "business",
                BillingSubscriptionType.DirectSales => "direct_sales",
                BillingSubscriptionType.DirectSalesV3 => "direct_sales_v3",
                BillingSubscriptionType.FreeV2 => "free_v2",
                BillingSubscriptionType.FreeV3 => "free_v3",
                BillingSubscriptionType.Launch => "launch",
                BillingSubscriptionType.LaunchV3 => "launch_v3",
                BillingSubscriptionType.Scale => "scale",
                BillingSubscriptionType.ScaleV3 => "scale_v3",
                BillingSubscriptionType.VercelPgLegacy => "vercel_pg_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingSubscriptionType? ToEnum(string value)
        {
            return value switch
            {
                "UNKNOWN" => BillingSubscriptionType.Unknown,
                "aws_marketplace" => BillingSubscriptionType.AwsMarketplace,
                "business" => BillingSubscriptionType.Business,
                "direct_sales" => BillingSubscriptionType.DirectSales,
                "direct_sales_v3" => BillingSubscriptionType.DirectSalesV3,
                "free_v2" => BillingSubscriptionType.FreeV2,
                "free_v3" => BillingSubscriptionType.FreeV3,
                "launch" => BillingSubscriptionType.Launch,
                "launch_v3" => BillingSubscriptionType.LaunchV3,
                "scale" => BillingSubscriptionType.Scale,
                "scale_v3" => BillingSubscriptionType.ScaleV3,
                "vercel_pg_legacy" => BillingSubscriptionType.VercelPgLegacy,
                _ => null,
            };
        }
    }
}