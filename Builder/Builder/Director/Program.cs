using Builder.ConcreteBuilder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class Program
    {
        static void Main(string[] args)
        {

            IdentificationPerson person = new IdentificationPersonBuilder()
                .SetName("Nguyễn Văn A")
                .SetEthnic("Kinh")
                .Build();

            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }
}
