
#nullable enable

namespace Neon
{
    /// <summary>
    /// Build lifecycle status of the deployment.
    /// </summary>
    public enum NeonFunctionDeploymentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeonFunctionDeploymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeonFunctionDeploymentStatus value)
        {
            return value switch
            {
                NeonFunctionDeploymentStatus.Building => "building",
                NeonFunctionDeploymentStatus.Completed => "completed",
                NeonFunctionDeploymentStatus.Failed => "failed",
                NeonFunctionDeploymentStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeonFunctionDeploymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "building" => NeonFunctionDeploymentStatus.Building,
                "completed" => NeonFunctionDeploymentStatus.Completed,
                "failed" => NeonFunctionDeploymentStatus.Failed,
                "pending" => NeonFunctionDeploymentStatus.Pending,
                _ => null,
            };
        }
    }
}