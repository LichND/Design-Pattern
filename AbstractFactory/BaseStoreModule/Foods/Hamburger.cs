using System;


namespace BaseStoreModule.Foods {
    public class Hamburger : Food
    {
        public Hamburger(): base() {
            this.type = FoodType.Hamburger;
        }
        protected override void InternalProcess()
        {
            Console.WriteLine("Process Hamburger");
        }
    }
}