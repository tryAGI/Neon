
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.CursorPaginationResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.NeonFunctionsListResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfNeonFunctionsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>), TypeInfoPropertyName = "AllOfCustomDomainsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.NeonFunctionsListResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfNeonFunctionsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.AllOf<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>?), TypeInfoPropertyName = "NullableAllOfCustomDomainsListResponseCursorPaginationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.NeonFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Trigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.CustomDomain>))]
    internal sealed partial class FunctionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FunctionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FunctionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Neon.JsonConverters.TriggerCreateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.TriggerUpdateRequestJsonConverter());
            options.Converters.Add(new global::Neon.JsonConverters.TriggerJsonConverter());
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
                    typeToConvert == typeof(global::Neon.NeonFunctionDeploymentStatus)

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

                    || typeToConvert == typeof(global::Neon.FunctionDeployRequestRuntime?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new FunctionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}