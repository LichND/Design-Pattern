

namespace Base {
    public abstract class GiaVi : ThanhPhan {
        protected ThanhPhan thanhPhan;
        public GiaVi(ThanhPhan thanhPhan) {
            this.thanhPhan = thanhPhan;
        }
        public abstract void PhucVu();
    }
}