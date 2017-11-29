using System;

namespace LiquidProjections.PollingEventStore.ThreadSafetyAttributes
{
    /// <summary>
    /// Indicates that the method supports invocations from different threads without any additional synchronization requirements
    /// as long as the instance is never accessed in parallel (including reading the state or invoking some other method).
    /// Such method observes the properly published state changes,
    /// it properly publishes its state changes,
    /// and its state is the same for all the threads.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class ThreadChangeSafeMethodAttribute : Attribute
    {
    }
}
