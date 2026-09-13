
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType), TypeInfoPropertyName = "EndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointSettingsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.Endpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState), TypeInfoPropertyName = "EndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode), TypeInfoPropertyName = "EndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointCreateRequestEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointUpdateRequestEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Neon.Endpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointOperations), TypeInfoPropertyName = "EndpointOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationAction?), TypeInfoPropertyName = "NullableOperationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.OperationStatus?), TypeInfoPropertyName = "NullableOperationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointType?), TypeInfoPropertyName = "NullableEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointState?), TypeInfoPropertyName = "NullableEndpointState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointPoolerMode?), TypeInfoPropertyName = "NullableEndpointPoolerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.EndpointOperations?), TypeInfoPropertyName = "NullableEndpointOperations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.Endpoint>))]
    internal sealed partial class EndpointSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndpointSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EndpointSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EndpointSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Neon.JsonConverters.EndpointOperationsJsonConverter());
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

                    || typeToConvert == typeof(global::Neon.EndpointState)

                    || typeToConvert == typeof(global::Neon.EndpointState?)

                    || typeToConvert == typeof(global::Neon.EndpointType)

                    || typeToConvert == typeof(global::Neon.EndpointType?)

                    || typeToConvert == typeof(global::Neon.EndpointPoolerMode)

                    || typeToConvert == typeof(global::Neon.EndpointPoolerMode?);
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
                    0 => new EndpointSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}