
#nullable enable

namespace Neon
{
    /// <summary>
    /// A branch-effective trigger that invokes a Function after a successful<br/>
    /// upload matching its exact bucket and optional object-key prefix.
    /// </summary>
    public sealed partial class StorageObjectCreatedTrigger
    {
        /// <summary>
        /// Trigger type discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.StorageObjectCreatedTriggerTypeJsonConverter))]
        public global::Neon.StorageObjectCreatedTriggerType Type { get; set; }

        /// <summary>
        /// Opaque, server-minted project-wide trigger identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// The branch-local Function slug resolved when an invocation is consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionSlug { get; set; }

        /// <summary>
        /// Human-readable trigger name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Path passed to the target Function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionPath { get; set; }

        /// <summary>
        /// Matches successful uploads to one exact bucket and, when configured, an<br/>
        /// object-key prefix. The Function receives a JSON request body with<br/>
        /// `type` set to `storage_object_created` and a `data` object containing<br/>
        /// exactly `bucket_name` and `object_key`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_object_created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.FunctionTriggerStorageObjectCreated StorageObjectCreated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Monotonic configuration version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Version { get; set; }

        /// <summary>
        /// The public `branch_id` of the branch that authored the effective configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceBranchId { get; set; }

        /// <summary>
        /// True when the effective configuration was authored on an ancestor branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Inherited { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObjectCreatedTrigger" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// Opaque, server-minted project-wide trigger identifier.
        /// </param>
        /// <param name="functionSlug">
        /// The branch-local Function slug resolved when an invocation is consumed.
        /// </param>
        /// <param name="name">
        /// Human-readable trigger name.
        /// </param>
        /// <param name="functionPath">
        /// Path passed to the target Function.
        /// </param>
        /// <param name="storageObjectCreated">
        /// Matches successful uploads to one exact bucket and, when configured, an<br/>
        /// object-key prefix. The Function receives a JSON request body with<br/>
        /// `type` set to `storage_object_created` and a `data` object containing<br/>
        /// exactly `bucket_name` and `object_key`.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="version">
        /// Monotonic configuration version.
        /// </param>
        /// <param name="sourceBranchId">
        /// The public `branch_id` of the branch that authored the effective configuration.
        /// </param>
        /// <param name="inherited">
        /// True when the effective configuration was authored on an ancestor branch.
        /// </param>
        /// <param name="type">
        /// Trigger type discriminator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageObjectCreatedTrigger(
            string triggerId,
            string functionSlug,
            string name,
            string functionPath,
            global::Neon.FunctionTriggerStorageObjectCreated storageObjectCreated,
            bool enabled,
            long version,
            string sourceBranchId,
            bool inherited,
            global::Neon.StorageObjectCreatedTriggerType type)
        {
            this.Type = type;
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
            this.FunctionSlug = functionSlug ?? throw new global::System.ArgumentNullException(nameof(functionSlug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionPath = functionPath ?? throw new global::System.ArgumentNullException(nameof(functionPath));
            this.StorageObjectCreated = storageObjectCreated ?? throw new global::System.ArgumentNullException(nameof(storageObjectCreated));
            this.Enabled = enabled;
            this.Version = version;
            this.SourceBranchId = sourceBranchId ?? throw new global::System.ArgumentNullException(nameof(sourceBranchId));
            this.Inherited = inherited;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObjectCreatedTrigger" /> class.
        /// </summary>
        public StorageObjectCreatedTrigger()
        {
        }

    }
}