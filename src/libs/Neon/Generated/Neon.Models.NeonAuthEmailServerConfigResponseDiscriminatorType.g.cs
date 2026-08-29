
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public enum NeonAuthEmailServerConfigResponseDiscriminatorType
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
    public static class NeonAuthEmailServerConfigResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonAuthEmailServerConfigResponseDiscriminatorType value)
        {
            return value switch
            {
                NeonAuthEmailServerConfigResponseDiscriminatorType.Shared => "shared",
                NeonAuthEmailServerConfigResponseDiscriminatorType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonAuthEmailServerConfigResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "shared" => NeonAuthEmailServerConfigResponseDiscriminatorType.Shared,
                "standard" => NeonAuthEmailServerConfigResponseDiscriminatorType.Standard,
                _ => null,
            };
        }
    }
}