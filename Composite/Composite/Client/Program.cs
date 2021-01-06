using Composite.Component;
using Composite.Composite;
using Composite.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Client
{
    class Program
    {
        public static void Main(string[] args)
        {
            IProduct allProduct = new ComplexProduct("Laptop");
            allProduct.AddChildProduct(new Product("CPU", new Cost(new TimeSpan(), 1000), new Cost(new TimeSpan(0, 30, 0), 30), new Cost(new TimeSpan(0, 5, 0), 10)));
            allProduct.AddChildProduct(new Product("GPU", new Cost(new TimeSpan(), 1000), new Cost(new TimeSpan(0, 30, 0), 30), new Cost(new TimeSpan(0, 5, 0), 10)));
            allProduct.AddChildProduct(new Product("MainBoard", new Cost(new TimeSpan(), 100), new Cost(new TimeSpan(0, 30, 0), 30), new Cost(new TimeSpan(0, 5, 0), 10)));
            allProduct.AddChildProduct(new Product("KeyBoard", new Cost(new TimeSpan(), 50), new Cost(new TimeSpan(0, 20, 0), 20), new Cost(new TimeSpan(0, 5, 0), 10)));
            allProduct.AddChildProduct(new Product("Screen", new Cost(new TimeSpan(), 200), new Cost(new TimeSpan(0, 25, 0), 25), new Cost(new TimeSpan(0, 5, 0), 10)));
            allProduct.AddChildProduct(new Product("Other", new Cost(new TimeSpan(), 300), new Cost(new TimeSpan(1, 30, 0), 90), new Cost(new TimeSpan(0, 5, 0), 10)));

            Console.WriteLine(allProduct);
            Console.WriteLine(allProduct.PrintInfo());
            Console.ReadLine();
        }
    }
}
