using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Flyweight
{
    public interface IFood
    {
        decimal Order(decimal addOn = 0);
        bool IsUsed();
        void Use();
    }
}
