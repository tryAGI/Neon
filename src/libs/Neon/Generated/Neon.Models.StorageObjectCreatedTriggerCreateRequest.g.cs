
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageObjectCreatedTriggerCreateRequest
    {
        /// <summary>
        /// Trigger type discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.StorageObjectCreatedTriggerCreateRequestTypeJsonConverter))]
        public global::Neon.StorageObjectCreatedTriggerCreateRequestType Type { get; set; }

        /// <summary>
        /// The branch-local Function slug to invoke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionSlug { get; set; }

        /// <summary>
        /// Human-readable name, unique among triggers visible on the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Path passed to the target Function. Defaults to `/`.<br/>
        /// Default Value: /
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.FunctionTriggerStorageObjectCreated StorageObjectCreated { get; set; }

        /// <summary>
        /// Whether successful matching uploads should invoke the Function.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObjectCreatedTriggerCreateRequest" /> class.
        /// </summary>
        /// <param name="functionSlug">
        /// The branch-local Function slug to invoke.
        /// </param>
        /// <param name="name">
        /// Human-readable name, unique among triggers visible on the branch.
        /// </param>
        /// <param name="storageObjectCreated">
        /// Matches successful uploads to one exact bucket and, when configured, an<br/>
        /// object-key prefix. The Function receives a JSON request body with<br/>
        /// `type` set to `storage_object_created` and a `data` object containing<br/>
        /// exactly `bucket_name` and `object_key`.
        /// </param>
        /// <param name="type">
        /// Trigger type discriminator.
        /// </param>
        /// <param name="functionPath">
        /// Path passed to the target Function. Defaults to `/`.<br/>
        /// Default Value: /
        /// </param>
        /// <param name="enabled">
        /// Whether successful matching uploads should invoke the Function.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageObjectCreatedTriggerCreateRequest(
            string functionSlug,
            string name,
            global::Neon.FunctionTriggerStorageObjectCreated storageObjectCreated,
            global::Neon.StorageObjectCreatedTriggerCreateRequestType type,
            string? functionPath,
            bool? enabled)
        {
            this.Type = type;
            this.FunctionSlug = functionSlug ?? throw new global::System.ArgumentNullException(nameof(functionSlug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionPath = functionPath;
            this.StorageObjectCreated = storageObjectCreated ?? throw new global::System.ArgumentNullException(nameof(storageObjectCreated));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageObjectCreatedTriggerCreateRequest" /> class.
        /// </summary>
        public StorageObjectCreatedTriggerCreateRequest()
        {
        }

    }
}