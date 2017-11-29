using System;

namespace LiquidProjections.PollingEventStore.ThreadSafetyAttributes
{
    /// <summary>
    /// Indicates that the field relies on the monitor lock to protect its invariants when accessed from multiple threads
    /// (after the instance has been completely constructed).
    /// The field should not be modified without acquiring the monitor lock.
    /// When multiple items are protected by the same monitor lock,
    /// acquiring the monitor lock should be enough to observe a stable view of the items
    /// which preserves all the invariants which refer only to the items.
    /// If an invariant refers to some other item, the invariant may not be preserved.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public sealed class FieldProtectedByMonitorLockAttribute : Attribute
    {
        /// <param name="monitorLockMember">Name of the member to acquire the monitor lock on.</param>
        public FieldProtectedByMonitorLockAttribute(string monitorLockMember)
        {
            if (string.IsNullOrEmpty(monitorLockMember))
                throw new ArgumentException("A non-empty value is required.", nameof(monitorLockMember));

            MonitorLockMember = monitorLockMember;
        }

        public string MonitorLockMember { get; }
    }
}
