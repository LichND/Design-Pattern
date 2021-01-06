
using System.Collections.Generic;

namespace Observer.Event
{
    public class EventManager : IEventManager
    {
        private static EventManager instance = new EventManager();
        public static EventManager Instance { get => instance; }
        private EventManager() { }

        private Dictionary<string, List<IEventObject>> data { get; } = new Dictionary<string, List<IEventObject>>();
        private List<IEventObject> GetHashTableValue(string key)
        {
            if (key is null || key.Length == 0)
            {
                key = "null";
            }
            List<IEventObject> ret;
            if (!data.TryGetValue(key, out ret))
            {
                ret = new List<IEventObject>();
                data.Add(key, ret);
            }
            return ret;
        }

        public void Attach(string eventName, IEventObject obj)
        {
            this.GetHashTableValue(eventName).Add(obj);
        }
        public void Detach(string eventName, IEventObject obj)
        {
            this.GetHashTableValue(eventName).Remove(obj);
        }
        public void Notify(string eventName, object param)
        {
            this.GetHashTableValue(eventName).ForEach(e =>
            {
                e.Update(param);
            });
        }
    }
}