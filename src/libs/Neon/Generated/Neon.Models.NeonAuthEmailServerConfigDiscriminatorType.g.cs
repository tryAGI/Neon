
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum NeonAuthEmailServerConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Shared,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonAuthEmailServerConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthEmailServerConfigDiscriminatorType value)
        {
            return value switch
            {
                NeonAuthEmailServerConfigDiscriminatorType.Shared => "shared",
                NeonAuthEmailServerConfigDiscriminatorType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthEmailServerConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "shared" => NeonAuthEmailServerConfigDiscriminatorType.Shared,
                "standard" => NeonAuthEmailServerConfigDiscriminatorType.Standard,
                _ => null,
            };
        }
    }
}