#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BranchAnonymizedCreateRequest : global::System.IEquatable<BranchAnonymizedCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.AnnotationCreateValueRequest? AnnotationValue { get; init; }
#else
        public global::Neon.AnnotationCreateValueRequest? AnnotationValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnnotationValue))]
#endif
        public bool IsAnnotationValue => AnnotationValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.BranchAnonymizedCreateRequestVariant2? BranchAnonymizedCreateRequestVariant2 { get; init; }
#else
        public global::Neon.BranchAnonymizedCreateRequestVariant2? BranchAnonymizedCreateRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchAnonymizedCreateRequestVariant2))]
#endif
        public bool IsBranchAnonymizedCreateRequestVariant2 => BranchAnonymizedCreateRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchAnonymizedCreateRequest(global::Neon.AnnotationCreateValueRequest value) => new BranchAnonymizedCreateRequest((global::Neon.AnnotationCreateValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.AnnotationCreateValueRequest?(BranchAnonymizedCreateRequest @this) => @this.AnnotationValue;

        /// <summary>
        /// 
        /// </summary>
        public BranchAnonymizedCreateRequest(global::Neon.AnnotationCreateValueRequest? value)
        {
            AnnotationValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchAnonymizedCreateRequest(global::Neon.BranchAnonymizedCreateRequestVariant2 value) => new BranchAnonymizedCreateRequest((global::Neon.BranchAnonymizedCreateRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.BranchAnonymizedCreateRequestVariant2?(BranchAnonymizedCreateRequest @this) => @this.BranchAnonymizedCreateRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BranchAnonymizedCreateRequest(global::Neon.BranchAnonymizedCreateRequestVariant2? value)
        {
            BranchAnonymizedCreateRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BranchAnonymizedCreateRequest(
            global::Neon.AnnotationCreateValueRequest? annotationValue,
            global::Neon.BranchAnonymizedCreateRequestVariant2? branchAnonymizedCreateRequestVariant2
            )
        {
            AnnotationValue = annotationValue;
            BranchAnonymizedCreateRequestVariant2 = branchAnonymizedCreateRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BranchAnonymizedCreateRequestVariant2 as object ??
            AnnotationValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnnotationValue?.ToString() ??
            BranchAnonymizedCreateRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnnotationValue && IsBranchAnonymizedCreateRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.AnnotationCreateValueRequest?, TResult>? annotationValue = null,
            global::System.Func<global::Neon.BranchAnonymizedCreateRequestVariant2?, TResult>? branchAnonymizedCreateRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnotationValue && annotationValue != null)
            {
                return annotationValue(AnnotationValue!);
            }
            else if (IsBranchAnonymizedCreateRequestVariant2 && branchAnonymizedCreateRequestVariant2 != null)
            {
                return branchAnonymizedCreateRequestVariant2(BranchAnonymizedCreateRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.AnnotationCreateValueRequest?>? annotationValue = null,
            global::System.Action<global::Neon.BranchAnonymizedCreateRequestVariant2?>? branchAnonymizedCreateRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnotationValue)
            {
                annotationValue?.Invoke(AnnotationValue!);
            }
            else if (IsBranchAnonymizedCreateRequestVariant2)
            {
                branchAnonymizedCreateRequestVariant2?.Invoke(BranchAnonymizedCreateRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnnotationValue,
                typeof(global::Neon.AnnotationCreateValueRequest),
                BranchAnonymizedCreateRequestVariant2,
                typeof(global::Neon.BranchAnonymizedCreateRequestVariant2),
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
        public bool Equals(BranchAnonymizedCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.AnnotationCreateValueRequest?>.Default.Equals(AnnotationValue, other.AnnotationValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.BranchAnonymizedCreateRequestVariant2?>.Default.Equals(BranchAnonymizedCreateRequestVariant2, other.BranchAnonymizedCreateRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BranchAnonymizedCreateRequest obj1, BranchAnonymizedCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchAnonymizedCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BranchAnonymizedCreateRequest obj1, BranchAnonymizedCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchAnonymizedCreateRequest o && Equals(o);
        }
    }
}
