
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchStorageNotEnabled
    {
        /// <summary>
        /// Example: STORAGE_NOT_ENABLED
        /// </summary>
        /// <example>STORAGE_NOT_ENABLED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable reason why storage is unavailable:<br/>
        /// - `org_not_entitled`: the org's `PlatformBranchableStorage` feature flag is off.<br/>
        /// - `region_unavailable`: the project's region has no storage admin service wired.<br/>
        /// - `branch_directory_missing`: the branch is not registered in the storage service.<br/>
        /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
        ///   have access to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BranchStorageNotEnabledReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BranchStorageNotEnabledReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchStorageNotEnabled" /> class.
        /// </summary>
        /// <param name="code">
        /// Example: STORAGE_NOT_ENABLED
        /// </param>
        /// <param name="message"></param>
        /// <param name="reason">
        /// Machine-readable reason why storage is unavailable:<br/>
        /// - `org_not_entitled`: the org's `PlatformBranchableStorage` feature flag is off.<br/>
        /// - `region_unavailable`: the project's region has no storage admin service wired.<br/>
        /// - `branch_directory_missing`: the branch is not registered in the storage service.<br/>
        /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
        ///   have access to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchStorageNotEnabled(
            string code,
            string message,
            global::Neon.BranchStorageNotEnabledReason reason)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchStorageNotEnabled" /> class.
        /// </summary>
        public BranchStorageNotEnabled()
        {
        }

    }
}