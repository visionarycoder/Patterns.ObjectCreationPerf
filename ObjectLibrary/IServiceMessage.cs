using System;
using System.Diagnostics;

namespace ObjectLibrary
{
    public interface IServiceMessage
    {

        Guid CorrelationId { get; set; }
        Guid MessageId { get; set; }
        DateTime Timestamp { get; set; }
        Stopwatch Stopwatch { get; set; }

    }
}