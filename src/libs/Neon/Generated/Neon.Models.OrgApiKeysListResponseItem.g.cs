#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrgApiKeysListResponseItem : global::System.IEquatable<OrgApiKeysListResponseItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ApiKeysListResponseItem? ApiKeysListResponseItem { get; init; }
#else
        public global::Neon.ApiKeysListResponseItem? ApiKeysListResponseItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKeysListResponseItem))]
#endif
        public bool IsApiKeysListResponseItem => ApiKeysListResponseItem != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApiKeysListResponseItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.ApiKeysListResponseItem? value)
        {
            value = ApiKeysListResponseItem;
            return IsApiKeysListResponseItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Neon.ApiKeysListResponseItem PickApiKeysListResponseItem() => IsApiKeysListResponseItem
            ? ApiKeysListResponseItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiKeysListResponseItem' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.OrgApiKeysListResponseItemVariant2? OrgApiKeysListResponseItemVariant2 { get; init; }
#else
        public global::Neon.OrgApiKeysListResponseItemVariant2? OrgApiKeysListResponseItemVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrgApiKeysListResponseItemVariant2))]
#endif
        public bool IsOrgApiKeysListResponseItemVariant2 => OrgApiKeysListResponseItemVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrgApiKeysListResponseItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.OrgApiKeysListResponseItemVariant2? value)
        {
            value = OrgApiKeysListResponseItemVariant2;
            return IsOrgApiKeysListResponseItemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Neon.OrgApiKeysListResponseItemVariant2 PickOrgApiKeysListResponseItemVariant2() => IsOrgApiKeysListResponseItemVariant2
            ? OrgApiKeysListResponseItemVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrgApiKeysListResponseItemVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeysListResponseItem(global::Neon.ApiKeysListResponseItem value) => new OrgApiKeysListResponseItem((global::Neon.ApiKeysListResponseItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.ApiKeysListResponseItem?(OrgApiKeysListResponseItem @this) => @this.ApiKeysListResponseItem;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeysListResponseItem(global::Neon.ApiKeysListResponseItem? value)
        {
            ApiKeysListResponseItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OrgApiKeysListResponseItem FromApiKeysListResponseItem(global::Neon.ApiKeysListResponseItem? value) => new OrgApiKeysListResponseItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrgApiKeysListResponseItem(global::Neon.OrgApiKeysListResponseItemVariant2 value) => new OrgApiKeysListResponseItem((global::Neon.OrgApiKeysListResponseItemVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.OrgApiKeysListResponseItemVariant2?(OrgApiKeysListResponseItem @this) => @this.OrgApiKeysListResponseItemVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeysListResponseItem(global::Neon.OrgApiKeysListResponseItemVariant2? value)
        {
            OrgApiKeysListResponseItemVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OrgApiKeysListResponseItem FromOrgApiKeysListResponseItemVariant2(global::Neon.OrgApiKeysListResponseItemVariant2? value) => new OrgApiKeysListResponseItem(value);

        /// <summary>
        /// 
        /// </summary>
        public OrgApiKeysListResponseItem(
            global::Neon.ApiKeysListResponseItem? apiKeysListResponseItem,
            global::Neon.OrgApiKeysListResponseItemVariant2? orgApiKeysListResponseItemVariant2
            )
        {
            ApiKeysListResponseItem = apiKeysListResponseItem;
            OrgApiKeysListResponseItemVariant2 = orgApiKeysListResponseItemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrgApiKeysListResponseItemVariant2 as object ??
            ApiKeysListResponseItem as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiKeysListResponseItem?.ToString() ??
            OrgApiKeysListResponseItemVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiKeysListResponseItem && IsOrgApiKeysListResponseItemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ApiKeysListResponseItem, TResult>? apiKeysListResponseItem = null,
            global::System.Func<global::Neon.OrgApiKeysListResponseItemVariant2, TResult>? orgApiKeysListResponseItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeysListResponseItem && apiKeysListResponseItem != null)
            {
                return apiKeysListResponseItem(ApiKeysListResponseItem!);
            }
            else if (IsOrgApiKeysListResponseItemVariant2 && orgApiKeysListResponseItemVariant2 != null)
            {
                return orgApiKeysListResponseItemVariant2(OrgApiKeysListResponseItemVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ApiKeysListResponseItem>? apiKeysListResponseItem = null,

            global::System.Action<global::Neon.OrgApiKeysListResponseItemVariant2>? orgApiKeysListResponseItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeysListResponseItem)
            {
                apiKeysListResponseItem?.Invoke(ApiKeysListResponseItem!);
            }
            else if (IsOrgApiKeysListResponseItemVariant2)
            {
                orgApiKeysListResponseItemVariant2?.Invoke(OrgApiKeysListResponseItemVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Neon.ApiKeysListResponseItem>? apiKeysListResponseItem = null,
            global::System.Action<global::Neon.OrgApiKeysListResponseItemVariant2>? orgApiKeysListResponseItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKeysListResponseItem)
            {
                apiKeysListResponseItem?.Invoke(ApiKeysListResponseItem!);
            }
            else if (IsOrgApiKeysListResponseItemVariant2)
            {
                orgApiKeysListResponseItemVariant2?.Invoke(OrgApiKeysListResponseItemVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKeysListResponseItem,
                typeof(global::Neon.ApiKeysListResponseItem),
                OrgApiKeysListResponseItemVariant2,
                typeof(global::Neon.OrgApiKeysListResponseItemVariant2),
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
        public bool Equals(OrgApiKeysListResponseItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ApiKeysListResponseItem?>.Default.Equals(ApiKeysListResponseItem, other.ApiKeysListResponseItem) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.OrgApiKeysListResponseItemVariant2?>.Default.Equals(OrgApiKeysListResponseItemVariant2, other.OrgApiKeysListResponseItemVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrgApiKeysListResponseItem obj1, OrgApiKeysListResponseItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgApiKeysListResponseItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrgApiKeysListResponseItem obj1, OrgApiKeysListResponseItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgApiKeysListResponseItem o && Equals(o);
        }
    }
}
