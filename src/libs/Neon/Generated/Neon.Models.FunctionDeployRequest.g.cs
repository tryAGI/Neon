
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
        /// first deployment of a function.<br/>
        /// Place `index.mjs` or `index.js` at the archive root, without a<br/>
        /// containing directory. If both exist, `index.mjs` is loaded. Export a<br/>
        /// request handler function or an object with a `fetch` method. Use<br/>
        /// `export default` for ESM or `module.exports` for CommonJS; prefer<br/>
        /// `index.mjs` for ESM.<br/>
        /// Upload JavaScript ready to run on Node.js 24. Compile TypeScript<br/>
        /// before uploading. Bundle dependencies into the entry module, or<br/>
        /// include the required modules and assets in the archive with their<br/>
        /// relative paths preserved (including `node_modules` for external<br/>
        /// packages). Node.js built-in modules do not need to be bundled.<br/>
        /// The API does not transpile, bundle, or install dependencies.<br/>
        /// The ZIP is limited to 32 MiB compressed and 128 MiB extracted, with<br/>
        /// at most 32,768 entries and 64 MiB per file. Bundle large dependency<br/>
        /// trees to keep the archive small. ZIPs larger than 32 MiB are rejected<br/>
        /// with HTTP 413 before creating a deployment. The extracted-size,<br/>
        /// entry-count, and per-file limits are enforced during the asynchronous<br/>
        /// build; an accepted upload that exceeds them fails the build.<br/>
        /// For example, a self-contained ESM bundle needs only `index.mjs`<br/>
        /// at the ZIP root. The Neon CLI bundles source into this layout by<br/>
        /// default; `neon function deploy --no-bundle` packages a prebuilt<br/>
        /// directory or an entry file named `index.mjs` or `index.js`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        public byte[]? Zip { get; set; }

        /// <summary>
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.<br/>
        /// Place `index.mjs` or `index.js` at the archive root, without a<br/>
        /// containing directory. If both exist, `index.mjs` is loaded. Export a<br/>
        /// request handler function or an object with a `fetch` method. Use<br/>
        /// `export default` for ESM or `module.exports` for CommonJS; prefer<br/>
        /// `index.mjs` for ESM.<br/>
        /// Upload JavaScript ready to run on Node.js 24. Compile TypeScript<br/>
        /// before uploading. Bundle dependencies into the entry module, or<br/>
        /// include the required modules and assets in the archive with their<br/>
        /// relative paths preserved (including `node_modules` for external<br/>
        /// packages). Node.js built-in modules do not need to be bundled.<br/>
        /// The API does not transpile, bundle, or install dependencies.<br/>
        /// The ZIP is limited to 32 MiB compressed and 128 MiB extracted, with<br/>
        /// at most 32,768 entries and 64 MiB per file. Bundle large dependency<br/>
        /// trees to keep the archive small. ZIPs larger than 32 MiB are rejected<br/>
        /// with HTTP 413 before creating a deployment. The extracted-size,<br/>
        /// entry-count, and per-file limits are enforced during the asynchronous<br/>
        /// build; an accepted upload that exceeds them fails the build.<br/>
        /// For example, a self-contained ESM bundle needs only `index.mjs`<br/>
        /// at the ZIP root. The Neon CLI bundles source into this layout by<br/>
        /// default; `neon function deploy --no-bundle` packages a prebuilt<br/>
        /// directory or an entry file named `index.mjs` or `index.js`.
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
        /// first deployment of a function.<br/>
        /// Place `index.mjs` or `index.js` at the archive root, without a<br/>
        /// containing directory. If both exist, `index.mjs` is loaded. Export a<br/>
        /// request handler function or an object with a `fetch` method. Use<br/>
        /// `export default` for ESM or `module.exports` for CommonJS; prefer<br/>
        /// `index.mjs` for ESM.<br/>
        /// Upload JavaScript ready to run on Node.js 24. Compile TypeScript<br/>
        /// before uploading. Bundle dependencies into the entry module, or<br/>
        /// include the required modules and assets in the archive with their<br/>
        /// relative paths preserved (including `node_modules` for external<br/>
        /// packages). Node.js built-in modules do not need to be bundled.<br/>
        /// The API does not transpile, bundle, or install dependencies.<br/>
        /// The ZIP is limited to 32 MiB compressed and 128 MiB extracted, with<br/>
        /// at most 32,768 entries and 64 MiB per file. Bundle large dependency<br/>
        /// trees to keep the archive small. ZIPs larger than 32 MiB are rejected<br/>
        /// with HTTP 413 before creating a deployment. The extracted-size,<br/>
        /// entry-count, and per-file limits are enforced during the asynchronous<br/>
        /// build; an accepted upload that exceeds them fails the build.<br/>
        /// For example, a self-contained ESM bundle needs only `index.mjs`<br/>
        /// at the ZIP root. The Neon CLI bundles source into this layout by<br/>
        /// default; `neon function deploy --no-bundle` packages a prebuilt<br/>
        /// directory or an entry file named `index.mjs` or `index.js`.
        /// </param>
        /// <param name="zipname">
        /// Optional ZIP archive of the function source code. Omit to reuse the<br/>
        /// latest version's bundle (a config-only change). Required for the<br/>
        /// first deployment of a function.<br/>
        /// Place `index.mjs` or `index.js` at the archive root, without a<br/>
        /// containing directory. If both exist, `index.mjs` is loaded. Export a<br/>
        /// request handler function or an object with a `fetch` method. Use<br/>
        /// `export default` for ESM or `module.exports` for CommonJS; prefer<br/>
        /// `index.mjs` for ESM.<br/>
        /// Upload JavaScript ready to run on Node.js 24. Compile TypeScript<br/>
        /// before uploading. Bundle dependencies into the entry module, or<br/>
        /// include the required modules and assets in the archive with their<br/>
        /// relative paths preserved (including `node_modules` for external<br/>
        /// packages). Node.js built-in modules do not need to be bundled.<br/>
        /// The API does not transpile, bundle, or install dependencies.<br/>
        /// The ZIP is limited to 32 MiB compressed and 128 MiB extracted, with<br/>
        /// at most 32,768 entries and 64 MiB per file. Bundle large dependency<br/>
        /// trees to keep the archive small. ZIPs larger than 32 MiB are rejected<br/>
        /// with HTTP 413 before creating a deployment. The extracted-size,<br/>
        /// entry-count, and per-file limits are enforced during the asynchronous<br/>
        /// build; an accepted upload that exceeds them fails the build.<br/>
        /// For example, a self-contained ESM bundle needs only `index.mjs`<br/>
        /// at the ZIP root. The Neon CLI bundles source into this layout by<br/>
        /// default; `neon function deploy --no-bundle` packages a prebuilt<br/>
        /// directory or an entry file named `index.mjs` or `index.js`.
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