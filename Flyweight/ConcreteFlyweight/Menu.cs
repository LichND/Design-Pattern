using Flyweight.Flyweight;
using Flyweight.FlyweightFactory;
using Flyweight.UnsharedFlyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.ConcreteFlyweight
{
    public class Menu : IMenu
    {
        List<IFood> _showFoods;

        public List<IFood> ShowFoods()
        {
            if (_showFoods is null)
            {
                _showFoods = new List<IFood>();
                _showFoods.Add(Factory.Instance.GetFoodObject<Rice>());
                _showFoods.Add(Factory.Instance.GetFoodObject<Noodle>());
            }
            return _showFoods;
        }

        public void HideFoods()
        {
            if (!(_showFoods is null))
            {
                _showFoods.ForEach(e =>
                {
                    if (!e.IsUsed())
                    {
                        e.Use();
                    }
                });
            }
        }
    }
}
