using System;

namespace Proxy.Subject.DoorSubject
{
    public class DoorProxy : IDoor
    {
        private Door door = null;

        public Door Door
        {
            get
            {
                if (this.door is null)
                {
                    this.door = new Door();
                }
                return this.door;
            }
        }
        public StatusCode Close()
        {
            StatusCode ret = this.Door.Close();
            Console.WriteLine(ret);
            return ret;
        }

        public StatusCode Open()
        {
            StatusCode ret;
            if (System.Threading.Thread.CurrentPrincipal.IsInRole("Admin"))
                ret = this.Door.Open();
            else
                ret = StatusCode.AccessDeny;

            Console.WriteLine(ret);
            return ret;
        }
    }
}