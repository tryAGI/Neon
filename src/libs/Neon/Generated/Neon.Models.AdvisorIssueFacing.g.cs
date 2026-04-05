
#nullable enable

namespace Neon
{
    /// <summary>
    /// Whether this issue affects external API exposure or is internal only<br/>
    /// Example: EXTERNAL
    /// </summary>
    public enum AdvisorIssueFacing
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvisorIssueFacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvisorIssueFacing value)
        {
            return value switch
            {
                AdvisorIssueFacing.External => "EXTERNAL",
                AdvisorIssueFacing.Internal => "INTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvisorIssueFacing? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => AdvisorIssueFacing.External,
                "INTERNAL" => AdvisorIssueFacing.Internal,
                _ => null,
            };
        }
    }
}