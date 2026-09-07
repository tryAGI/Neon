#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Trigger creation payload discriminated by `type`. The only currently<br/>
    /// supported trigger type is `schedule`.
    /// </summary>
    public readonly partial struct TriggerCreateRequest : global::System.IEquatable<TriggerCreateRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Neon.TriggerCreateRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ScheduleTriggerCreateRequest? Schedule { get; init; }
#else
        public global::Neon.ScheduleTriggerCreateRequest? Schedule { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Schedule))]
#endif
        public bool IsSchedule => Schedule != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSchedule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Neon.ScheduleTriggerCreateRequest? value)
        {
            value = Schedule;
            return IsSchedule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.ScheduleTriggerCreateRequest PickSchedule() => IsSchedule
            ? Schedule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Schedule' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TriggerCreateRequest(global::Neon.ScheduleTriggerCreateRequest value) => new TriggerCreateRequest((global::Neon.ScheduleTriggerCreateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.ScheduleTriggerCreateRequest?(TriggerCreateRequest @this) => @this.Schedule;

        /// <summary>
        ///
        /// </summary>
        public TriggerCreateRequest(global::Neon.ScheduleTriggerCreateRequest? value)
        {
            Schedule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TriggerCreateRequest FromSchedule(global::Neon.ScheduleTriggerCreateRequest? value) => new TriggerCreateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public TriggerCreateRequest(
            global::Neon.TriggerCreateRequestDiscriminatorType? type,
            global::Neon.ScheduleTriggerCreateRequest? schedule
            )
        {
            Type = type;

            Schedule = schedule;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Schedule as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Schedule?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSchedule;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Neon.ScheduleTriggerCreateRequest, TResult>? schedule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule && schedule != null)
            {
                return schedule(Schedule!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Neon.ScheduleTriggerCreateRequest>? schedule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule)
            {
                schedule?.Invoke(Schedule!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Neon.ScheduleTriggerCreateRequest>? schedule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule)
            {
                schedule?.Invoke(Schedule!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Schedule,
                typeof(global::Neon.ScheduleTriggerCreateRequest),
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
        public bool Equals(TriggerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ScheduleTriggerCreateRequest?>.Default.Equals(Schedule, other.Schedule)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TriggerCreateRequest obj1, TriggerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TriggerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TriggerCreateRequest obj1, TriggerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TriggerCreateRequest o && Equals(o);
        }
    }
}
