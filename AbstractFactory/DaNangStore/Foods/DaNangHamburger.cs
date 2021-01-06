
using System;
using BaseStoreModule.Foods;

namespace DaNangStore.Foods {
    public class DaNangHamburger: Hamburger {

        public override void Process()
        {
            Console.WriteLine("Process DaNangHamburger");
        }
    }
}