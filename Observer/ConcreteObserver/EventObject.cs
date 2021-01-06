using System;

namespace Observer.Event
{
    public class EventObject : IEventObject
    {
        private string objectName;
        public EventObject(string objectName)
        {
            this.objectName = objectName;
        }
        public EventObject(string objectName, string listenEvent)
        {
            EventManager.Instance.Attach(listenEvent, this);
            this.objectName = objectName;
        }

        public void Notify(string eventName)
        {
            EventManager.Instance.Notify(eventName, this.objectName);
        }

        public void Update(object param)
        {
            Console.WriteLine($"Object {this.objectName} run a function because object {param} notify");
        }
    }
}