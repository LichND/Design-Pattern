


namespace BaseStoreModule 
{
    public abstract class BaseStoreFactory : IStoreFactory
    {
        protected string name;
        protected Food[] foods;

        public string StoreName
        {
            get => this.name;
        }

        public BaseStoreFactory(string storeName) {
            this.name = storeName;
        }

        public abstract Food ServeFood(FoodType type);
    }
}