namespace Observer.Event
{
    public interface IEventManager
    {
        void Attach(string eventName, IEventObject obj);
        void Detach(string eventName, IEventObject obj);
        void Notify(string eventName, object param);
    } 
}