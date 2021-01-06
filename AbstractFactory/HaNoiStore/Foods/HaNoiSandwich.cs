
using BaseStoreModule.Foods;

namespace HaNoiStore.Foods {
    public class HaNoiSandwich: Sandwich {
        protected long bonusFee;

        public HaNoiSandwich(): base() {
            this.bonusFee = 5000;
        }

        public override long GetPrice()
        {
            return this.price + bonusFee;
        }
    }
}