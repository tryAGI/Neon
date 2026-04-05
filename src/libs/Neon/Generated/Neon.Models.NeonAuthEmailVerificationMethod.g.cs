
#nullable enable

namespace Neon
{
    /// <summary>
    /// The email verification method to use.<br/>
    /// - `link`: Sends a verification link via email<br/>
    /// - `otp`: Sends a one-time password (OTP) via email
    /// </summary>
    public enum NeonAuthEmailVerificationMethod
    {
        /// <summary>
        /// Sends a verification link via email
        /// </summary>
        Link,
        /// <summary>
        /// Sends a one-time password (OTP) via email
        /// </summary>
        Otp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthEmailVerificationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthEmailVerificationMethod value)
        {
            return value switch
            {
                NeonAuthEmailVerificationMethod.Link => "link",
                NeonAuthEmailVerificationMethod.Otp => "otp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthEmailVerificationMethod? ToEnum(string value)
        {
            return value switch
            {
                "link" => NeonAuthEmailVerificationMethod.Link,
                "otp" => NeonAuthEmailVerificationMethod.Otp,
                _ => null,
            };
        }
    }
}