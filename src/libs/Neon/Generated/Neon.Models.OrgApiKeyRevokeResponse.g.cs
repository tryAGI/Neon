#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrgApiKeyRevokeResponse : global::System.IEquatable<OrgApiKeyRevokeResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ApiKeyRevokeResponse? ApiKeyRevokeResponse { get; init; }
#else
        public global::Neon.ApiKeyRevokeResponse? ApiKeyRevokeResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKeyRevokeResponse))]
#endif
        public bool IsApiKeyRevokeResponse => ApiKeyRevokeResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.OrgApiKeyRevokeResponseVariant2? OrgApiKeyRevokeResponseVariant2 { get; init; }
#else
        public global::Neon.OrgApiKeyRevokeResponseVariant2? OrgApiKeyRevokeResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrgApiKeyRevokeResponseVariant2))]
#endif
        public bool IsOrgApiKeyRevokeResponseVariant2 => OrgApiKeyRevokeResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeyRevokeResponse(global::Neon.ApiKeyRevokeResponse value) => new OrgApiKeyRevokeResponse((global::Neon.ApiKeyRevokeResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.ApiKeyRevokeResponse?(OrgApiKeyRevokeResponse @this) => @this.ApiKeyRevokeResponse;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyRevokeResponse(global::Neon.ApiKeyRevokeResponse? value)
        {
            ApiKeyRevokeResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeyRevokeResponse(global::Neon.OrgApiKeyRevokeResponseVariant2 value) => new OrgApiKeyRevokeResponse((global::Neon.OrgApiKeyRevokeResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.OrgApiKeyRevokeResponseVariant2?(OrgApiKeyRevokeResponse @this) => @this.OrgApiKeyRevokeResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyRevokeResponse(global::Neon.OrgApiKeyRevokeResponseVariant2? value)
        {
            OrgApiKeyRevokeResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyRevokeResponse(
            global::Neon.ApiKeyRevokeResponse? apiKeyRevokeResponse,
            global::Neon.OrgApiKeyRevokeResponseVariant2? orgApiKeyRevokeResponseVariant2
            )
        {
            ApiKeyRevokeResponse = apiKeyRevokeResponse;
            OrgApiKeyRevokeResponseVariant2 = orgApiKeyRevokeResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrgApiKeyRevokeResponseVariant2 as object ??
            ApiKeyRevokeResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiKeyRevokeResponse?.ToString() ??
            OrgApiKeyRevokeResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiKeyRevokeResponse && IsOrgApiKeyRevokeResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ApiKeyRevokeResponse?, TResult>? apiKeyRevokeResponse = null,
            global::System.Func<global::Neon.OrgApiKeyRevokeResponseVariant2?, TResult>? orgApiKeyRevokeResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeyRevokeResponse && apiKeyRevokeResponse != null)
            {
                return apiKeyRevokeResponse(ApiKeyRevokeResponse!);
            }
            else if (IsOrgApiKeyRevokeResponseVariant2 && orgApiKeyRevokeResponseVariant2 != null)
            {
                return orgApiKeyRevokeResponseVariant2(OrgApiKeyRevokeResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ApiKeyRevokeResponse?>? apiKeyRevokeResponse = null,
            global::System.Action<global::Neon.OrgApiKeyRevokeResponseVariant2?>? orgApiKeyRevokeResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeyRevokeResponse)
            {
                apiKeyRevokeResponse?.Invoke(ApiKeyRevokeResponse!);
            }
            else if (IsOrgApiKeyRevokeResponseVariant2)
            {
                orgApiKeyRevokeResponseVariant2?.Invoke(OrgApiKeyRevokeResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKeyRevokeResponse,
                typeof(global::Neon.ApiKeyRevokeResponse),
                OrgApiKeyRevokeResponseVariant2,
                typeof(global::Neon.OrgApiKeyRevokeResponseVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OrgApiKeyRevokeResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ApiKeyRevokeResponse?>.Default.Equals(ApiKeyRevokeResponse, other.ApiKeyRevokeResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.OrgApiKeyRevokeResponseVariant2?>.Default.Equals(OrgApiKeyRevokeResponseVariant2, other.OrgApiKeyRevokeResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgApiKeyRevokeResponse obj1, OrgApiKeyRevokeResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgApiKeyRevokeResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgApiKeyRevokeResponse obj1, OrgApiKeyRevokeResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgApiKeyRevokeResponse o && Equals(o);
        }
    }
}
