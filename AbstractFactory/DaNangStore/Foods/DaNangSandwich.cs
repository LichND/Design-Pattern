
using BaseStoreModule.Foods;

namespace DaNangStore.Foods {
    public class DaNangSandwich: Sandwich {
        protected long bonusFee;

        public DaNangSandwich(): base() {
            this.bonusFee = 5000;
        }

        public override long GetPrice()
        {
            return this.price + bonusFee;
        }
    }
}