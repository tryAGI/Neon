
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>), TypeInfoPropertyName = "EndpointsResponse_94af327886d2127e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>?), TypeInfoPropertyName = "EndpointsResponse_18e24691ef0e4f53")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AddProjectJWKSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Jwks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectJWKSResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Jwks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorCategory), TypeInfoPropertyName = "AdvisorCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorIssueFacing), TypeInfoPropertyName = "AdvisorIssueFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AdvisorCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Operation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction), TypeInfoPropertyName = "OperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus), TypeInfoPropertyName = "OperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DefaultEndpointSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectSettingsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermissionLevel), TypeInfoPropertyName = "ProjectPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectOwnerData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectCreateRequestProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectCreateRequestProjectBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectUpdateRequestProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectTransferRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AcceptProjectTransferRequestSatisfiesPlanError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectQuota))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllowedIps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MaintenanceWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectAuditLogLevel), TypeInfoPropertyName = "ProjectAuditLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PreloadLibraries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectRecoverResponse), TypeInfoPropertyName = "ProjectRecoverResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GrantPermissionToProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectRole), TypeInfoPropertyName = "ProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberGrantSource), TypeInfoPropertyName = "ProjectMemberGrantSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberOrgRole), TypeInfoPropertyName = "ProjectMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SetProjectMemberRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberRoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AvailablePreloadLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AvailablePreloadLibraries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AvailablePreloadLibrary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Branch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchCreatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchRestrictedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRestrictedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfoDeletionMethod), TypeInfoPropertyName = "BranchRecoveryInfoDeletionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType), TypeInfoPropertyName = "EndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointSettingsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Branch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionURIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState), TypeInfoPropertyName = "EndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode), TypeInfoPropertyName = "EndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionURIsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConnectionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.VPCEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JWKSResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RolesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingSubscriptionType), TypeInfoPropertyName = "BillingSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Database))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JWKSCreationOperation), TypeInfoPropertyName = "JWKSCreationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApplicationType), TypeInfoPropertyName = "ApplicationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsApplicationsMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Neon.ApplicationType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ApplicationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsIntegrationsMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateProjectTransferRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AcceptProjectTransferRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity), TypeInfoPropertyName = "GetProjectAdvisorSecurityIssuesMinSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetProjectAdvisorSecurityIssuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AdvisorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>), TypeInfoPropertyName = "AllOfProjectsResponsePaginationResponseProjectsApplicationsMapResponseProjectsIntegrationsMapResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfProjectsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>), TypeInfoPropertyName = "AllOfProjectResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorCategory?), TypeInfoPropertyName = "NullableAdvisorCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorIssueFacing?), TypeInfoPropertyName = "NullableAdvisorIssueFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction?), TypeInfoPropertyName = "NullableOperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus?), TypeInfoPropertyName = "NullableOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermissionLevel?), TypeInfoPropertyName = "NullableProjectPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectAuditLogLevel?), TypeInfoPropertyName = "NullableProjectAuditLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectRecoverResponse?), TypeInfoPropertyName = "NullableProjectRecoverResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectRole?), TypeInfoPropertyName = "NullableProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberGrantSource?), TypeInfoPropertyName = "NullableProjectMemberGrantSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberOrgRole?), TypeInfoPropertyName = "NullableProjectMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfoDeletionMethod?), TypeInfoPropertyName = "NullableBranchRecoveryInfoDeletionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType?), TypeInfoPropertyName = "NullableEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState?), TypeInfoPropertyName = "NullableEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode?), TypeInfoPropertyName = "NullableEndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingSubscriptionType?), TypeInfoPropertyName = "NullableBillingSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JWKSCreationOperation?), TypeInfoPropertyName = "NullableJWKSCreationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApplicationType?), TypeInfoPropertyName = "NullableApplicationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity?), TypeInfoPropertyName = "NullableGetProjectAdvisorSecurityIssuesMinSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>?), TypeInfoPropertyName = "NullableAllOfProjectsResponsePaginationResponseProjectsApplicationsMapResponseProjectsIntegrationsMapResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>?), TypeInfoPropertyName = "NullableAllOfProjectsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>?), TypeInfoPropertyName = "NullableAllOfProjectResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Jwks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AdvisorCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AvailablePreloadLibrary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchRestrictedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Branch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConnectionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.VPCEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Neon.ApplicationType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ApplicationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AdvisorIssue>))]
    internal sealed partial class ProjectSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Neon.JsonConverters.ProjectRecoverResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.JWKSCreationOperationJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.OperationsResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OperationsResponse, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Neon.AdvisorCategory)

                    || typeToConvert == typeof(global::Neon.AdvisorCategory?)

                    || typeToConvert == typeof(global::Neon.AdvisorIssueFacing)

                    || typeToConvert == typeof(global::Neon.AdvisorIssueFacing?)

                    || typeToConvert == typeof(global::Neon.OperationAction)

                    || typeToConvert == typeof(global::Neon.OperationAction?)

                    || typeToConvert == typeof(global::Neon.OperationStatus)

                    || typeToConvert == typeof(global::Neon.OperationStatus?)

                    || typeToConvert == typeof(global::Neon.ProjectRole)

                    || typeToConvert == typeof(global::Neon.ProjectRole?)

                    || typeToConvert == typeof(global::Neon.ProjectPermissionLevel)

                    || typeToConvert == typeof(global::Neon.ProjectPermissionLevel?)

                    || typeToConvert == typeof(global::Neon.ProjectMemberGrantSource)

                    || typeToConvert == typeof(global::Neon.ProjectMemberGrantSource?)

                    || typeToConvert == typeof(global::Neon.ProjectMemberOrgRole)

                    || typeToConvert == typeof(global::Neon.ProjectMemberOrgRole?)

                    || typeToConvert == typeof(global::Neon.ProjectAuditLogLevel)

                    || typeToConvert == typeof(global::Neon.ProjectAuditLogLevel?)

                    || typeToConvert == typeof(global::Neon.BranchRecoveryInfoDeletionMethod)

                    || typeToConvert == typeof(global::Neon.BranchRecoveryInfoDeletionMethod?)

                    || typeToConvert == typeof(global::Neon.EndpointState)

                    || typeToConvert == typeof(global::Neon.EndpointState?)

                    || typeToConvert == typeof(global::Neon.EndpointType)

                    || typeToConvert == typeof(global::Neon.EndpointType?)

                    || typeToConvert == typeof(global::Neon.EndpointPoolerMode)

                    || typeToConvert == typeof(global::Neon.EndpointPoolerMode?)

                    || typeToConvert == typeof(global::Neon.BillingSubscriptionType)

                    || typeToConvert == typeof(global::Neon.BillingSubscriptionType?)

                    || typeToConvert == typeof(global::Neon.ApplicationType)

                    || typeToConvert == typeof(global::Neon.ApplicationType?)

                    || typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity)

                    || typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Neon.AdvisorCategory))
                {
                    return new global::Neon.JsonConverters.AdvisorCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AdvisorCategory?))
                {
                    return new global::Neon.JsonConverters.AdvisorCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AdvisorIssueFacing))
                {
                    return new global::Neon.JsonConverters.AdvisorIssueFacingJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AdvisorIssueFacing?))
                {
                    return new global::Neon.JsonConverters.AdvisorIssueFacingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.OperationAction))
                {
                    return new global::Neon.JsonConverters.OperationActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.OperationAction?))
                {
                    return new global::Neon.JsonConverters.OperationActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.OperationStatus))
                {
                    return new global::Neon.JsonConverters.OperationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.OperationStatus?))
                {
                    return new global::Neon.JsonConverters.OperationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectRole))
                {
                    return new global::Neon.JsonConverters.ProjectRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectRole?))
                {
                    return new global::Neon.JsonConverters.ProjectRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectPermissionLevel))
                {
                    return new global::Neon.JsonConverters.ProjectPermissionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectPermissionLevel?))
                {
                    return new global::Neon.JsonConverters.ProjectPermissionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectMemberGrantSource))
                {
                    return new global::Neon.JsonConverters.ProjectMemberGrantSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectMemberGrantSource?))
                {
                    return new global::Neon.JsonConverters.ProjectMemberGrantSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectMemberOrgRole))
                {
                    return new global::Neon.JsonConverters.ProjectMemberOrgRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectMemberOrgRole?))
                {
                    return new global::Neon.JsonConverters.ProjectMemberOrgRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectAuditLogLevel))
                {
                    return new global::Neon.JsonConverters.ProjectAuditLogLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectAuditLogLevel?))
                {
                    return new global::Neon.JsonConverters.ProjectAuditLogLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BranchRecoveryInfoDeletionMethod))
                {
                    return new global::Neon.JsonConverters.BranchRecoveryInfoDeletionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BranchRecoveryInfoDeletionMethod?))
                {
                    return new global::Neon.JsonConverters.BranchRecoveryInfoDeletionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.EndpointState))
                {
                    return new global::Neon.JsonConverters.EndpointStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.EndpointState?))
                {
                    return new global::Neon.JsonConverters.EndpointStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.EndpointType))
                {
                    return new global::Neon.JsonConverters.EndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.EndpointType?))
                {
                    return new global::Neon.JsonConverters.EndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.EndpointPoolerMode))
                {
                    return new global::Neon.JsonConverters.EndpointPoolerModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.EndpointPoolerMode?))
                {
                    return new global::Neon.JsonConverters.EndpointPoolerModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingSubscriptionType))
                {
                    return new global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingSubscriptionType?))
                {
                    return new global::Neon.JsonConverters.BillingSubscriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ApplicationType))
                {
                    return new global::Neon.JsonConverters.ApplicationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ApplicationType?))
                {
                    return new global::Neon.JsonConverters.ApplicationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity))
                {
                    return new global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity?))
                {
                    return new global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ProjectSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}