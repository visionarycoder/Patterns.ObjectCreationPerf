using System;
using System.Diagnostics;

namespace ObjectLibrary
{
    public static class ServiceMessageFactory_Activator<T> where T : IServiceMessage
    {

        public static T Create()
        {
            return Create(Guid.Empty);
        }

        public static T Create(Guid correlationId)
        {
            var instance = Activator.CreateInstance<T>();
            instance.MessageId = Guid.NewGuid();
            instance.CorrelationId = correlationId;
            instance.Timestamp = DateTime.UtcNow;
            instance.Stopwatch = Stopwatch.StartNew();
            return instance;
        }

        public static T CreateFrom(IServiceMessage caller)
        {

            var message = Create();
            message.CorrelationId = caller.CorrelationId == Guid.Empty
                ? caller.MessageId
                : caller.CorrelationId;
            return message;

        }

    }

}
