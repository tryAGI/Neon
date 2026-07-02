
#nullable enable

namespace Neon
{
    /// <summary>
    /// Machine-readable reason why the AI gateway is unavailable:<br/>
    /// - `ai_gateway_unavailable`: the project's region/cell has no AI gateway configured.<br/>
    /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
    ///   have access to it.
    /// </summary>
    public enum BranchAiGatewayNotEnabledReason
    {
        /// <summary>
        /// the project's region/cell has no AI gateway configured.
        /// </summary>
        AiGatewayUnavailable,
        /// <summary>
        /// the project or branch does not exist, or the caller does not
        /// </summary>
        BranchNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BranchAiGatewayNotEnabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchAiGatewayNotEnabledReason value)
        {
            return value switch
            {
                BranchAiGatewayNotEnabledReason.AiGatewayUnavailable => "ai_gateway_unavailable",
                BranchAiGatewayNotEnabledReason.BranchNotFound => "branch_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchAiGatewayNotEnabledReason? ToEnum(string value)
        {
            return value switch
            {
                "ai_gateway_unavailable" => BranchAiGatewayNotEnabledReason.AiGatewayUnavailable,
                "branch_not_found" => BranchAiGatewayNotEnabledReason.BranchNotFound,
                _ => null,
            };
        }
    }
}