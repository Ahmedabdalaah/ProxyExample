using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    internal class CocerateSell : ProductSell
    {
        public override string SellProduct(string custom_Id, string product_Name)
        {
            return $"Customer number {custom_Id} sells {product_Name}";
        }
    }
}
