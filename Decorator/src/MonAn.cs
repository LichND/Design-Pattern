using System;
using Base;


namespace ConcreteMonAn {

    public class BanhMi : MonAn
    {

        public BanhMi(): base() {
        }

        public override void PhucVu()
        {
            Console.WriteLine("Phuc vu banh mi");
        }
    }

    public class BanhCanh : MonAn
    {
        public override void PhucVu()
        {
            Console.WriteLine("Phuc vu banh canh");
        }
    }
}