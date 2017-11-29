using System;

namespace LiquidProjections.PollingEventStore.ThreadSafetyAttributes
{
    /// <summary>
    /// Indicates that the field is immutable.
    /// A field is immutable when it is read-only and the entire state (including private)
    /// being accessed by the value of the field never changes after the instance has been constructed
    /// (and is the same for all the threads).
    /// That makes the field thread-safe without any additional synchronization requirements.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class ImmutableFieldAttribute : Attribute
    {
    }
}
