using System;
using System.Security.Claims;
using System.Security.Principal;
using Proxy.Subject.DoorSubject;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] roles = { "Admin" };
            System.Threading.Thread.CurrentPrincipal = new GenericPrincipal(new ClaimsIdentity(), roles);
            
            IDoor door = new DoorProxy();
            door.Open();
            door.Open();
        }
    }
}
