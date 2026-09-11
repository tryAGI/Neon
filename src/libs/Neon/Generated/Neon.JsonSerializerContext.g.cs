
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>?), TypeInfoPropertyName = "ConnectionURIsOptionalResponse_dba8030245622754")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EmptyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PlanDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PlanVersion))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProjectV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerProjectV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerProjectV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriodV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerPeriodV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerBranchV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerBranchV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerBranchV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerTimeframe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframeV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryPerTimeframeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConsumptionMetricValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionMetricValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryGranularity), TypeInfoPropertyName = "ConsumptionHistoryGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AvailablePreloadLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AvailablePreloadLibraries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.AvailablePreloadLibrary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Branch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchCreatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchRestrictedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRestrictedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfoDeletionMethod), TypeInfoPropertyName = "BranchRecoveryInfoDeletionMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Branch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchesCountResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInvitationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Invitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInviteCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationInvitesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrganizationInviteCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationMemberUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrganizationMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.MemberWithUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ActiveRegionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.RegionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RegionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserAuthAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.IdentityProviderId), TypeInfoPropertyName = "IdentityProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CurrentUserInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CurrentUserAuthAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponseAuthMethod), TypeInfoPropertyName = "AuthDetailsResponseAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TransferProjectsToOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponseLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectsWithIntegrationResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponseProject))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPhoneNumberConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthTransferAuthProviderProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthTransferAuthProviderProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListNeonAuthIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListNeonAuthOauthProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthPluginConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponse), TypeInfoPropertyName = "NeonAuthEmailServerConfigResponse2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StandardEmailServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfig), TypeInfoPropertyName = "NeonAuthEmailServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType), TypeInfoPropertyName = "NeonAuthEmailServerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType), TypeInfoPropertyName = "NeonAuthEmailServerConfigResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthTestEmailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SendNeonAuthEmailProviderTestRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Snapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SnapshotUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SnapshotUpdateRequestSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BackupScheduleItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BackupSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BackupScheduleItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableConstraint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableConstraintReferencedTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketAccessLevel), TypeInfoPropertyName = "BucketAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Bucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketCreateRequestAccessLevel), TypeInfoPropertyName = "BucketCreateRequestAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Bucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchStorageNotEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchStorageNotEnabledReason), TypeInfoPropertyName = "BranchStorageNotEnabledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogSource), TypeInfoPropertyName = "ProjectBranchLogSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogSeverity), TypeInfoPropertyName = "ProjectBranchLogSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsNotAvailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsNotAvailableReason), TypeInfoPropertyName = "ProjectBranchLogsNotAvailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsInvalidQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsInvalidQueryReason), TypeInfoPropertyName = "ProjectBranchLogsInvalidQueryReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder), TypeInfoPropertyName = "ProjectBranchLogsQueryRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectBranchLogRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogFieldsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogFieldValuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAiGateway))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAiGatewayNotEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAiGatewayNotEnabledReason), TypeInfoPropertyName = "BranchAiGatewayNotEnabledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketObjectsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BucketObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketObjectsDeletePrefixResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PresignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PresignRequestOperation), TypeInfoPropertyName = "PresignRequestOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PresignResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialScope), TypeInfoPropertyName = "CredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GrantedCredentialScope), TypeInfoPropertyName = "GrantedCredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialRequestPrincipalType), TypeInfoPropertyName = "CreateCredentialRequestPrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.GrantedCredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RotateCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RotateCredentialResponsePrincipalType), TypeInfoPropertyName = "RotateCredentialResponsePrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CredentialMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionDeploymentStatus), TypeInfoPropertyName = "NeonFunctionDeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.NeonFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FunctionTriggerSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FunctionTriggerStorageObjectCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerCreateRequest), TypeInfoPropertyName = "TriggerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerCreateRequestDiscriminatorType), TypeInfoPropertyName = "TriggerCreateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerCreateRequestType), TypeInfoPropertyName = "ScheduleTriggerCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerCreateRequestType), TypeInfoPropertyName = "StorageObjectCreatedTriggerCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerUpdateRequest), TypeInfoPropertyName = "TriggerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerUpdateRequestDiscriminatorType), TypeInfoPropertyName = "TriggerUpdateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerUpdateRequestType), TypeInfoPropertyName = "ScheduleTriggerUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequestType), TypeInfoPropertyName = "StorageObjectCreatedTriggerUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Trigger), TypeInfoPropertyName = "Trigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerDiscriminatorType), TypeInfoPropertyName = "TriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerType), TypeInfoPropertyName = "ScheduleTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerType), TypeInfoPropertyName = "StorageObjectCreatedTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Trigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CustomDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CustomDomainRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CustomDomainsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.CustomDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionDeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FunctionDeployRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FunctionDeployRequestRuntime), TypeInfoPropertyName = "FunctionDeployRequestRuntime2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfProjectsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>), TypeInfoPropertyName = "AllOfProjectResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OperationsResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfOperationsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>), TypeInfoPropertyName = "AllOfBranchResponseEndpointsResponseOperationsResponseRolesResponseDatabasesResponseConnectionURIsOptionalResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfBranchesResponseAnnotationsMapResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>), TypeInfoPropertyName = "AllOfBranchResponseAnnotationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfConsumptionHistoryPerProjectResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfConsumptionHistoryPerProjectV2ResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerBranchV2Response, global::Neon.PaginationResponse>), TypeInfoPropertyName = "AllOfConsumptionHistoryPerBranchV2ResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrgApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfOrganizationMembersResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListSnapshotsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Snapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.UpdateSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>), TypeInfoPropertyName = "AllOfBranchResponseEndpointsOptionalResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.NeonFunctionsListResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfNeonFunctionsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfCustomDomainsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorCategory?), TypeInfoPropertyName = "NullableAdvisorCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AdvisorIssueFacing?), TypeInfoPropertyName = "NullableAdvisorIssueFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateRequest?), TypeInfoPropertyName = "NullableOrgApiKeyCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateResponse?), TypeInfoPropertyName = "NullableOrgApiKeyCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyRevokeResponse?), TypeInfoPropertyName = "NullableOrgApiKeyRevokeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeysListResponseItem?), TypeInfoPropertyName = "NullableOrgApiKeysListResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction?), TypeInfoPropertyName = "NullableOperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus?), TypeInfoPropertyName = "NullableOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectPermissionLevel?), TypeInfoPropertyName = "NullableProjectPermissionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectAuditLogLevel?), TypeInfoPropertyName = "NullableProjectAuditLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectRecoverResponse?), TypeInfoPropertyName = "NullableProjectRecoverResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectRole?), TypeInfoPropertyName = "NullableProjectRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberGrantSource?), TypeInfoPropertyName = "NullableProjectMemberGrantSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectMemberOrgRole?), TypeInfoPropertyName = "NullableProjectMemberOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConsumptionHistoryGranularity?), TypeInfoPropertyName = "NullableConsumptionHistoryGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfoDeletionMethod?), TypeInfoPropertyName = "NullableBranchRecoveryInfoDeletionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType?), TypeInfoPropertyName = "NullableEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAnonymizedCreateRequest?), TypeInfoPropertyName = "NullableBranchAnonymizedCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState?), TypeInfoPropertyName = "NullableEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode?), TypeInfoPropertyName = "NullableEndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointWithRegion?), TypeInfoPropertyName = "NullableVPCEndpointWithRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PaymentSourceBankCardBrand?), TypeInfoPropertyName = "NullablePaymentSourceBankCardBrand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingAccountState?), TypeInfoPropertyName = "NullableBillingAccountState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingSubscriptionType?), TypeInfoPropertyName = "NullableBillingSubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BillingPaymentMethod?), TypeInfoPropertyName = "NullableBillingPaymentMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MemberRole?), TypeInfoPropertyName = "NullableMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.IdentityProviderId?), TypeInfoPropertyName = "NullableIdentityProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AuthDetailsResponseAuthMethod?), TypeInfoPropertyName = "NullableAuthDetailsResponseAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DataAPICreateRequestAuthProvider?), TypeInfoPropertyName = "NullableDataAPICreateRequestAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthSupportedAuthProvider?), TypeInfoPropertyName = "NullableNeonAuthSupportedAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectOwnedBy?), TypeInfoPropertyName = "NullableNeonAuthProviderProjectOwnedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthProviderProjectTransferStatus?), TypeInfoPropertyName = "NullableNeonAuthProviderProjectTransferStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole?), TypeInfoPropertyName = "NullableNeonAuthOrganizationConfigCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole?), TypeInfoPropertyName = "NullableNeonAuthOrganizationConfigUpdateCreatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponse?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent?), TypeInfoPropertyName = "NullableNeonAuthWebhookConfigEnabledEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderId?), TypeInfoPropertyName = "NullableNeonAuthOauthProviderId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthOauthProviderType?), TypeInfoPropertyName = "NullableNeonAuthOauthProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfig?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType?), TypeInfoPropertyName = "NullableNeonAuthEmailServerConfigResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonAuthEmailVerificationMethod?), TypeInfoPropertyName = "NullableNeonAuthEmailVerificationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchOperations?), TypeInfoPropertyName = "NullableBranchOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoverResponse?), TypeInfoPropertyName = "NullableBranchRecoverResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointOperations?), TypeInfoPropertyName = "NullableEndpointOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseOperations?), TypeInfoPropertyName = "NullableDatabaseOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleOperations?), TypeInfoPropertyName = "NullableRoleOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.JWKSCreationOperation?), TypeInfoPropertyName = "NullableJWKSCreationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ApplicationType?), TypeInfoPropertyName = "NullableApplicationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketAccessLevel?), TypeInfoPropertyName = "NullableBucketAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BucketCreateRequestAccessLevel?), TypeInfoPropertyName = "NullableBucketCreateRequestAccessLevel2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>?), TypeInfoPropertyName = "ConnectionURIsOptionalResponse_dba8030245622754")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchStorageNotEnabledReason?), TypeInfoPropertyName = "NullableBranchStorageNotEnabledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogSource?), TypeInfoPropertyName = "NullableProjectBranchLogSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogSeverity?), TypeInfoPropertyName = "NullableProjectBranchLogSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsNotAvailableReason?), TypeInfoPropertyName = "NullableProjectBranchLogsNotAvailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsInvalidQueryReason?), TypeInfoPropertyName = "NullableProjectBranchLogsInvalidQueryReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder?), TypeInfoPropertyName = "NullableProjectBranchLogsQueryRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAiGatewayNotEnabledReason?), TypeInfoPropertyName = "NullableBranchAiGatewayNotEnabledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PresignRequestOperation?), TypeInfoPropertyName = "NullablePresignRequestOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CredentialScope?), TypeInfoPropertyName = "NullableCredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GrantedCredentialScope?), TypeInfoPropertyName = "NullableGrantedCredentialScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CreateCredentialRequestPrincipalType?), TypeInfoPropertyName = "NullableCreateCredentialRequestPrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RotateCredentialResponsePrincipalType?), TypeInfoPropertyName = "NullableRotateCredentialResponsePrincipalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.NeonFunctionDeploymentStatus?), TypeInfoPropertyName = "NullableNeonFunctionDeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerCreateRequest?), TypeInfoPropertyName = "NullableTriggerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerCreateRequestDiscriminatorType?), TypeInfoPropertyName = "NullableTriggerCreateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerCreateRequestType?), TypeInfoPropertyName = "NullableScheduleTriggerCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerCreateRequestType?), TypeInfoPropertyName = "NullableStorageObjectCreatedTriggerCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerUpdateRequest?), TypeInfoPropertyName = "NullableTriggerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerUpdateRequestDiscriminatorType?), TypeInfoPropertyName = "NullableTriggerUpdateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerUpdateRequestType?), TypeInfoPropertyName = "NullableScheduleTriggerUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequestType?), TypeInfoPropertyName = "NullableStorageObjectCreatedTriggerUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Trigger?), TypeInfoPropertyName = "NullableTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TriggerDiscriminatorType?), TypeInfoPropertyName = "NullableTriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ScheduleTriggerType?), TypeInfoPropertyName = "NullableScheduleTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.StorageObjectCreatedTriggerType?), TypeInfoPropertyName = "NullableStorageObjectCreatedTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FunctionDeployRequestRuntime?), TypeInfoPropertyName = "NullableFunctionDeployRequestRuntime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>?), TypeInfoPropertyName = "NullableAllOfBranchCreateRequestAnnotationCreateValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity?), TypeInfoPropertyName = "NullableGetProjectAdvisorSecurityIssuesMinSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortBy?), TypeInfoPropertyName = "NullableListProjectBranchesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortOrder?), TypeInfoPropertyName = "NullableListProjectBranchesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortBy?), TypeInfoPropertyName = "NullableGetOrganizationMembersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortOrder?), TypeInfoPropertyName = "NullableGetOrganizationMembersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>?), TypeInfoPropertyName = "NullableAllOfProjectsResponsePaginationResponseProjectsApplicationsMapResponseProjectsIntegrationsMapResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>?), TypeInfoPropertyName = "NullableAllOfProjectsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>?), TypeInfoPropertyName = "NullableAllOfProjectResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OperationsResponse, global::Neon.PaginationResponse>?), TypeInfoPropertyName = "NullableAllOfOperationsResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfBranchesResponseAnnotationsMapResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>?), TypeInfoPropertyName = "NullableAllOfBranchResponseAnnotationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>?), TypeInfoPropertyName = "NullableAllOfConsumptionHistoryPerProjectResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>?), TypeInfoPropertyName = "NullableAllOfConsumptionHistoryPerProjectV2ResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.ConsumptionHistoryPerBranchV2Response, global::Neon.PaginationResponse>?), TypeInfoPropertyName = "NullableAllOfConsumptionHistoryPerBranchV2ResponsePaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfOrganizationMembersResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>?), TypeInfoPropertyName = "NullableAllOfBranchResponseEndpointsOptionalResponseOperationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.NeonFunctionsListResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfNeonFunctionsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfCustomDomainsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Jwks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AdvisorCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AcceptProjectTransferRequestSatisfiesPlanErrorReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerProjectV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerPeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerPeriodV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConsumptionHistoryPerBranchV2>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Invitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrganizationInviteCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.MemberWithUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.RegionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CurrentUserAuthAccount>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Bucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectBranchLogRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BucketObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.GrantedCredentialScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CredentialMeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Trigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CustomDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.AdvisorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrgApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Snapshot>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeyCreateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeyCreateResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeyRevokeResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeysListResponseItemJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.ProjectRecoverResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.BranchAnonymizedCreateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.VPCEndpointWithRegionJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.NeonAuthEmailServerConfigJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.NeonAuthEmailServerConfigResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.BranchOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.BranchRecoverResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.EndpointOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.DatabaseOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.RoleOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.JWKSCreationOperationJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.TriggerCreateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.TriggerUpdateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.TriggerJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ProjectResponse, global::Neon.OperationsResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OperationsResponse, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.AnnotationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.ConsumptionHistoryPerBranchV2Response, global::Neon.PaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.NeonFunctionsListResponse, global::Neon.CursorPaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>());
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

                    || typeToConvert == typeof(global::Neon.ConsumptionHistoryGranularity)

                    || typeToConvert == typeof(global::Neon.ConsumptionHistoryGranularity?)

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

                    || typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand)

                    || typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand?)

                    || typeToConvert == typeof(global::Neon.BillingAccountState)

                    || typeToConvert == typeof(global::Neon.BillingAccountState?)

                    || typeToConvert == typeof(global::Neon.BillingSubscriptionType)

                    || typeToConvert == typeof(global::Neon.BillingSubscriptionType?)

                    || typeToConvert == typeof(global::Neon.BillingPaymentMethod)

                    || typeToConvert == typeof(global::Neon.BillingPaymentMethod?)

                    || typeToConvert == typeof(global::Neon.MemberRole)

                    || typeToConvert == typeof(global::Neon.MemberRole?)

                    || typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod)

                    || typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod?)

                    || typeToConvert == typeof(global::Neon.IdentityProviderId)

                    || typeToConvert == typeof(global::Neon.IdentityProviderId?)

                    || typeToConvert == typeof(global::Neon.DataAPICreateRequestAuthProvider)

                    || typeToConvert == typeof(global::Neon.DataAPICreateRequestAuthProvider?)

                    || typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider)

                    || typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider?)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy?)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus)

                    || typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole)

                    || typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole?)

                    || typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent)

                    || typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId?)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType)

                    || typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType?)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod)

                    || typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod?)

                    || typeToConvert == typeof(global::Neon.ApplicationType)

                    || typeToConvert == typeof(global::Neon.ApplicationType?)

                    || typeToConvert == typeof(global::Neon.BucketAccessLevel)

                    || typeToConvert == typeof(global::Neon.BucketAccessLevel?)

                    || typeToConvert == typeof(global::Neon.BucketCreateRequestAccessLevel)

                    || typeToConvert == typeof(global::Neon.BucketCreateRequestAccessLevel?)

                    || typeToConvert == typeof(global::Neon.BranchStorageNotEnabledReason)

                    || typeToConvert == typeof(global::Neon.BranchStorageNotEnabledReason?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSource)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSource?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSeverity)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSeverity?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsNotAvailableReason)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsNotAvailableReason?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsInvalidQueryReason)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsInvalidQueryReason?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder?)

                    || typeToConvert == typeof(global::Neon.BranchAiGatewayNotEnabledReason)

                    || typeToConvert == typeof(global::Neon.BranchAiGatewayNotEnabledReason?)

                    || typeToConvert == typeof(global::Neon.PresignRequestOperation)

                    || typeToConvert == typeof(global::Neon.PresignRequestOperation?)

                    || typeToConvert == typeof(global::Neon.CredentialScope)

                    || typeToConvert == typeof(global::Neon.CredentialScope?)

                    || typeToConvert == typeof(global::Neon.GrantedCredentialScope)

                    || typeToConvert == typeof(global::Neon.GrantedCredentialScope?)

                    || typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType)

                    || typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType?)

                    || typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType)

                    || typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType?)

                    || typeToConvert == typeof(global::Neon.NeonFunctionDeploymentStatus)

                    || typeToConvert == typeof(global::Neon.NeonFunctionDeploymentStatus?)

                    || typeToConvert == typeof(global::Neon.TriggerCreateRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.TriggerCreateRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.ScheduleTriggerCreateRequestType)

                    || typeToConvert == typeof(global::Neon.ScheduleTriggerCreateRequestType?)

                    || typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerCreateRequestType)

                    || typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerCreateRequestType?)

                    || typeToConvert == typeof(global::Neon.TriggerUpdateRequestDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.TriggerUpdateRequestDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.ScheduleTriggerUpdateRequestType)

                    || typeToConvert == typeof(global::Neon.ScheduleTriggerUpdateRequestType?)

                    || typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequestType)

                    || typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequestType?)

                    || typeToConvert == typeof(global::Neon.TriggerDiscriminatorType)

                    || typeToConvert == typeof(global::Neon.TriggerDiscriminatorType?)

                    || typeToConvert == typeof(global::Neon.ScheduleTriggerType)

                    || typeToConvert == typeof(global::Neon.ScheduleTriggerType?)

                    || typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerType)

                    || typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerType?)

                    || typeToConvert == typeof(global::Neon.FunctionDeployRequestRuntime)

                    || typeToConvert == typeof(global::Neon.FunctionDeployRequestRuntime?)

                    || typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity)

                    || typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity?)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortBy)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortBy?)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortOrder)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortOrder?)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortBy)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortBy?)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortOrder)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortOrder?);
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

                if (typeToConvert == typeof(global::Neon.ConsumptionHistoryGranularity))
                {
                    return new global::Neon.JsonConverters.ConsumptionHistoryGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ConsumptionHistoryGranularity?))
                {
                    return new global::Neon.JsonConverters.ConsumptionHistoryGranularityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand))
                {
                    return new global::Neon.JsonConverters.PaymentSourceBankCardBrandJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.PaymentSourceBankCardBrand?))
                {
                    return new global::Neon.JsonConverters.PaymentSourceBankCardBrandNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingAccountState))
                {
                    return new global::Neon.JsonConverters.BillingAccountStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingAccountState?))
                {
                    return new global::Neon.JsonConverters.BillingAccountStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingSubscriptionType))
                {
                    return new global::Neon.JsonConverters.BillingSubscriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingSubscriptionType?))
                {
                    return new global::Neon.JsonConverters.BillingSubscriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingPaymentMethod))
                {
                    return new global::Neon.JsonConverters.BillingPaymentMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BillingPaymentMethod?))
                {
                    return new global::Neon.JsonConverters.BillingPaymentMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.MemberRole))
                {
                    return new global::Neon.JsonConverters.MemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.MemberRole?))
                {
                    return new global::Neon.JsonConverters.MemberRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod))
                {
                    return new global::Neon.JsonConverters.AuthDetailsResponseAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.AuthDetailsResponseAuthMethod?))
                {
                    return new global::Neon.JsonConverters.AuthDetailsResponseAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.IdentityProviderId))
                {
                    return new global::Neon.JsonConverters.IdentityProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.IdentityProviderId?))
                {
                    return new global::Neon.JsonConverters.IdentityProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.DataAPICreateRequestAuthProvider))
                {
                    return new global::Neon.JsonConverters.DataAPICreateRequestAuthProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.DataAPICreateRequestAuthProvider?))
                {
                    return new global::Neon.JsonConverters.DataAPICreateRequestAuthProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider))
                {
                    return new global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthSupportedAuthProvider?))
                {
                    return new global::Neon.JsonConverters.NeonAuthSupportedAuthProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectOwnedBy?))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectOwnedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthProviderProjectTransferStatus?))
                {
                    return new global::Neon.JsonConverters.NeonAuthProviderProjectTransferStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigCreatorRole?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigCreatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOrganizationConfigUpdateCreatorRole?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOrganizationConfigUpdateCreatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent))
                {
                    return new global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthWebhookConfigEnabledEvent?))
                {
                    return new global::Neon.JsonConverters.NeonAuthWebhookConfigEnabledEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderId?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthOauthProviderType?))
                {
                    return new global::Neon.JsonConverters.NeonAuthOauthProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailServerConfigResponseDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailServerConfigResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailVerificationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonAuthEmailVerificationMethod?))
                {
                    return new global::Neon.JsonConverters.NeonAuthEmailVerificationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ApplicationType))
                {
                    return new global::Neon.JsonConverters.ApplicationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ApplicationType?))
                {
                    return new global::Neon.JsonConverters.ApplicationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BucketAccessLevel))
                {
                    return new global::Neon.JsonConverters.BucketAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BucketAccessLevel?))
                {
                    return new global::Neon.JsonConverters.BucketAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BucketCreateRequestAccessLevel))
                {
                    return new global::Neon.JsonConverters.BucketCreateRequestAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BucketCreateRequestAccessLevel?))
                {
                    return new global::Neon.JsonConverters.BucketCreateRequestAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BranchStorageNotEnabledReason))
                {
                    return new global::Neon.JsonConverters.BranchStorageNotEnabledReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BranchStorageNotEnabledReason?))
                {
                    return new global::Neon.JsonConverters.BranchStorageNotEnabledReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogSource))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogSource?))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogSeverity))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogSeverity?))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogsNotAvailableReason))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogsNotAvailableReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogsNotAvailableReason?))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogsNotAvailableReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogsInvalidQueryReason))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogsInvalidQueryReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogsInvalidQueryReason?))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogsInvalidQueryReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogsQueryRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder?))
                {
                    return new global::Neon.JsonConverters.ProjectBranchLogsQueryRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BranchAiGatewayNotEnabledReason))
                {
                    return new global::Neon.JsonConverters.BranchAiGatewayNotEnabledReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.BranchAiGatewayNotEnabledReason?))
                {
                    return new global::Neon.JsonConverters.BranchAiGatewayNotEnabledReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.PresignRequestOperation))
                {
                    return new global::Neon.JsonConverters.PresignRequestOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.PresignRequestOperation?))
                {
                    return new global::Neon.JsonConverters.PresignRequestOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CredentialScope))
                {
                    return new global::Neon.JsonConverters.CredentialScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CredentialScope?))
                {
                    return new global::Neon.JsonConverters.CredentialScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GrantedCredentialScope))
                {
                    return new global::Neon.JsonConverters.GrantedCredentialScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GrantedCredentialScope?))
                {
                    return new global::Neon.JsonConverters.GrantedCredentialScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType))
                {
                    return new global::Neon.JsonConverters.CreateCredentialRequestPrincipalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.CreateCredentialRequestPrincipalType?))
                {
                    return new global::Neon.JsonConverters.CreateCredentialRequestPrincipalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType))
                {
                    return new global::Neon.JsonConverters.RotateCredentialResponsePrincipalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.RotateCredentialResponsePrincipalType?))
                {
                    return new global::Neon.JsonConverters.RotateCredentialResponsePrincipalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonFunctionDeploymentStatus))
                {
                    return new global::Neon.JsonConverters.NeonFunctionDeploymentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.NeonFunctionDeploymentStatus?))
                {
                    return new global::Neon.JsonConverters.NeonFunctionDeploymentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.TriggerCreateRequestDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.TriggerCreateRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.TriggerCreateRequestDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.TriggerCreateRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ScheduleTriggerCreateRequestType))
                {
                    return new global::Neon.JsonConverters.ScheduleTriggerCreateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ScheduleTriggerCreateRequestType?))
                {
                    return new global::Neon.JsonConverters.ScheduleTriggerCreateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerCreateRequestType))
                {
                    return new global::Neon.JsonConverters.StorageObjectCreatedTriggerCreateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerCreateRequestType?))
                {
                    return new global::Neon.JsonConverters.StorageObjectCreatedTriggerCreateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.TriggerUpdateRequestDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.TriggerUpdateRequestDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.TriggerUpdateRequestDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.TriggerUpdateRequestDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ScheduleTriggerUpdateRequestType))
                {
                    return new global::Neon.JsonConverters.ScheduleTriggerUpdateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ScheduleTriggerUpdateRequestType?))
                {
                    return new global::Neon.JsonConverters.ScheduleTriggerUpdateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequestType))
                {
                    return new global::Neon.JsonConverters.StorageObjectCreatedTriggerUpdateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerUpdateRequestType?))
                {
                    return new global::Neon.JsonConverters.StorageObjectCreatedTriggerUpdateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.TriggerDiscriminatorType))
                {
                    return new global::Neon.JsonConverters.TriggerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.TriggerDiscriminatorType?))
                {
                    return new global::Neon.JsonConverters.TriggerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ScheduleTriggerType))
                {
                    return new global::Neon.JsonConverters.ScheduleTriggerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ScheduleTriggerType?))
                {
                    return new global::Neon.JsonConverters.ScheduleTriggerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerType))
                {
                    return new global::Neon.JsonConverters.StorageObjectCreatedTriggerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.StorageObjectCreatedTriggerType?))
                {
                    return new global::Neon.JsonConverters.StorageObjectCreatedTriggerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.FunctionDeployRequestRuntime))
                {
                    return new global::Neon.JsonConverters.FunctionDeployRequestRuntimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.FunctionDeployRequestRuntime?))
                {
                    return new global::Neon.JsonConverters.FunctionDeployRequestRuntimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity))
                {
                    return new global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity?))
                {
                    return new global::Neon.JsonConverters.GetProjectAdvisorSecurityIssuesMinSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ListProjectBranchesSortBy))
                {
                    return new global::Neon.JsonConverters.ListProjectBranchesSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ListProjectBranchesSortBy?))
                {
                    return new global::Neon.JsonConverters.ListProjectBranchesSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ListProjectBranchesSortOrder))
                {
                    return new global::Neon.JsonConverters.ListProjectBranchesSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.ListProjectBranchesSortOrder?))
                {
                    return new global::Neon.JsonConverters.ListProjectBranchesSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetOrganizationMembersSortBy))
                {
                    return new global::Neon.JsonConverters.GetOrganizationMembersSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetOrganizationMembersSortBy?))
                {
                    return new global::Neon.JsonConverters.GetOrganizationMembersSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetOrganizationMembersSortOrder))
                {
                    return new global::Neon.JsonConverters.GetOrganizationMembersSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.GetOrganizationMembersSortOrder?))
                {
                    return new global::Neon.JsonConverters.GetOrganizationMembersSortOrderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}