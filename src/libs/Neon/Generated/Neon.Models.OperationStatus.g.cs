
#nullable enable

namespace Neon
{
    /// <summary>
    /// The status of the operation
    /// </summary>
    public enum OperationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Scheduling,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OperationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OperationStatus value)
        {
            return value switch
            {
                OperationStatus.Cancelled => "cancelled",
                OperationStatus.Cancelling => "cancelling",
                OperationStatus.Error => "error",
                OperationStatus.Failed => "failed",
                OperationStatus.Finished => "finished",
                OperationStatus.Running => "running",
                OperationStatus.Scheduling => "scheduling",
                OperationStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OperationStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => OperationStatus.Cancelled,
                "cancelling" => OperationStatus.Cancelling,
                "error" => OperationStatus.Error,
                "failed" => OperationStatus.Failed,
                "finished" => OperationStatus.Finished,
                "running" => OperationStatus.Running,
                "scheduling" => OperationStatus.Scheduling,
                "skipped" => OperationStatus.Skipped,
                _ => null,
            };
        }
    }
}