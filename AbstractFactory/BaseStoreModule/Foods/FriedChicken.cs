using System;


namespace BaseStoreModule.Foods {
    public class FriedChicken : Food
    {
        public FriedChicken(): base() {
            this.type = FoodType.FriedChicken;
        }
        protected override void InternalProcess()
        {
            Console.WriteLine("Process FriedChicken");
        }
    }
}