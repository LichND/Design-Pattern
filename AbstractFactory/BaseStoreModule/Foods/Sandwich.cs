using System;


namespace BaseStoreModule.Foods {
    public abstract class Sandwich : Food
    {
        public Sandwich(): base() {
            this.type = FoodType.Sandwich;
        }
        protected override void InternalProcess() {
            Console.WriteLine("Process Sandwich");
        }
    }
}