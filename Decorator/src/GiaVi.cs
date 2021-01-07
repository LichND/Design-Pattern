using System;
using Base;


namespace ConcreteGiaVi {
    public class Hanh : GiaVi
    {
        public Hanh(ThanhPhan thanhPhan): base(thanhPhan) {

        }
        public override void PhucVu()
        {
            this.thanhPhan.PhucVu();
            Console.WriteLine("phuc vu hanh");
        }
    }

    public class Rau : GiaVi
    {
        private int soLuong;
        public Rau(ThanhPhan thanhPhan, int soLuong = 1): base(thanhPhan) {
            this.soLuong = soLuong;
        }

        public override void PhucVu()
        {
            this.thanhPhan.PhucVu();
            Console.WriteLine($"phuc vu {this.soLuong} phan rau");
        }
    }

    public class Tieu : GiaVi
    {
       public Tieu(ThanhPhan thanhPhan): base(thanhPhan) {

        }
        public override void PhucVu()
        {
            this.thanhPhan.PhucVu();
            Console.WriteLine("phuc vu Tieu");
        }
    }
}