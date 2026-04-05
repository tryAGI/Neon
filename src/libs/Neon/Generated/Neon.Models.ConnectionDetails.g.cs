
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectionDetails
    {
        /// <summary>
        /// The connection URI is defined as specified here: [Connection URIs](https://www.postgresql.org/docs/current/libpq-connect.html#LIBPQ-CONNSTRING-URIS)<br/>
        /// The connection URI can be used to connect to a Postgres database with psql or defined in a DATABASE_URL environment variable.<br/>
        /// When creating a branch from a parent with more than one role or database, the response body does not include a connection URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ConnectionParameters ConnectionParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionDetails" /> class.
        /// </summary>
        /// <param name="connectionUri">
        /// The connection URI is defined as specified here: [Connection URIs](https://www.postgresql.org/docs/current/libpq-connect.html#LIBPQ-CONNSTRING-URIS)<br/>
        /// The connection URI can be used to connect to a Postgres database with psql or defined in a DATABASE_URL environment variable.<br/>
        /// When creating a branch from a parent with more than one role or database, the response body does not include a connection URI.
        /// </param>
        /// <param name="connectionParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionDetails(
            string connectionUri,
            global::Neon.ConnectionParameters connectionParameters)
        {
            this.ConnectionUri = connectionUri ?? throw new global::System.ArgumentNullException(nameof(connectionUri));
            this.ConnectionParameters = connectionParameters ?? throw new global::System.ArgumentNullException(nameof(connectionParameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionDetails" /> class.
        /// </summary>
        public ConnectionDetails()
        {
        }
    }
}