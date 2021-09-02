namespace ObjectLibrary.Messaging.Base
{
    public abstract class ServiceMessageResponse : ServiceMessageRequest, IServiceMessageResponse
    {

        public string Errors { get; set; }
        public bool HasErrors => string.IsNullOrWhiteSpace(Errors);

    }
}