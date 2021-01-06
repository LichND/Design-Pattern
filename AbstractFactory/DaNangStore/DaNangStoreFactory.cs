
using System;
using BaseStoreModule;
using DaNangStore.Foods;

namespace DaNangStore {
    public class DaNangStoreFactory : BaseStoreFactory
    {

        public DaNangStoreFactory(): base("Đà Nẵng") {
        }
        
        public override Food ServeFood(FoodType type)
        {
            switch (type) {
                case FoodType.Hamburger: return new DaNangHamburger();
                case FoodType.Sandwich: return new DaNangSandwich();
                case FoodType.FriedChicken: return new DaNangFriedChicken();
            }
            Console.WriteLine("The food you order is not available in " + this.StoreName);
            return null;
        }
    }
}