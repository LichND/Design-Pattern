
using BaseStoreModule.Foods;

namespace HoChiMinhStore.Foods {
    public class HCMSandwich: Sandwich {
        protected long bonusFee;

        public HCMSandwich(): base() {
            this.bonusFee = 5000;
        }

        public override long GetPrice()
        {
            return this.price + bonusFee;
        }
    }
}