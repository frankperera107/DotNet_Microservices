namespace CommandServices.EventProcessing
{
    public interface IEventProcessor
    {
        void ProcessEvent(string message);
    }
}
