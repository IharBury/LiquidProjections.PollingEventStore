using System;

namespace LiquidProjections.PollingEventStore.ThreadSafetyAttributes
{
    /// <summary>
    /// Indicates that the mutable state of the return value is exclusively accessed only by the code that invoked the method.
    /// Other threads can neither read nor write mutable state accessed by the return value.
    /// Other threads can read immutable state accessed by the return value.
    /// That allows the invoking thread to read and write the return value state without any additional synchronization.
    /// </summary>
    [AttributeUsage(AttributeTargets.ReturnValue)]
    public sealed class ExclusiveMutableReturnValueAttribute : Attribute
    {
    }
}
