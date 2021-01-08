using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.UnsharedFlyweight
{
    public class Rice : IFood
    {
        private bool isUsed;
        private decimal price;

        public Rice()
        {
            this.price = 10;
            isUsed = false;
        }

        public bool IsUsed()
        {
            return isUsed;
        }

        public decimal Order(decimal addOn = 0)
        {
            this.Use();
            return this.price + addOn;
        }

        public void Use()
        {
            isUsed = true;
        }
    }
}
