#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrgApiKeyCreateResponse : global::System.IEquatable<OrgApiKeyCreateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ApiKeyCreateResponse? ApiKeyCreateResponse { get; init; }
#else
        public global::Neon.ApiKeyCreateResponse? ApiKeyCreateResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKeyCreateResponse))]
#endif
        public bool IsApiKeyCreateResponse => ApiKeyCreateResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.OrgApiKeyCreateResponseVariant2? OrgApiKeyCreateResponseVariant2 { get; init; }
#else
        public global::Neon.OrgApiKeyCreateResponseVariant2? OrgApiKeyCreateResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrgApiKeyCreateResponseVariant2))]
#endif
        public bool IsOrgApiKeyCreateResponseVariant2 => OrgApiKeyCreateResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeyCreateResponse(global::Neon.ApiKeyCreateResponse value) => new OrgApiKeyCreateResponse((global::Neon.ApiKeyCreateResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.ApiKeyCreateResponse?(OrgApiKeyCreateResponse @this) => @this.ApiKeyCreateResponse;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyCreateResponse(global::Neon.ApiKeyCreateResponse? value)
        {
            ApiKeyCreateResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeyCreateResponse(global::Neon.OrgApiKeyCreateResponseVariant2 value) => new OrgApiKeyCreateResponse((global::Neon.OrgApiKeyCreateResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.OrgApiKeyCreateResponseVariant2?(OrgApiKeyCreateResponse @this) => @this.OrgApiKeyCreateResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyCreateResponse(global::Neon.OrgApiKeyCreateResponseVariant2? value)
        {
            OrgApiKeyCreateResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeyCreateResponse(
            global::Neon.ApiKeyCreateResponse? apiKeyCreateResponse,
            global::Neon.OrgApiKeyCreateResponseVariant2? orgApiKeyCreateResponseVariant2
            )
        {
            ApiKeyCreateResponse = apiKeyCreateResponse;
            OrgApiKeyCreateResponseVariant2 = orgApiKeyCreateResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrgApiKeyCreateResponseVariant2 as object ??
            ApiKeyCreateResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiKeyCreateResponse?.ToString() ??
            OrgApiKeyCreateResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiKeyCreateResponse && IsOrgApiKeyCreateResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ApiKeyCreateResponse?, TResult>? apiKeyCreateResponse = null,
            global::System.Func<global::Neon.OrgApiKeyCreateResponseVariant2?, TResult>? orgApiKeyCreateResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeyCreateResponse && apiKeyCreateResponse != null)
            {
                return apiKeyCreateResponse(ApiKeyCreateResponse!);
            }
            else if (IsOrgApiKeyCreateResponseVariant2 && orgApiKeyCreateResponseVariant2 != null)
            {
                return orgApiKeyCreateResponseVariant2(OrgApiKeyCreateResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ApiKeyCreateResponse?>? apiKeyCreateResponse = null,
            global::System.Action<global::Neon.OrgApiKeyCreateResponseVariant2?>? orgApiKeyCreateResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeyCreateResponse)
            {
                apiKeyCreateResponse?.Invoke(ApiKeyCreateResponse!);
            }
            else if (IsOrgApiKeyCreateResponseVariant2)
            {
                orgApiKeyCreateResponseVariant2?.Invoke(OrgApiKeyCreateResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKeyCreateResponse,
                typeof(global::Neon.ApiKeyCreateResponse),
                OrgApiKeyCreateResponseVariant2,
                typeof(global::Neon.OrgApiKeyCreateResponseVariant2),
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
        public bool Equals(OrgApiKeyCreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ApiKeyCreateResponse?>.Default.Equals(ApiKeyCreateResponse, other.ApiKeyCreateResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.OrgApiKeyCreateResponseVariant2?>.Default.Equals(OrgApiKeyCreateResponseVariant2, other.OrgApiKeyCreateResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgApiKeyCreateResponse obj1, OrgApiKeyCreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgApiKeyCreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgApiKeyCreateResponse obj1, OrgApiKeyCreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgApiKeyCreateResponse o && Equals(o);
        }
    }
}
