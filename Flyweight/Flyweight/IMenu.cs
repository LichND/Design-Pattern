using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Flyweight
{
    public interface IMenu
    {
        List<IFood> ShowFoods();
        void HideFoods();
    }
}
