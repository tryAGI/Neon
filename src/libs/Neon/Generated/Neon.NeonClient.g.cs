
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
    public sealed partial class NeonClient : global::Neon.INeonClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://console.neon.tech/api/v2";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Neon.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Neon.JsonConverters.TelemetryConnectionProtocolJsonConverter(),
                    new global::Neon.JsonConverters.TelemetryConnectionProtocolNullableJsonConverter(),
                    new global::Neon.JsonConverters.TelemetryConfigTypeJsonConverter(),
                    new global::Neon.JsonConverters.TelemetryConfigTypeNullableJsonConverter(),
                    new global::Neon.JsonConverters.AdvisorCategoryJsonConverter(),
                    new global::Neon.JsonConverters.AdvisorCategoryNullableJsonConverter(),
                    new global::Neon.JsonConverters.AdvisorIssueFacingJsonConverter(),
                    new global::Neon.JsonConverters.AdvisorIssueFacingNullableJsonConverter(),
                    new global::Neon.JsonConverters.OperationActionJsonConverter(),
                    new global::Neon.JsonConverters.OperationActionNullableJsonConverter(),
                    new global::Neon.JsonConverters.OperationStatusJsonConverter(),
                    new global::Neon.JsonConverters.OperationStatusNullableJsonConverter(),
                    new global::Neon.JsonConverters.ConsumptionHistoryGranularityJsonConverter(),
                    new global::Neon.JsonConverters.ConsumptionHistoryGranularityNullableJsonConverter(),
                    new global::Neon.JsonConverters.ProjectAuditLogLevelJsonConverter(),
                    new global::Neon.JsonConverters.ProjectAuditLogLevelNullableJsonConverter(),
                    new global::Neon.JsonConverters.EndpointStateJsonConverter(),
                    new global::Neon.JsonConverters.EndpointStateNullableJsonConverter(),
                    new global::Neon.JsonConverters.EndpointTypeJsonConverter(),
                    new global::Neon.JsonConverters.EndpointTypeNullableJsonConverter(),
                    new global::Neon.JsonConverters.EndpointPoolerModeJsonConverter(),
                    new global::Neon.JsonConverters.EndpointPoolerModeNullableJsonConverter(),
                    new global::Neon.JsonConverters.PaymentSourceBankCardBrandJsonConverter(),
                    new global::Neon.JsonConverters.PaymentSourceBankCardBrandNullableJsonConverter(),
                    new global::Neon.JsonConverters.BillingAccountStateJsonConverter(),
                    new global::Neon.JsonConverters.BillingAccountStateNullableJsonConverter(),
                    new global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter(),
                    new global::Neon.JsonConverters.BillingSubscriptionTypeNullableJsonConverter(),
                    new global::Neon.JsonConverters.BillingPaymentMethodJsonConverter(),
                    new global::Neon.JsonConverters.BillingPaymentMethodNullableJsonConverter(),
                    new global::Neon.JsonConverters.MemberRoleJsonConverter(),
                    new global::Neon.JsonConverters.MemberRoleNullableJsonConverter(),
                    new global::Neon.JsonConverters.EnableOrganizationFeatureRequestFeatureJsonConverter(),
                    new global::Neon.JsonConverters.EnableOrganizationFeatureRequestFeatureNullableJsonConverter(),
                    new global::Neon.JsonConverters.AuthDetailsResponseAuthMethodJsonConverter(),
                    new global::Neon.JsonConverters.AuthDetailsResponseAuthMethodNullableJsonConverter(),
                    new global::Neon.JsonConverters.IdentityProviderIdJsonConverter(),
                    new global::Neon.JsonConverters.IdentityProviderIdNullableJsonConverter(),
                    new global::Neon.JsonConverters.UserDeletionConditionNameJsonConverter(),
                    new global::Neon.JsonConverters.UserDeletionConditionNameNullableJsonConverter(),
                    new global::Neon.JsonConverters.OrgDeletionConditionNameJsonConverter(),
                    new global::Neon.JsonConverters.OrgDeletionConditionNameNullableJsonConverter(),
                    new global::Neon.JsonConverters.DataAPICreateRequestAuthProviderJsonConverter(),
                    new global::Neon.JsonConverters.DataAPICreateRequestAuthProviderNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthSupportedAuthProviderNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOauthProviderIdJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOauthProviderIdNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOauthProviderTypeJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthOauthProviderTypeNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthEmailVerificationMethodJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthEmailVerificationMethodNullableJsonConverter(),
                    new global::Neon.JsonConverters.SupportTicketSeverityJsonConverter(),
                    new global::Neon.JsonConverters.SupportTicketSeverityNullableJsonConverter(),
                    new global::Neon.JsonConverters.ApplicationTypeJsonConverter(),
                    new global::Neon.JsonConverters.ApplicationTypeNullableJsonConverter(),
                    new global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityJsonConverter(),
                    new global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityNullableJsonConverter(),
                    new global::Neon.JsonConverters.ListProjectBranchesSortByJsonConverter(),
                    new global::Neon.JsonConverters.ListProjectBranchesSortByNullableJsonConverter(),
                    new global::Neon.JsonConverters.ListProjectBranchesSortOrderJsonConverter(),
                    new global::Neon.JsonConverters.ListProjectBranchesSortOrderNullableJsonConverter(),
                    new global::Neon.JsonConverters.GetOrganizationMembersSortByJsonConverter(),
                    new global::Neon.JsonConverters.GetOrganizationMembersSortByNullableJsonConverter(),
                    new global::Neon.JsonConverters.GetOrganizationMembersSortOrderJsonConverter(),
                    new global::Neon.JsonConverters.GetOrganizationMembersSortOrderNullableJsonConverter(),
                    new global::Neon.JsonConverters.OrgApiKeyCreateRequestJsonConverter(),
                    new global::Neon.JsonConverters.OrgApiKeyCreateResponseJsonConverter(),
                    new global::Neon.JsonConverters.OrgApiKeyRevokeResponseJsonConverter(),
                    new global::Neon.JsonConverters.OrgApiKeysListResponseItemJsonConverter(),
                    new global::Neon.JsonConverters.ProjectRecoverResponseJsonConverter(),
                    new global::Neon.JsonConverters.BranchAnonymizedCreateRequestJsonConverter(),
                    new global::Neon.JsonConverters.VPCEndpointWithRegionJsonConverter(),
                    new global::Neon.JsonConverters.NeonAuthEmailServerConfigJsonConverter(),
                    new global::Neon.JsonConverters.SendNeonAuthTestEmailRequestJsonConverter(),
                    new global::Neon.JsonConverters.BranchOperationsJsonConverter(),
                    new global::Neon.JsonConverters.EndpointOperationsJsonConverter(),
                    new global::Neon.JsonConverters.DatabaseOperationsJsonConverter(),
                    new global::Neon.JsonConverters.RoleOperationsJsonConverter(),
                    new global::Neon.JsonConverters.JWKSCreationOperationJsonConverter(),
                    new global::Neon.JsonConverters.OneOfJsonConverter<bool?, string>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.OperationsResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OperationsResponse, global::Neon.PaginationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.AnnotationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>(),
                    new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>(),
                    new global::Neon.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// These methods allow you to create and manage API keys for your Neon account. For related information, see [Manage API keys](https://neon.tech/docs/manage/api-keys).
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to create and manage Neon Auth projects.
        /// </summary>
        public AuthClient Auth => new AuthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to create and manage Neon Auth projects. Deprecated. See routes with the `Auth` tag instead.
        /// </summary>
        public AuthLegacyClient AuthLegacy => new AuthLegacyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to create and manage branches in your Neon project. For related information, see [Manage branches](https://neon.tech/docs/manage/branches).
        /// </summary>
        public BranchClient Branch => new BranchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to view consumption details for your Neon account.
        /// </summary>
        public ConsumptionClient Consumption => new ConsumptionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataAPIClient DataAPI => new DataAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to create and manage compute endpoints in your Neon project. For related information, see [Manage compute endpoints](https://neon.tech/docs/manage/endpoints).
        /// </summary>
        public EndpointClient Endpoint => new EndpointClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to view operation details for your Neon project. For related information, see [Operations](https://neon.tech/docs/manage/operations).
        /// </summary>
        public OperationClient Operation => new OperationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to manage your Neon organizations.
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to create and manage Neon projects. For related information, see [Manage projects](https://neon.tech/docs/manage/projects).
        /// </summary>
        public ProjectClient Project => new ProjectClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to inspect Neon regions.
        /// </summary>
        public RegionClient Region => new RegionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to create and manage snapshots.
        /// </summary>
        public SnapshotClient Snapshot => new SnapshotClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These methods allow you to manage your Neon user account.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the NeonClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public NeonClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Neon.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Neon.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}