

using System;
using BaseStoreModule;
using HoChiMinhStore.Foods;

namespace HoChiMinhStore {
    public class HCMStoreFactory : BaseStoreFactory
    {

        public HCMStoreFactory(): base("Hồ Chí Minh") {
        }
        
        public override Food ServeFood(FoodType type)
        {
            switch (type) {
                case FoodType.Hamburger: return new HCMHamburger();
                case FoodType.Sandwich: return new HCMSandwich();
                case FoodType.FriedChicken: return new HCMFriedChicken();
            }
            Console.WriteLine("The food you order is not available in " + this.StoreName);
            return null;
        }
    }
}