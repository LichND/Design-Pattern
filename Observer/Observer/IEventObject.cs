namespace Observer.Event
{
    public interface IEventObject
    {
        void Update(object param);
        void Notify(string eventName);
    }
}