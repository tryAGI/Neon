
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageObjectCreatedTriggerUpdateRequest
    {
        /// <summary>
        /// Trigger type discriminator; it does not change the trigger type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.StorageObjectCreatedTriggerUpdateRequestTypeJsonConverter))]
        public global::Neon.StorageObjectCreatedTriggerUpdateRequestType Type { get; set; }

        /// <summary>
        /// Replacement branch-local Function slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_slug")]
        public string? FunctionSlug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_path")]
        public string? FunctionPath { get; set; }

        /// <summary>
        /// Matches successful uploads to one exact bucket and, when configured, an<br/>
        /// object-key prefix. The Function receives a JSON request body with<br/>
        /// `type` set to `storage_object_created` and a `data` object containing<br/>
        /// exactly `bucket_name` and `object_key`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_object_created")]
        public global::Neon.FunctionTriggerStorageObjectCreated? StorageObjectCreated { get; set; }

        /// <summary>
        /// True enables and false disables future matching uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObjectCreatedTriggerUpdateRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Trigger type discriminator; it does not change the trigger type.
        /// </param>
        /// <param name="functionSlug">
        /// Replacement branch-local Function slug.
        /// </param>
        /// <param name="name"></param>
        /// <param name="functionPath"></param>
        /// <param name="storageObjectCreated">
        /// Matches successful uploads to one exact bucket and, when configured, an<br/>
        /// object-key prefix. The Function receives a JSON request body with<br/>
        /// `type` set to `storage_object_created` and a `data` object containing<br/>
        /// exactly `bucket_name` and `object_key`.
        /// </param>
        /// <param name="enabled">
        /// True enables and false disables future matching uploads.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageObjectCreatedTriggerUpdateRequest(
            global::Neon.StorageObjectCreatedTriggerUpdateRequestType type,
            string? functionSlug,
            string? name,
            string? functionPath,
            global::Neon.FunctionTriggerStorageObjectCreated? storageObjectCreated,
            bool? enabled)
        {
            this.Type = type;
            this.FunctionSlug = functionSlug;
            this.Name = name;
            this.FunctionPath = functionPath;
            this.StorageObjectCreated = storageObjectCreated;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObjectCreatedTriggerUpdateRequest" /> class.
        /// </summary>
        public StorageObjectCreatedTriggerUpdateRequest()
        {
        }

    }
}