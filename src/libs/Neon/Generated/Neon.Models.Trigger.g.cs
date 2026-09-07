#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// A branch-effective trigger discriminated by `type`. The only currently<br/>
    /// supported trigger type is `schedule`.
    /// </summary>
    public readonly partial struct Trigger : global::System.IEquatable<Trigger>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Neon.TriggerDiscriminatorType? Type { get; }

        /// <summary>
        /// A branch-effective schedule trigger for a Function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Neon.ScheduleTrigger? Schedule { get; init; }
#else
        public global::Neon.ScheduleTrigger? Schedule { get; }
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
            out global::Neon.ScheduleTrigger? value)
        {
            value = Schedule;
            return IsSchedule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Neon.ScheduleTrigger PickSchedule() => IsSchedule
            ? Schedule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Schedule' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Trigger(global::Neon.ScheduleTrigger value) => new Trigger((global::Neon.ScheduleTrigger?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Neon.ScheduleTrigger?(Trigger @this) => @this.Schedule;

        /// <summary>
        ///
        /// </summary>
        public Trigger(global::Neon.ScheduleTrigger? value)
        {
            Schedule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Trigger FromSchedule(global::Neon.ScheduleTrigger? value) => new Trigger(value);

        /// <summary>
        ///
        /// </summary>
        public Trigger(
            global::Neon.TriggerDiscriminatorType? type,
            global::Neon.ScheduleTrigger? schedule
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
            global::System.Func<global::Neon.ScheduleTrigger, TResult>? schedule = null,
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
            global::System.Action<global::Neon.ScheduleTrigger>? schedule = null,
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
            global::System.Action<global::Neon.ScheduleTrigger>? schedule = null,
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
                typeof(global::Neon.ScheduleTrigger),
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
        public bool Equals(Trigger other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Neon.ScheduleTrigger?>.Default.Equals(Schedule, other.Schedule)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Trigger obj1, Trigger obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Trigger>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Trigger obj1, Trigger obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Trigger o && Equals(o);
        }
    }
}
