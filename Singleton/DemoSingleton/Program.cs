using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            EagerInitialization eagerInitializationInstance;
            LazyInitialization lazyInitializationInstance;
            ThreadSafeSingleton threadSafeSingletonInstance;
            BillPughImplementation billPughImplementationInstance;
        
            Console.ReadLine();

            eagerInitializationInstance = EagerInitialization.GetInstance();
            lazyInitializationInstance = LazyInitialization.GetInstance();
            threadSafeSingletonInstance = ThreadSafeSingleton.GetInstance();
            billPughImplementationInstance = BillPughImplementation.GetInstance();

            Console.ReadLine();

            eagerInitializationInstance.DoSomeThing();
            lazyInitializationInstance.DoSomeThing();
            threadSafeSingletonInstance.DoSomeThing();
            billPughImplementationInstance.DoSomeThing();
            
            Console.ReadLine();
        }
    }
}
