
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
            typeof(global::Neon.JsonConverters.TelemetryConnectionProtocolJsonConverter),

            typeof(global::Neon.JsonConverters.TelemetryConnectionProtocolNullableJsonConverter),

            typeof(global::Neon.JsonConverters.TelemetryConfigTypeJsonConverter),

            typeof(global::Neon.JsonConverters.TelemetryConfigTypeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.AdvisorCategoryJsonConverter),

            typeof(global::Neon.JsonConverters.AdvisorCategoryNullableJsonConverter),

            typeof(global::Neon.JsonConverters.AdvisorIssueFacingJsonConverter),

            typeof(global::Neon.JsonConverters.AdvisorIssueFacingNullableJsonConverter),

            typeof(global::Neon.JsonConverters.OperationActionJsonConverter),

            typeof(global::Neon.JsonConverters.OperationActionNullableJsonConverter),

            typeof(global::Neon.JsonConverters.OperationStatusJsonConverter),

            typeof(global::Neon.JsonConverters.OperationStatusNullableJsonConverter),

            typeof(global::Neon.JsonConverters.ConsumptionHistoryGranularityJsonConverter),

            typeof(global::Neon.JsonConverters.ConsumptionHistoryGranularityNullableJsonConverter),

            typeof(global::Neon.JsonConverters.ProjectAuditLogLevelJsonConverter),

            typeof(global::Neon.JsonConverters.ProjectAuditLogLevelNullableJsonConverter),

            typeof(global::Neon.JsonConverters.BranchRecoveryInfoDeletionMethodJsonConverter),

            typeof(global::Neon.JsonConverters.BranchRecoveryInfoDeletionMethodNullableJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointStateJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointStateNullableJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointTypeJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointTypeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointPoolerModeJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointPoolerModeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.PaymentSourceBankCardBrandJsonConverter),

            typeof(global::Neon.JsonConverters.PaymentSourceBankCardBrandNullableJsonConverter),

            typeof(global::Neon.JsonConverters.BillingAccountStateJsonConverter),

            typeof(global::Neon.JsonConverters.BillingAccountStateNullableJsonConverter),

            typeof(global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter),

            typeof(global::Neon.JsonConverters.BillingSubscriptionTypeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.BillingPaymentMethodJsonConverter),

            typeof(global::Neon.JsonConverters.BillingPaymentMethodNullableJsonConverter),

            typeof(global::Neon.JsonConverters.MemberRoleJsonConverter),

            typeof(global::Neon.JsonConverters.MemberRoleNullableJsonConverter),

            typeof(global::Neon.JsonConverters.EnableOrganizationFeatureRequestFeatureJsonConverter),

            typeof(global::Neon.JsonConverters.EnableOrganizationFeatureRequestFeatureNullableJsonConverter),

            typeof(global::Neon.JsonConverters.AuthDetailsResponseAuthMethodJsonConverter),

            typeof(global::Neon.JsonConverters.AuthDetailsResponseAuthMethodNullableJsonConverter),

            typeof(global::Neon.JsonConverters.IdentityProviderIdJsonConverter),

            typeof(global::Neon.JsonConverters.IdentityProviderIdNullableJsonConverter),

            typeof(global::Neon.JsonConverters.UserDeletionConditionNameJsonConverter),

            typeof(global::Neon.JsonConverters.UserDeletionConditionNameNullableJsonConverter),

            typeof(global::Neon.JsonConverters.OrgDeletionConditionNameJsonConverter),

            typeof(global::Neon.JsonConverters.OrgDeletionConditionNameNullableJsonConverter),

            typeof(global::Neon.JsonConverters.DataAPICreateRequestAuthProviderJsonConverter),

            typeof(global::Neon.JsonConverters.DataAPICreateRequestAuthProviderNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOauthProviderIdJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOauthProviderIdNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOauthProviderTypeJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthOauthProviderTypeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthEmailVerificationMethodJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthEmailVerificationMethodNullableJsonConverter),

            typeof(global::Neon.JsonConverters.SupportTicketSeverityJsonConverter),

            typeof(global::Neon.JsonConverters.SupportTicketSeverityNullableJsonConverter),

            typeof(global::Neon.JsonConverters.ApplicationTypeJsonConverter),

            typeof(global::Neon.JsonConverters.ApplicationTypeNullableJsonConverter),

            typeof(global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityJsonConverter),

            typeof(global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityNullableJsonConverter),

            typeof(global::Neon.JsonConverters.ListProjectBranchesSortByJsonConverter),

            typeof(global::Neon.JsonConverters.ListProjectBranchesSortByNullableJsonConverter),

            typeof(global::Neon.JsonConverters.ListProjectBranchesSortOrderJsonConverter),

            typeof(global::Neon.JsonConverters.ListProjectBranchesSortOrderNullableJsonConverter),

            typeof(global::Neon.JsonConverters.GetOrganizationMembersSortByJsonConverter),

            typeof(global::Neon.JsonConverters.GetOrganizationMembersSortByNullableJsonConverter),

            typeof(global::Neon.JsonConverters.GetOrganizationMembersSortOrderJsonConverter),

            typeof(global::Neon.JsonConverters.GetOrganizationMembersSortOrderNullableJsonConverter),

            typeof(global::Neon.JsonConverters.OrgApiKeyCreateRequestJsonConverter),

            typeof(global::Neon.JsonConverters.OrgApiKeyCreateResponseJsonConverter),

            typeof(global::Neon.JsonConverters.OrgApiKeyRevokeResponseJsonConverter),

            typeof(global::Neon.JsonConverters.OrgApiKeysListResponseItemJsonConverter),

            typeof(global::Neon.JsonConverters.ProjectRecoverResponseJsonConverter),

            typeof(global::Neon.JsonConverters.BranchAnonymizedCreateRequestJsonConverter),

            typeof(global::Neon.JsonConverters.VPCEndpointWithRegionJsonConverter),

            typeof(global::Neon.JsonConverters.NeonAuthEmailServerConfigJsonConverter),

            typeof(global::Neon.JsonConverters.SendNeonAuthTestEmailRequestJsonConverter),

            typeof(global::Neon.JsonConverters.BranchOperationsJsonConverter),

            typeof(global::Neon.JsonConverters.BranchRecoverResponseJsonConverter),

            typeof(global::Neon.JsonConverters.EndpointOperationsJsonConverter),

            typeof(global::Neon.JsonConverters.DatabaseOperationsJsonConverter),

            typeof(global::Neon.JsonConverters.RoleOperationsJsonConverter),

            typeof(global::Neon.JsonConverters.JWKSCreationOperationJsonConverter),

            typeof(global::Neon.JsonConverters.OneOfJsonConverter<bool?, string>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.OperationsResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OperationsResponse, global::Neon.PaginationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.AnnotationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>),

            typeof(global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>),

            typeof(global::Neon.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FeatureFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OneOf<bool?, string>), TypeInfoPropertyName = "OneOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryConnectionProtocol), TypeInfoPropertyName = "TelemetryConnectionProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryAuthenticationBearerToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryAuthenticationBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryAuthenticationApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.TelemetryConfigType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryConfigType), TypeInfoPropertyName = "TelemetryConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TelemetryResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EmptyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PlanDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PlanVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AddProjectJWKSRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Jwks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectJWKSResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Jwks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorCategory), TypeInfoPropertyName = "AdvisorCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorIssueFacing), TypeInfoPropertyName = "AdvisorIssueFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AdvisorCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApiKeyCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateRequest), TypeInfoPropertyName = "OrgApiKeyCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApiKeyCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateResponse), TypeInfoPropertyName = "OrgApiKeyCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApiKeyRevokeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyRevokeResponse), TypeInfoPropertyName = "OrgApiKeyRevokeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyRevokeResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApiKeysListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApiKeyCreatorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeysListResponseItem), TypeInfoPropertyName = "OrgApiKeysListResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeysListResponseItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Operation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction), TypeInfoPropertyName = "OperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus), TypeInfoPropertyName = "OperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DefaultEndpointSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectSettingsData))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GrantPermissionToProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerAccountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProjectV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerProjectV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProjectV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriodV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerPeriodV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerTimeframe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframeV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerTimeframeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionMetricValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionMetricValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryGranularity), TypeInfoPropertyName = "ConsumptionHistoryGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Limits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsPerProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AvailablePreloadLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AvailablePreloadLibraries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AvailablePreloadLibrary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Branch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchCreatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchRestrictedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRestrictedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfoDeletionMethod), TypeInfoPropertyName = "BranchRecoveryInfoDeletionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchConsumption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchCreateRequestEndpointOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType), TypeInfoPropertyName = "EndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointSettingsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAnonymizedCreateRequest), TypeInfoPropertyName = "BranchAnonymizedCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationCreateValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAnonymizedCreateRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.MaskingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MaskingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchCreateRequestEndpointOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchCreateRequestBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchUpdateRequestBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRestoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchConsumptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Branch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchesCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsBranchesCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Neon.ProjectsBranchesCountResponseProjects2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsBranchesCountResponseProjects2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MaskingRulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MaskingRulesUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnonymizedBranchStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnonymizationRunMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionURIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState), TypeInfoPropertyName = "EndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode), TypeInfoPropertyName = "EndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointCreateRequestEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointUpdateRequestEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionURIsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConnectionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionURIsOptionalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.VPCEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointsWithRegionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.VPCEndpointWithRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointWithRegion), TypeInfoPropertyName = "VPCEndpointWithRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointWithRegionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointsOptionalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPasswordlessSessionAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StatementResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StatementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ExplainData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ExplainData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleCreateRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JWKSResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RolesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RolePasswordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSourceBankCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSourceBankCardBrand), TypeInfoPropertyName = "PaymentSourceBankCardBrand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingAccountState), TypeInfoPropertyName = "BillingAccountState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingSubscriptionType), TypeInfoPropertyName = "BillingSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingPaymentMethod), TypeInfoPropertyName = "BillingPaymentMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SpendingLimitUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SpendingLimitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Database))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseCreateRequestDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseUpdateRequestDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Invitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MemberRole), TypeInfoPropertyName = "MemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Member))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MemberUserInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MemberWithUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EnableOrganizationFeatureRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EnableOrganizationFeatureRequestFeature), TypeInfoPropertyName = "EnableOrganizationFeatureRequestFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationMembershipsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInvitationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Invitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInviteCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInvitesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrganizationInviteCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInviteUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrganizationGuest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationGuest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationMemberUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.MemberWithUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.InvitationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationCreateRequestOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.InvitationCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ActiveRegionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.RegionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RegionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserAuthAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.IdentityProviderId), TypeInfoPropertyName = "IdentityProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LinkedAuthAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateUserInfoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConvertUserToOrgRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserInfoAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.LinkedAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponseAuthMethod), TypeInfoPropertyName = "AuthDetailsResponseAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TransferProjectsToOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VerifyUserPasswordRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.HealthCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponseLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectsWithIntegrationResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UserDeletionConditionName), TypeInfoPropertyName = "UserDeletionConditionName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgDeletionConditionName), TypeInfoPropertyName = "OrgDeletionConditionName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPISettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPICreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPICreateRequestAuthProvider), TypeInfoPropertyName = "DataAPICreateRequestAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPICreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPIReponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPIUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthSupportedAuthProvider), TypeInfoPropertyName = "NeonAuthSupportedAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectOwnedBy), TypeInfoPropertyName = "NeonAuthProviderProjectOwnedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectTransferStatus), TypeInfoPropertyName = "NeonAuthProviderProjectTransferStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthRedirectURIWhitelistDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthRedirectURIWhitelistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthRedirectURIWhitelistDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthAddDomainToRedirectURIWhitelistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EnableNeonAuthIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateAuthProviderSDKKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateNewUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateBranchNeonAuthNewUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthCreateNewUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateNeonAuthUserRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateNeonAuthUserRoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthAllowLocalhostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateNeonAuthAllowLocalhostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole), TypeInfoPropertyName = "NeonAuthOrganizationConfigCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole), TypeInfoPropertyName = "NeonAuthOrganizationConfigUpdateCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthMagicLinkConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthMagicLinkConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPhoneNumberConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthTransferAuthProviderProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthTransferAuthProviderProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListNeonAuthIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListNeonAuthOauthProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPluginConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfig), TypeInfoPropertyName = "NeonAuthEmailServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailAndPasswordConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent), TypeInfoPropertyName = "NeonAuthWebhookConfigEnabledEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderId), TypeInfoPropertyName = "NeonAuthOauthProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderType), TypeInfoPropertyName = "NeonAuthOauthProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthAddOAuthProviderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthUpdateOAuthProviderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SharedEmailServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StandardEmailServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType), TypeInfoPropertyName = "NeonAuthEmailServerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthTestEmailRequest), TypeInfoPropertyName = "SendNeonAuthTestEmailRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthTestEmailRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthTestEmailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailVerificationMethod), TypeInfoPropertyName = "NeonAuthEmailVerificationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailAndPasswordConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchOperations), TypeInfoPropertyName = "BranchOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoverResponse), TypeInfoPropertyName = "BranchRecoverResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointOperations), TypeInfoPropertyName = "EndpointOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseOperations), TypeInfoPropertyName = "DatabaseOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleOperations), TypeInfoPropertyName = "RoleOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JWKSCreationOperation), TypeInfoPropertyName = "JWKSCreationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SupportTicketSeverity), TypeInfoPropertyName = "SupportTicketSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationObjectData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationsMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Neon.AnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApplicationType), TypeInfoPropertyName = "ApplicationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsApplicationsMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Neon.ApplicationType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ApplicationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsIntegrationsMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Snapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SnapshotUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SnapshotUpdateRequestSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BackupScheduleItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BackupSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BackupScheduleItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SupportTicket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableConstraint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableConstraintReferencedTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SystemStatusSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateProjectTransferRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AcceptProjectTransferRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DisableNeonAuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DeleteNeonAuthIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>), TypeInfoPropertyName = "AllOfBranchCreateRequestAnnotationCreateValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FinalizeRestoreBranchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RestoreSnapshotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity), TypeInfoPropertyName = "GetProjectAdvisorSecurityIssuesMinSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortBy), TypeInfoPropertyName = "ListProjectBranchesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortOrder), TypeInfoPropertyName = "ListProjectBranchesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortBy), TypeInfoPropertyName = "GetOrganizationMembersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortOrder), TypeInfoPropertyName = "GetOrganizationMembersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetProjectAdvisorSecurityIssuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AdvisorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>), TypeInfoPropertyName = "AllOfProjectsResponsePaginationResponseProjectsApplicationsMapResponseProjectsIntegrationsMapResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>), TypeInfoPropertyName = "EndpointsResponse_94af327886d2127e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfProjectsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>), TypeInfoPropertyName = "AllOfProjectResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OperationsResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfOperationsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>), TypeInfoPropertyName = "AllOfBranchResponseEndpointsResponseOperationsResponseRolesResponseDatabasesResponseConnectionURIsOptionalResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfBranchesResponseAnnotationsMapResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>), TypeInfoPropertyName = "AllOfBranchResponseAnnotationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfConsumptionHistoryPerProjectResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfConsumptionHistoryPerProjectV2ResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrgApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfOrganizationMembersResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListSnapshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Snapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>), TypeInfoPropertyName = "AllOfBranchResponseEndpointsOptionalResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.TelemetryConfigType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Jwks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AdvisorCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerProjectV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerPeriodV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerTimeframe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerTimeframeV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionMetricValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AvailablePreloadLibrary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchRestrictedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.MaskingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchCreateRequestEndpointOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Branch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConnectionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.VPCEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.VPCEndpointWithRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ExplainData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrganizationMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Invitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrganizationInviteCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrganizationGuest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.MemberWithUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.InvitationCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.RegionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CurrentUserAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.LinkedAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectsWithIntegrationResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthRedirectURIWhitelistDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthOauthProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonAuthWebhookConfigEnabledEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Neon.ApplicationType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ApplicationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BackupScheduleItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchSchemaJSONTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchSchemaJSONTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchSchemaJSONTableConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AdvisorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrgApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Snapshot>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}