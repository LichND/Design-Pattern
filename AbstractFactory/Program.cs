using System;
using StoreSystemLib;

namespace codesample
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new StoreManager();

            manager.GetStore("HaNoi").ServeFood(FoodType.Hamburger);
            manager.GetStore("DaNang").ServeFood(FoodType.FriedChicken);
            manager.GetStore("HoChiMinh").ServeFood(FoodType.Sandwich);
        }
    }
}
