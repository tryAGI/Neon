
#nullable enable

namespace Neon
{
    /// <summary>
    /// Brand of credit card.
    /// </summary>
    public enum PaymentSourceBankCardBrand
    {
        /// <summary>
        /// 
        /// </summary>
        Amex,
        /// <summary>
        /// 
        /// </summary>
        Diners,
        /// <summary>
        /// 
        /// </summary>
        Discover,
        /// <summary>
        /// 
        /// </summary>
        Jcb,
        /// <summary>
        /// 
        /// </summary>
        Mastercard,
        /// <summary>
        /// 
        /// </summary>
        Unionpay,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Visa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PaymentSourceBankCardBrandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PaymentSourceBankCardBrand value)
        {
            return value switch
            {
                PaymentSourceBankCardBrand.Amex => "amex",
                PaymentSourceBankCardBrand.Diners => "diners",
                PaymentSourceBankCardBrand.Discover => "discover",
                PaymentSourceBankCardBrand.Jcb => "jcb",
                PaymentSourceBankCardBrand.Mastercard => "mastercard",
                PaymentSourceBankCardBrand.Unionpay => "unionpay",
                PaymentSourceBankCardBrand.Unknown => "unknown",
                PaymentSourceBankCardBrand.Visa => "visa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PaymentSourceBankCardBrand? ToEnum(string value)
        {
            return value switch
            {
                "amex" => PaymentSourceBankCardBrand.Amex,
                "diners" => PaymentSourceBankCardBrand.Diners,
                "discover" => PaymentSourceBankCardBrand.Discover,
                "jcb" => PaymentSourceBankCardBrand.Jcb,
                "mastercard" => PaymentSourceBankCardBrand.Mastercard,
                "unionpay" => PaymentSourceBankCardBrand.Unionpay,
                "unknown" => PaymentSourceBankCardBrand.Unknown,
                "visa" => PaymentSourceBankCardBrand.Visa,
                _ => null,
            };
        }
    }
}