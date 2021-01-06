using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    public class Product : IProduct
    {
        private string name;
        private Cost buyCost, operationCost, packCost;

        public Product(string name)
        {
            this.name = name;
            buyCost = new Cost();
            operationCost = new Cost();
            packCost = new Cost();
        }

        public Cost BuyMaterial()
        {
            return buyCost;
        }

        public Cost MaterialOperation()
        {
            return operationCost;
        }

        public Cost PackProduct()
        {
            return packCost;
        }

        public string PrintInfo(bool onlyResult = true)
        {
            if (onlyResult)
            {
                return $"Product {name} cost total {buyCost + operationCost + packCost}";
            }
            return ToString();
        }

        public void AddChildProduct(IProduct product)
        {
            throw new ThisIsLeafException();
        }

        public void RemoveChildProduct(IProduct product)
        {
            throw new ThisIsLeafException();
        }

        public override string ToString()
        {
            return $"Product {name} cost {buyCost} for buy, {operationCost} for operation and {packCost} for pack";
        }

        class ThisIsLeafException : Exception
        {
            public ThisIsLeafException() : base() { }
            public ThisIsLeafException(string message) : base(message) { }
        }
    }
}
