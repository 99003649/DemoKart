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
        public Categories Categories = new Categories();
        public Product(int Id, string Name, double Price, int Quantity, int C_id, string C_name)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            Categories.C_id = C_id;
            Categories.C_name = C_name;
        }
        public List<Product> Items = new List<Product>();
        public Product()
       {
            Items.Add(new Product(1, "Phone", 250, 6, 1, "Electronics"));
            Items.Add(new Product(2, "Laptop", 170, 4, 1, "Electronics"));
            Items.Add(new Product(3, "Earphone", 40, 2, 1, "Electronics"));
            Items.Add(new Product(4, "Charger", 30, 3, 1, "Electronics"));
            Items.Add(new Product(5, "Powerbank", 25, 5, 1, "Electronics")); 
            Items.Add(new Product(6, "Phone case", 5, 3, 1, "Electronics"));
            Items.Add(new Product(7, "Data Cable", 6, 1, 1, "Electronics"));
            Items.Add(new Product(8, "Adapter", 15, 3, 1, "Electronics"));
            Items.Add(new Product(9, "Pant", 150, 6, 2, "Clothing"));
            Items.Add(new Product(10, "Shirt", 170, 4, 2, "Clothing"));
            Items.Add(new Product(11, "Jeans", 20, 2, 2, "Clothing"));
            Items.Add(new Product(12, "Top", 30, 3, 2, "Clothing"));
            Items.Add(new Product(13, "Tie", 25, 5, 2, "Clothing"));
            Items.Add(new Product(14, "Kurtas", 5, 3, 2, "Clothing"));
            Items.Add(new Product(15, "Tshirt", 6, 1, 2, "Clothing"));
            Items.Add(new Product(16, "Hoddies", 15, 3, 2, "Clothing"));
            Items.Add(new Product(17, "Biscuits", 150, 6, 3, "Grocery"));
            Items.Add(new Product(18, "ColdDrinks", 170, 4, 3, "Grocery"));
            Items.Add(new Product(19, "Butter", 20, 2, 3, "Grocery"));
            Items.Add(new Product(20, "Bread", 30, 3, 3, "Grocery"));
            Items.Add(new Product(21, "BreadSpread", 25, 5, 3, "Grocery"));
            Items.Add(new Product(22, "Atta", 5, 3, 3, "Grocery"));
            Items.Add(new Product(23, "Oil", 6, 1, 3, "Grocery"));
            Items.Add(new Product(24, "Spices", 15, 3, 3, "Grocery"));
            Items.Add(new Product(25, "HairOil", 150, 6, 3, "Cosmetics"));
            Items.Add(new Product(26, "Shampoo", 170, 4, 3, "Cosmetics"));
            Items.Add(new Product(27, "Facewash", 20, 2, 3, "Cosmetics"));
            Items.Add(new Product(28, "Bodywash", 30, 3, 3, "Cosmetics"));
            Items.Add(new Product(29, "Soap", 25, 5, 3, "Cosmetics"));
            Items.Add(new Product(30, "FaceCream", 5, 3, 3, "Cosmetics"));           
        }
         
    }
}
