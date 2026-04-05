
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsumptionHistoryGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsumptionHistoryGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsumptionHistoryGranularity value)
        {
            return value switch
            {
                ConsumptionHistoryGranularity.Daily => "daily",
                ConsumptionHistoryGranularity.Hourly => "hourly",
                ConsumptionHistoryGranularity.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsumptionHistoryGranularity? ToEnum(string value)
        {
            return value switch
            {
                "daily" => ConsumptionHistoryGranularity.Daily,
                "hourly" => ConsumptionHistoryGranularity.Hourly,
                "monthly" => ConsumptionHistoryGranularity.Monthly,
                _ => null,
            };
        }
    }
}