using ObjectLibrary.Messaging.Base;

namespace ObjectLibrary.Messaging
{

    public interface ISampleRequest : IServiceMessageRequest
    {
        string Name { get; set; }
    }

    public class SampleRequest : ServiceMessageRequest, ISampleRequest
    {

        private static int counter = 0;
        public string Name { get; set; } = $"Sample {counter++}";
        
    }
}
