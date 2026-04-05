#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProjectRecoverResponse : global::System.IEquatable<ProjectRecoverResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ProjectResponse? ProjectResponse { get; init; }
#else
        public global::Neon.ProjectResponse? ProjectResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectResponse))]
#endif
        public bool IsProjectResponse => ProjectResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.BranchesResponse? Branches { get; init; }
#else
        public global::Neon.BranchesResponse? Branches { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branches))]
#endif
        public bool IsBranches => Branches != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProjectRecoverResponse(global::Neon.ProjectResponse value) => new ProjectRecoverResponse((global::Neon.ProjectResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.ProjectResponse?(ProjectRecoverResponse @this) => @this.ProjectResponse;

        /// <summary>
        /// 
        /// </summary>
        public ProjectRecoverResponse(global::Neon.ProjectResponse? value)
        {
            ProjectResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProjectRecoverResponse(global::Neon.BranchesResponse value) => new ProjectRecoverResponse((global::Neon.BranchesResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Neon.BranchesResponse?(ProjectRecoverResponse @this) => @this.Branches;

        /// <summary>
        /// 
        /// </summary>
        public ProjectRecoverResponse(global::Neon.BranchesResponse? value)
        {
            Branches = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ProjectRecoverResponse(
            global::Neon.ProjectResponse? projectResponse,
            global::Neon.BranchesResponse? branches
            )
        {
            ProjectResponse = projectResponse;
            Branches = branches;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Branches as object ??
            ProjectResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProjectResponse?.ToString() ??
            Branches?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProjectResponse && IsBranches;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ProjectResponse?, TResult>? projectResponse = null,
            global::System.Func<global::Neon.BranchesResponse?, TResult>? branches = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProjectResponse && projectResponse != null)
            {
                return projectResponse(ProjectResponse!);
            }
            else if (IsBranches && branches != null)
            {
                return branches(Branches!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ProjectResponse?>? projectResponse = null,
            global::System.Action<global::Neon.BranchesResponse?>? branches = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProjectResponse)
            {
                projectResponse?.Invoke(ProjectResponse!);
            }
            else if (IsBranches)
            {
                branches?.Invoke(Branches!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProjectResponse,
                typeof(global::Neon.ProjectResponse),
                Branches,
                typeof(global::Neon.BranchesResponse),
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
        public bool Equals(ProjectRecoverResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ProjectResponse?>.Default.Equals(ProjectResponse, other.ProjectResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Neon.BranchesResponse?>.Default.Equals(Branches, other.Branches) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProjectRecoverResponse obj1, ProjectRecoverResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProjectRecoverResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProjectRecoverResponse obj1, ProjectRecoverResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProjectRecoverResponse o && Equals(o);
        }
    }
}
