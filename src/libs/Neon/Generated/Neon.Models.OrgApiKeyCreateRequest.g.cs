#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrgApiKeyCreateRequest : global::System.IEquatable<OrgApiKeyCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ApiKeyCreateRequest? ApiKeyCreateRequest { get; init; }
#else
        public global::Neon.ApiKeyCreateRequest? ApiKeyCreateRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKeyCreateRequest))]
#endif
        public bool IsApiKeyCreateRequest => ApiKeyCreateRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.OrgApiKeyCreateRequestVariant2? OrgApiKeyCreateRequestVariant2 { get; init; }
#else
        public global::Neon.OrgApiKeyCreateRequestVariant2? OrgApiKeyCreateRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrgApiKeyCreateRequestVariant2))]
#endif
        public bool IsOrgApiKeyCreateRequestVariant2 => OrgApiKeyCreateRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeyCreateRequest(global::Neon.ApiKeyCreateRequest value) => new OrgApiKeyCreateRequest((global::Neon.ApiKeyCreateRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.ApiKeyCreateRequest?(OrgApiKeyCreateRequest @this) => @this.ApiKeyCreateRequest;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyCreateRequest(global::Neon.ApiKeyCreateRequest? value)
        {
            ApiKeyCreateRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeyCreateRequest(global::Neon.OrgApiKeyCreateRequestVariant2 value) => new OrgApiKeyCreateRequest((global::Neon.OrgApiKeyCreateRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.OrgApiKeyCreateRequestVariant2?(OrgApiKeyCreateRequest @this) => @this.OrgApiKeyCreateRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyCreateRequest(global::Neon.OrgApiKeyCreateRequestVariant2? value)
        {
            OrgApiKeyCreateRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyCreateRequest(
            global::Neon.ApiKeyCreateRequest? apiKeyCreateRequest,
            global::Neon.OrgApiKeyCreateRequestVariant2? orgApiKeyCreateRequestVariant2
            )
        {
            ApiKeyCreateRequest = apiKeyCreateRequest;
            OrgApiKeyCreateRequestVariant2 = orgApiKeyCreateRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrgApiKeyCreateRequestVariant2 as object ??
            ApiKeyCreateRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiKeyCreateRequest?.ToString() ??
            OrgApiKeyCreateRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiKeyCreateRequest && IsOrgApiKeyCreateRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ApiKeyCreateRequest?, TResult>? apiKeyCreateRequest = null,
            global::System.Func<global::Neon.OrgApiKeyCreateRequestVariant2?, TResult>? orgApiKeyCreateRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeyCreateRequest && apiKeyCreateRequest != null)
            {
                return apiKeyCreateRequest(ApiKeyCreateRequest!);
            }
            else if (IsOrgApiKeyCreateRequestVariant2 && orgApiKeyCreateRequestVariant2 != null)
            {
                return orgApiKeyCreateRequestVariant2(OrgApiKeyCreateRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ApiKeyCreateRequest?>? apiKeyCreateRequest = null,
            global::System.Action<global::Neon.OrgApiKeyCreateRequestVariant2?>? orgApiKeyCreateRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeyCreateRequest)
            {
                apiKeyCreateRequest?.Invoke(ApiKeyCreateRequest!);
            }
            else if (IsOrgApiKeyCreateRequestVariant2)
            {
                orgApiKeyCreateRequestVariant2?.Invoke(OrgApiKeyCreateRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKeyCreateRequest,
                typeof(global::Neon.ApiKeyCreateRequest),
                OrgApiKeyCreateRequestVariant2,
                typeof(global::Neon.OrgApiKeyCreateRequestVariant2),
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
        public bool Equals(OrgApiKeyCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ApiKeyCreateRequest?>.Default.Equals(ApiKeyCreateRequest, other.ApiKeyCreateRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.OrgApiKeyCreateRequestVariant2?>.Default.Equals(OrgApiKeyCreateRequestVariant2, other.OrgApiKeyCreateRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgApiKeyCreateRequest obj1, OrgApiKeyCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgApiKeyCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgApiKeyCreateRequest obj1, OrgApiKeyCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgApiKeyCreateRequest o && Equals(o);
        }
    }
}
