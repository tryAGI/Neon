
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LimitsPerProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ComputeTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written_data_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long WrittenDataBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_transfer_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DataTransferBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_default_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SuspendDefaultBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsPerProject" /> class.
        /// </summary>
        /// <param name="computeTimeSeconds"></param>
        /// <param name="writtenDataBytes"></param>
        /// <param name="dataTransferBytes"></param>
        /// <param name="suspendDefaultBranch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LimitsPerProject(
            long computeTimeSeconds,
            long writtenDataBytes,
            long dataTransferBytes,
            bool suspendDefaultBranch)
        {
            this.ComputeTimeSeconds = computeTimeSeconds;
            this.WrittenDataBytes = writtenDataBytes;
            this.DataTransferBytes = dataTransferBytes;
            this.SuspendDefaultBranch = suspendDefaultBranch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsPerProject" /> class.
        /// </summary>
        public LimitsPerProject()
        {
        }
    }
}