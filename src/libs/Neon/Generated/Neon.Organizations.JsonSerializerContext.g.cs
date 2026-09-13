
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EmptyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.VPCEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointsWithRegionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.VPCEndpointWithRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointWithRegion), TypeInfoPropertyName = "VPCEndpointWithRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointWithRegionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SpendingLimitUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.SpendingLimitResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.TransferProjectsToOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.LimitsUnsatisfiedResponseLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.ProjectsWithIntegrationResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectsWithIntegrationResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortBy), TypeInfoPropertyName = "GetOrganizationMembersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortOrder), TypeInfoPropertyName = "GetOrganizationMembersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.OrgApiKeysListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfOrganizationMembersResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateRequest?), TypeInfoPropertyName = "NullableOrgApiKeyCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyCreateResponse?), TypeInfoPropertyName = "NullableOrgApiKeyCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeyRevokeResponse?), TypeInfoPropertyName = "NullableOrgApiKeyRevokeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OrgApiKeysListResponseItem?), TypeInfoPropertyName = "NullableOrgApiKeysListResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.VPCEndpointWithRegion?), TypeInfoPropertyName = "NullableVPCEndpointWithRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.MemberRole?), TypeInfoPropertyName = "NullableMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortBy?), TypeInfoPropertyName = "NullableGetOrganizationMembersSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GetOrganizationMembersSortOrder?), TypeInfoPropertyName = "NullableGetOrganizationMembersSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfOrganizationMembersResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.VPCEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.VPCEndpointWithRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Invitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrganizationInviteCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.MemberWithUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.LimitsUnsatisfiedResponseLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectsWithIntegrationResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.OrgApiKeysListResponseItem>))]
    internal sealed partial class OrganizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeyCreateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeyCreateResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeyRevokeResponseJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.OrgApiKeysListResponseItemJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.VPCEndpointWithRegionJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.AllOfJsonConverter<global::Neon.OrganizationMembersResponse, global::Neon.CursorPaginationResponse>());
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
                    typeToConvert == typeof(global::Neon.MemberRole)

                    || typeToConvert == typeof(global::Neon.MemberRole?)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortBy)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortBy?)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortOrder)

                    || typeToConvert == typeof(global::Neon.GetOrganizationMembersSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Neon.MemberRole))
                {
                    return new global::Neon.JsonConverters.MemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Neon.MemberRole?))
                {
                    return new global::Neon.JsonConverters.MemberRoleNullableJsonConverter();
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
                    0 => new OrganizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}