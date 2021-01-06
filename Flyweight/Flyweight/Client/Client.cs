using Flyweight.Flyweight;
using Flyweight.FlyweightFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Client
    {
        public IMenu RequestMenuFoods()
        {
            return Factory.Instance.GetMenuObject();
        }

        public void Thinking()
        {
            System.Threading.Thread.Sleep(RandomPlus.getRange(100, 1000));
        }

        public List<IFood> OrderFoods(List<IFood> foods)
        {
            List<IFood> orderFoods = new List<IFood>();
            foods.ForEach(food =>
            {
                System.Threading.Thread.Sleep(100);
                if (RandomPlus.getValue() < 0.5)
                {
                    orderFoods.Add(food);
                }
            });
            return orderFoods;
        }

        public decimal Pay(IMenu menu, List<IFood> orderFoods)
        {
            string log = "";
            decimal price = 0;
            orderFoods.ForEach(food =>
            {
                decimal addOn = RandomPlus.getRange(0, 6);
                decimal foodPrice = food.Order(addOn);
                price += foodPrice;

                string[] foodType = food.GetType().ToString().Split('.');
                log += $"{foodType[foodType.Length - 1]} ({foodPrice - addOn})";
                if (addOn > 0)
                {
                    log += $" with add-on {addOn}";
                }
                log += ", ";
            });

            Console.WriteLine($"{log}Total Price: {price}");
            return price;
        }

        public decimal autoOder()
        {
            IMenu menu = RequestMenuFoods();
            Thinking();
            List<IFood> orderFoods = OrderFoods(menu.ShowFoods());
            return Pay(menu, orderFoods);
        }
    }
}
