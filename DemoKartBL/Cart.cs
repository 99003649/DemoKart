using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    public class Cart
    {
        Categories catObj = new Categories();
        public List<Product> cust_cart = new List<Product>();
        Product PrObj = new Product();
        
       
        public double TotalCost()
        {
            double tCost = 0;
            foreach (var item in cust_cart)
            {
                tCost = tCost + item.Price;

            }
            return tCost;
        }
    }
}
