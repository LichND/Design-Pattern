using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class EagerInitialization
    {
        private static EagerInitialization instance = new EagerInitialization();
        public static EagerInitialization GetInstance()
        {
            return EagerInitialization.instance;
        }

        private EagerInitialization()
        {
            Console.WriteLine("Eager Initialization");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Hello I'm Singleton with Eager Initialization!");
        }
    }
}
