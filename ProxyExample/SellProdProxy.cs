using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample
{
    internal class SellProdProxy
    {
        private ProductSell prductsell;
        Dictionary<string, int> productCount = new Dictionary<string, int>();
        public string SellProduct(string custom_id , string product_name)
        {
            if(prductsell == null)
            {
                prductsell = new CocerateSell();
            }
            // if not found in dictionary ( first call )
            if (!productCount.ContainsKey(custom_id))
            {
                productCount.Add(custom_id, 1);
                return prductsell.SellProduct(custom_id, product_name);
            }
            else
            {
                var customkey = productCount.Where(x => x.Key == custom_id).FirstOrDefault();
                if (customkey.Value >= 2)
                {
                    return " Error: Not Sell";
                }
                else
                {
                    productCount[custom_id] = customkey.Value+1;
                    return prductsell.SellProduct(custom_id, product_name);
                }
            }
        }
    }
}
