using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    internal abstract class ProductSell
    {
        public abstract string SellProduct(string custom_Id, string product_Name);
    }
}
