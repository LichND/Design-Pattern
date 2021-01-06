using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numClient = 5;
            List<Client> clients = new List<Client>();

            for (int i = 0; i < numClient; i++)
            {
                clients.Add(new Client());
            }

            for (int i = 0; i < clients.Count; i++)
            {
                Console.Write($"Client {i} order: ");
                clients[i].autoOder();
            }

            Console.ReadLine();
        }
    }
}
