using System;

namespace LiquidProjections.PollingEventStore.ThreadSafetyAttributes
{
    /// <summary>
    /// Indicates that the referenced delegate value is thread-safe without any additional synchronization requirements.
    /// A delegate value is thread-safe when it observes the properly published state changes,
    /// it properly publishes its state changes,
    /// its state is the same for all the threads,
    /// and it preserves all the invariants when invoked from multiple threads concurrently.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue,
        AllowMultiple = false,
        Inherited = true)]
    public sealed class ThreadSafeDelegateValueAttribute : Attribute
    {
    }
}
