

using System;
using BaseStoreModule;
using HaNoiStore.Foods;

namespace HaNoiStore {
    public class HaNoiStoreFactory : BaseStoreFactory
    {
        public HaNoiStoreFactory(): base("Hà Nội") {
        }

        public override Food ServeFood(FoodType type)
        {
            switch (type) {
                case FoodType.Hamburger: return new HaNoiHamburger();
                case FoodType.Sandwich: return new HaNoiSandwich();
                case FoodType.FriedChicken: return new HaNoiFriedChicken();
            }
            Console.WriteLine("The food you order is not available in " + this.StoreName);
            return null;
        }
    }
}