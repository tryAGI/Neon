
#nullable enable

namespace Neon
{
    /// <summary>
    /// The Neon API allows you to access and manage Neon programmatically. You can use the Neon API to manage API keys, projects, branches, compute endpoints, databases, roles, and operations. For information about these features, refer to the [Neon documentation](https://neon.tech/docs/manage/overview/).<br/>
    /// You can run Neon API requests from this API reference using the **Try It** feature. Enter your API key as a **Bearer** token in the **Authorization** section of the page.<br/>
    /// You can create and manage API keys in the Neon Console. See [Manage API keys](https://neon.tech/docs/manage/api-keys/) for instructions.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface INeonClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Neon.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Neon.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// These methods allow you to create and manage API keys for your Neon account. For related information, see [Manage API keys](https://neon.tech/docs/manage/api-keys).
        /// </summary>
        public ApiKeyClient ApiKey { get; }

        /// <summary>
        /// These methods allow you to create and manage Neon Auth projects.
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// These methods allow you to create and manage Neon Auth projects. Deprecated. See routes with the `Auth` tag instead.
        /// </summary>
        public AuthLegacyClient AuthLegacy { get; }

        /// <summary>
        /// These methods allow you to create and manage branches in your Neon project. For related information, see [Manage branches](https://neon.tech/docs/manage/branches).
        /// </summary>
        public BranchClient Branch { get; }

        /// <summary>
        /// These methods allow you to view consumption details for your Neon account.
        /// </summary>
        public ConsumptionClient Consumption { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataAPIClient DataAPI { get; }

        /// <summary>
        /// These methods allow you to create and manage compute endpoints in your Neon project. For related information, see [Manage compute endpoints](https://neon.tech/docs/manage/endpoints).
        /// </summary>
        public EndpointClient Endpoint { get; }

        /// <summary>
        /// These methods allow you to view operation details for your Neon project. For related information, see [Operations](https://neon.tech/docs/manage/operations).
        /// </summary>
        public OperationClient Operation { get; }

        /// <summary>
        /// These methods allow you to manage your Neon organizations.
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// These methods allow you to create and manage Neon projects. For related information, see [Manage projects](https://neon.tech/docs/manage/projects).
        /// </summary>
        public ProjectClient Project { get; }

        /// <summary>
        /// These methods allow you to inspect Neon regions.
        /// </summary>
        public RegionClient Region { get; }

        /// <summary>
        /// These methods allow you to create and manage snapshots.
        /// </summary>
        public SnapshotClient Snapshot { get; }

        /// <summary>
        /// These methods allow you to manage your Neon user account.
        /// </summary>
        public UsersClient Users { get; }

    }
}