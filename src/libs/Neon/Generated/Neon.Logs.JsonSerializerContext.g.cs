
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.GeneralError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogSource?), TypeInfoPropertyName = "NullableProjectBranchLogSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogSeverity?), TypeInfoPropertyName = "NullableProjectBranchLogSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsNotAvailableReason?), TypeInfoPropertyName = "NullableProjectBranchLogsNotAvailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsInvalidQueryReason?), TypeInfoPropertyName = "NullableProjectBranchLogsInvalidQueryReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder?), TypeInfoPropertyName = "NullableProjectBranchLogsQueryRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Neon.ProjectBranchLogRecord>))]
    internal sealed partial class LogsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LogsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LogsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LogsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Neon.ProjectBranchLogSource)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSource?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSeverity)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogSeverity?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsNotAvailableReason)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsNotAvailableReason?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsInvalidQueryReason)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsInvalidQueryReason?)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder)

                    || typeToConvert == typeof(global::Neon.ProjectBranchLogsQueryRequestSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new LogsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}