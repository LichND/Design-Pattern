using System;


namespace BaseStoreModule {

    public abstract class Food {
        protected String[] ingredients;
        protected long price;
        protected FoodType type;

        public Food() {
            this.Process();
        }

        public virtual void Process() {
            this.InternalProcess();
        }

        protected abstract void InternalProcess();

        public virtual long GetPrice() {
            return this.price;
        }
    }
}