
#nullable enable

namespace Neon
{
    /// <summary>
    /// Indicates whether and how an account makes payments.
    /// </summary>
    public enum BillingPaymentMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        AwsMp,
        /// <summary>
        /// 
        /// </summary>
        AzureMp,
        /// <summary>
        /// 
        /// </summary>
        DirectPayment,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        SharedPaymentToken,
        /// <summary>
        /// 
        /// </summary>
        Sponsorship,
        /// <summary>
        /// 
        /// </summary>
        Staff,
        /// <summary>
        /// 
        /// </summary>
        Stripe,
        /// <summary>
        /// 
        /// </summary>
        Trial,
        /// <summary>
        /// 
        /// </summary>
        VercelMp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingPaymentMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingPaymentMethod value)
        {
            return value switch
            {
                BillingPaymentMethod.Unknown => "UNKNOWN",
                BillingPaymentMethod.AwsMp => "aws_mp",
                BillingPaymentMethod.AzureMp => "azure_mp",
                BillingPaymentMethod.DirectPayment => "direct_payment",
                BillingPaymentMethod.None => "none",
                BillingPaymentMethod.SharedPaymentToken => "shared_payment_token",
                BillingPaymentMethod.Sponsorship => "sponsorship",
                BillingPaymentMethod.Staff => "staff",
                BillingPaymentMethod.Stripe => "stripe",
                BillingPaymentMethod.Trial => "trial",
                BillingPaymentMethod.VercelMp => "vercel_mp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingPaymentMethod? ToEnum(string value)
        {
            return value switch
            {
                "UNKNOWN" => BillingPaymentMethod.Unknown,
                "aws_mp" => BillingPaymentMethod.AwsMp,
                "azure_mp" => BillingPaymentMethod.AzureMp,
                "direct_payment" => BillingPaymentMethod.DirectPayment,
                "none" => BillingPaymentMethod.None,
                "shared_payment_token" => BillingPaymentMethod.SharedPaymentToken,
                "sponsorship" => BillingPaymentMethod.Sponsorship,
                "staff" => BillingPaymentMethod.Staff,
                "stripe" => BillingPaymentMethod.Stripe,
                "trial" => BillingPaymentMethod.Trial,
                "vercel_mp" => BillingPaymentMethod.VercelMp,
                _ => null,
            };
        }
    }
}