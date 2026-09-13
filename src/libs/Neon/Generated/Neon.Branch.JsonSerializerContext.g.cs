
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>?), TypeInfoPropertyName = "ConnectionURIsOptionalResponse_dba8030245622754")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Operation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction), TypeInfoPropertyName = "OperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus), TypeInfoPropertyName = "OperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.PreloadLibraries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPagination))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState), TypeInfoPropertyName = "EndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode), TypeInfoPropertyName = "EndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ConnectionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ConnectionURIsOptionalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleCreateRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RolesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RolePasswordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Database))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseCreateRequestDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseUpdateRequestDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchOperations), TypeInfoPropertyName = "BranchOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseOperations), TypeInfoPropertyName = "DatabaseOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleOperations), TypeInfoPropertyName = "RoleOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationObjectData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AnnotationsMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Neon.AnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableConstraint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchSchemaJSONTableConstraintReferencedTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>), TypeInfoPropertyName = "AllOfBranchCreateRequestAnnotationCreateValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.FinalizeRestoreBranchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortBy), TypeInfoPropertyName = "ListProjectBranchesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortOrder), TypeInfoPropertyName = "ListProjectBranchesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>), TypeInfoPropertyName = "AllOfBranchResponseEndpointsResponseOperationsResponseRolesResponseDatabasesResponseConnectionURIsOptionalResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfBranchesResponseAnnotationsMapResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>), TypeInfoPropertyName = "AllOfBranchResponseAnnotationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction?), TypeInfoPropertyName = "NullableOperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus?), TypeInfoPropertyName = "NullableOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchRecoveryInfoDeletionMethod?), TypeInfoPropertyName = "NullableBranchRecoveryInfoDeletionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType?), TypeInfoPropertyName = "NullableEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchAnonymizedCreateRequest?), TypeInfoPropertyName = "NullableBranchAnonymizedCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState?), TypeInfoPropertyName = "NullableEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode?), TypeInfoPropertyName = "NullableEndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.BranchOperations?), TypeInfoPropertyName = "NullableBranchOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.DatabaseOperations?), TypeInfoPropertyName = "NullableDatabaseOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.RoleOperations?), TypeInfoPropertyName = "NullableRoleOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>?), TypeInfoPropertyName = "NullableAllOfBranchCreateRequestAnnotationCreateValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortBy?), TypeInfoPropertyName = "NullableListProjectBranchesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ListProjectBranchesSortOrder?), TypeInfoPropertyName = "NullableListProjectBranchesSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfBranchesResponseAnnotationsMapResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>?), TypeInfoPropertyName = "NullableAllOfBranchResponseAnnotationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchRestrictedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.MaskingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchCreateRequestEndpointOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Branch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ConnectionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Database>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchSchemaJSONTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchSchemaJSONTableColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.BranchSchemaJSONTableConstraint>))]
    internal sealed partial class BranchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BranchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BranchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Neon.JsonConverters.BranchAnonymizedCreateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.BranchOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.DatabaseOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.RoleOperationsJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.BranchResponse, global::Neon.AnnotationResponse>());
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
                    typeToConvert == typeof(global::Neon.OperationAction)

                    || typeToConvert == typeof(global::Neon.OperationAction?)

                    || typeToConvert == typeof(global::Neon.OperationStatus)

                    || typeToConvert == typeof(global::Neon.OperationStatus?)

                    || typeToConvert == typeof(global::Neon.BranchRecoveryInfoDeletionMethod)

                    || typeToConvert == typeof(global::Neon.BranchRecoveryInfoDeletionMethod?)

                    || typeToConvert == typeof(global::Neon.EndpointState)

                    || typeToConvert == typeof(global::Neon.EndpointState?)

                    || typeToConvert == typeof(global::Neon.EndpointType)

                    || typeToConvert == typeof(global::Neon.EndpointType?)

                    || typeToConvert == typeof(global::Neon.EndpointPoolerMode)

                    || typeToConvert == typeof(global::Neon.EndpointPoolerMode?)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortBy)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortBy?)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortOrder)

                    || typeToConvert == typeof(global::Neon.ListProjectBranchesSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new BranchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}