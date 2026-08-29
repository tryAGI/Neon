
#nullable enable

namespace Neon
{
    /// <summary>
    /// Lifecycle state of the operation. `scheduling`: queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
    /// </summary>
    public enum OperationStatus
    {
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Cancelled,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Cancelling,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Error,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Failed,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Finished,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Running,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
        /// </summary>
        Scheduling,
        /// <summary>
        /// queued, not yet started. `running`: actively executing. `finished`: completed successfully. `failed`: ended with a failure. `error`: ended with a terminal error. `cancelling`: cancellation requested but not yet complete. `cancelled`: stopped before completion. `skipped`: bypassed without executing.
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