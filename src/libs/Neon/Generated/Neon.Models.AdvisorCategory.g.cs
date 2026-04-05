
#nullable enable

namespace Neon
{
    /// <summary>
    /// Category of an advisor issue
    /// </summary>
    public enum AdvisorCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Performance,
        /// <summary>
        /// 
        /// </summary>
        Security,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvisorCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvisorCategory value)
        {
            return value switch
            {
                AdvisorCategory.Performance => "PERFORMANCE",
                AdvisorCategory.Security => "SECURITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvisorCategory? ToEnum(string value)
        {
            return value switch
            {
                "PERFORMANCE" => AdvisorCategory.Performance,
                "SECURITY" => AdvisorCategory.Security,
                _ => null,
            };
        }
    }
}