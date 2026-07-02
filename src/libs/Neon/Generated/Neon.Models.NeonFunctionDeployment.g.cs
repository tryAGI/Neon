
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonFunctionDeployment
    {
        /// <summary>
        /// The deployment id, which is the platform version number (monotonic per function).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Build lifecycle status of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonFunctionDeploymentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonFunctionDeploymentStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_mib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryMib { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The NAMES of the deployment's environment variables, sorted.<br/>
        /// Values are encrypted at rest and are never returned — they are<br/>
        /// write-only. To change a value, deploy the variable with the new<br/>
        /// value; to remove a variable, deploy it with an empty value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public global::System.Collections.Generic.IList<string>? Environment { get; set; }

        /// <summary>
        /// Human-readable reason the deployment build failed. Present only<br/>
        /// when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunctionDeployment" /> class.
        /// </summary>
        /// <param name="id">
        /// The deployment id, which is the platform version number (monotonic per function).
        /// </param>
        /// <param name="status">
        /// Build lifecycle status of the deployment.
        /// </param>
        /// <param name="memoryMib"></param>
        /// <param name="runtime"></param>
        /// <param name="createdAt"></param>
        /// <param name="environment">
        /// The NAMES of the deployment's environment variables, sorted.<br/>
        /// Values are encrypted at rest and are never returned — they are<br/>
        /// write-only. To change a value, deploy the variable with the new<br/>
        /// value; to remove a variable, deploy it with an empty value.
        /// </param>
        /// <param name="error">
        /// Human-readable reason the deployment build failed. Present only<br/>
        /// when `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonFunctionDeployment(
            int id,
            global::Neon.NeonFunctionDeploymentStatus status,
            int memoryMib,
            string runtime,
            string createdAt,
            global::System.Collections.Generic.IList<string>? environment,
            string? error)
        {
            this.Id = id;
            this.Status = status;
            this.MemoryMib = memoryMib;
            this.Runtime = runtime ?? throw new global::System.ArgumentNullException(nameof(runtime));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Environment = environment;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonFunctionDeployment" /> class.
        /// </summary>
        public NeonFunctionDeployment()
        {
        }

    }
}