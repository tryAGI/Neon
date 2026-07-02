
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDeployRequest
    {
        /// <summary>
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        public byte[]? Zip { get; set; }

        /// <summary>
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipname")]
        public string? Zipname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.FunctionDeployRequestRuntimeJsonConverter))]
        public global::Neon.FunctionDeployRequestRuntime? Runtime { get; set; }

        /// <summary>
        /// Optional JSON object (a string-to-string map) of environment<br/>
        /// variables for the deployment, e.g. {"KEY":"VALUE"}. Carried as a<br/>
        /// JSON-encoded string because multipart form data does not support<br/>
        /// typed object parts.<br/>
        /// Values are write-only: they are encrypted at rest, and responses<br/>
        /// carry only the variable names (the `environment` array), never the<br/>
        /// values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeployRequest" /> class.
        /// </summary>
        /// <param name="zip">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.
        /// </param>
        /// <param name="zipname">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.
        /// </param>
        /// <param name="runtime"></param>
        /// <param name="environment">
        /// Optional JSON object (a string-to-string map) of environment<br/>
        /// variables for the deployment, e.g. {"KEY":"VALUE"}. Carried as a<br/>
        /// JSON-encoded string because multipart form data does not support<br/>
        /// typed object parts.<br/>
        /// Values are write-only: they are encrypted at rest, and responses<br/>
        /// carry only the variable names (the `environment` array), never the<br/>
        /// values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDeployRequest(
            byte[]? zip,
            string? zipname,
            global::Neon.FunctionDeployRequestRuntime? runtime,
            string? environment)
        {
            this.Zip = zip;
            this.Zipname = zipname;
            this.Runtime = runtime;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeployRequest" /> class.
        /// </summary>
        public FunctionDeployRequest()
        {
        }

    }
}