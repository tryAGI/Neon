
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupportTicketSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Urgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportTicketSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportTicketSeverity value)
        {
            return value switch
            {
                SupportTicketSeverity.Critical => "critical",
                SupportTicketSeverity.High => "high",
                SupportTicketSeverity.Low => "low",
                SupportTicketSeverity.Normal => "normal",
                SupportTicketSeverity.Urgent => "urgent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportTicketSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => SupportTicketSeverity.Critical,
                "high" => SupportTicketSeverity.High,
                "low" => SupportTicketSeverity.Low,
                "normal" => SupportTicketSeverity.Normal,
                "urgent" => SupportTicketSeverity.Urgent,
                _ => null,
            };
        }
    }
}