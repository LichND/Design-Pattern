using System;
using Base;
using ConcreteMonAn;
using ConcreteGiaVi;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mon An 1 =============");
            ThanhPhan monAn1 = new Hanh(new Rau(new BanhCanh()));
            monAn1.PhucVu();

            Console.WriteLine("Mon An 2 =============");
            ThanhPhan banhCanhRau = new Rau(new BanhCanh());
            ThanhPhan themRau = new Rau(banhCanhRau);
            themRau.PhucVu();
        }
    }
}
