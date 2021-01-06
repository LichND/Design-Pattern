using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.FlyweightFactory
{
    public class Factory
    {
        private static Factory _instance;
        public static Factory Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Factory();
                }
                return _instance;
            }
        }

        private Factory()
        {
            FoodsFactory = new Dictionary<string, List<object>>();
            MenuFactory = new Menu();
        }

        private Dictionary<string, List<object>> FoodsFactory { get; set; } 
        private IMenu MenuFactory { get; set; }

        public T GetFoodObject<T>() where T : IFood
        {
            Type type = typeof(T);
            string key = type.ToString();
            List<object> foods;
            if (!FoodsFactory.TryGetValue(key, out foods))
            {
                foods = new List<object>();
                FoodsFactory.Add(key, foods);
            }

            for (int i = 0; i < foods.Count; i++)
            {
                if ((foods[i] as IFood).IsUsed())
                {
                    return (T)foods[i];
                }
            }

            T food = (T)Activator.CreateInstance(type);
            foods.Add(food);
            System.Diagnostics.Debug.WriteLine($"{key} just extend one more item for total of {foods.Count}");
            return food;
        }

        public IMenu GetMenuObject()
        {
            return MenuFactory;
        }
    }
}
