using System;

namespace LiquidProjections.PollingEventStore.ThreadSafetyAttributes
{
    /// <summary>
    /// Indicates that the class is immutable.
    /// A type is immutable when the entire state (including private) being accessed by an object of the class
    /// never changes after the object has been constructed (and is the same for all the threads).
    /// That makes all the objects of the class thread-safe without any additional synchronization requirements.
    /// But that does not make the references to the objects thread-safe.
    /// If the class is not sealed, all the derived classes are required to be immutable too (and inherit the attribute).
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class ImmutableClassAttribute : Attribute
    {
    }
}
