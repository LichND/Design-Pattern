using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public class ComplexProduct : IProduct
    {
        private string name;
        private List<IProduct> products = new List<IProduct>();

        public ComplexProduct(string name)
        {
            this.name = name;
        }

        public void AddChildProduct(IProduct product)
        {
            products.Add(product);
        }

        public Cost BuyMaterial()
        {
            Cost ret = new Cost();
            products.ForEach(e => ret += e.BuyMaterial());
            return ret;
        }

        public Cost MaterialOperation()
        {
            Cost ret = new Cost();
            products.ForEach(e => ret += e.MaterialOperation());
            return ret;
        }

        public Cost PackProduct()
        {
            Cost ret = new Cost();
            products.ForEach(e => ret += e.PackProduct());
            return ret;
        }

        public string PrintInfo(bool onlyResult = true)
        {
            if (onlyResult)
            {
                return $"Product {name} cost total {BuyMaterial() + MaterialOperation() + PackProduct()}";
            }
            return $"Product {name} cost {BuyMaterial()} for buy, {MaterialOperation()} for operation and {PackProduct()} for pack";
        }

        public void RemoveChildProduct(IProduct product)
        {
            products.Remove(product);
        }

        public override string ToString()
        {
            string ret = "";
            products.ForEach(e => ret += e.ToString() + "\n");
            return ret;
        }
    }
}
