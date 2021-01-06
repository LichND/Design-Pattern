using System;
using Observer.Event;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventName1 = "Object 1 notify";
            EventObject obj1 = new EventObject("1");
            EventObject obj2 = new EventObject("2");
            EventObject obj3 = new EventObject("3");
            EventManager.Instance.Attach(eventName1, obj2);
            obj1.Notify(eventName1);
            Console.ReadLine();

            EventManager.Instance.Attach(eventName1, obj3);
            obj1.Notify(eventName1);
            Console.ReadLine();

            EventManager.Instance.Detach(eventName1, obj2);
            obj1.Notify(eventName1);
        }
    }
}
