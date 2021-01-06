using System;

namespace Proxy.Subject.DoorSubject
{
    public class Door : IDoor
    {
        private bool isOpend = false;
        public bool IsOpend { get => isOpend; }
        public StatusCode Close()
        {
            if (this.isOpend)
            {
                this.isOpend = false;
                Console.WriteLine("Cloesd door");
                return StatusCode.Success;
            }
            else
            {
                return StatusCode.NoNeed;
            }
        }

        public StatusCode Open()
        {
            if (!isOpend)
            {
                this.isOpend = true;
                Console.WriteLine("Opened door");
                return StatusCode.Success;
            }
            else
                return StatusCode.NoNeed;
        }
    }
}