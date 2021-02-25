using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    class Product
    {       
            public int Id;
            public string Name;
            public double Price;
            public int Quantity;   


            public Product()
            {
                Id = 0;
                Name = null;
                Price = 0.0;
                Quantity = 0;
            }

            public Product(int Id, string Name, double Price, int Quantity)
            {
                this.Id = Id;
                this.Name = Name;
                this.Price = Price;
                this.Quantity = Quantity;
            }        
    }
}
