﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    class Categories
    {
        public List<Product> Electronics = new List<Product>();
        public List<Product> Clothing = new List<Product>();
        public List<Product> Grocery = new List<Product>();
        public List<Product> Cosmetics = new List<Product>();
        public List<Product> Null = new List<Product>();
        
        public Categories()
        {
            
            Electronics.Add(new Product(1, "Phone", 250, 6));
            Electronics.Add(new Product(2, "Laptop", 170, 4));
            Electronics.Add(new Product(3, "Earphone", 40, 2));
            Electronics.Add(new Product(4, "Charger", 30, 3));
            Electronics.Add(new Product(5, "Powerbank", 25, 5));
            Electronics.Add(new Product(6, "Phone case", 5, 3));
            Electronics.Add(new Product(7, "Data Cable", 6, 1));
            Electronics.Add(new Product(8, "Adapter", 15, 3));

            
            Clothing.Add(new Product(1, "Pant", 150, 6));
            Clothing.Add(new Product(2, "Shirt", 170, 4));
            Clothing.Add(new Product(3, "Jeans", 20, 2));
            Clothing.Add(new Product(4, "Top", 30, 3));
            Clothing.Add(new Product(5, "Tie", 25, 5));
            Clothing.Add(new Product(6, "Kurtas", 5, 3));
            Clothing.Add(new Product(7, "Tshirt", 6, 1));
            Clothing.Add(new Product(8, "Hoddies", 15, 3));
            

            Grocery.Add(new Product(1, "Biscuits", 150, 6));
            Grocery.Add(new Product(2, "ColdDrinks", 170, 4));
            Grocery.Add(new Product(3, "Butter", 20, 2));
            Grocery.Add(new Product(4, "Bread", 30, 3));
            Grocery.Add(new Product(5, "BreadSpread", 25, 5));
            Grocery.Add(new Product(6, "Atta", 5, 3));
            Grocery.Add(new Product(7, "Oil", 6, 1));
            Grocery.Add(new Product(8, "Spices", 15, 3));


            
            Cosmetics.Add(new Product(1, "HairOil", 150, 6));
            Cosmetics.Add(new Product(2, "Shampoo", 170, 4));
            Cosmetics.Add(new Product(3, "Facewash", 20, 2));
            Cosmetics.Add(new Product(4, "Bodywash", 30, 3));
            Cosmetics.Add(new Product(5, "Soap", 25, 5));
            Cosmetics.Add(new Product(6, "FaceCream", 5, 3));

        }


        public void Display(int n)
        {
            if (n == 1) 
            {
                foreach (Product item in Electronics)
                    Console.WriteLine("Product ID : "+item.Id + "\n" + "Product Name : "+item.Name+"\n"+"Product Quantity : "+item.Quantity+"\n"+"Product Price : "+item.Quantity);
            }

            else if (n == 2)
            {
                foreach (Product item in Clothing)
                    Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
            }

            else if (n == 3)
            {
                foreach (Product item in Grocery)
                    Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
            }

            else if (n == 4)
            {
                foreach (Product item in Cosmetics)
                    Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
            }

            else
                Console.WriteLine("INVALID CHOICE!!");


        }
        /*class Categories : Product
        {
            public static void Electronics()
            {
                List<Product> 
                    = new List<Product>(10);
                Product[] P = new Product[10];
                Shopping ShoppingObj = new Shopping();
                for (int i = 1; i < 9; i++)
                {
                    P[1] = new Product(1, "Phone", 250, 6);
                    P[2] = new Product(2, "Laptop", 170, 4);
                    P[3] = new Product(3, "Earphone",40, 2);
                    P[4] = new Product(4, "Charger", 30, 3);
                    P[5] = new Product(5, "Powerbank", 25, 5);
                    P[6] = new Product(6, "Phone case", 5, 3);
                    P[7] = new Product(7, "Data Cable", 6, 1);
                    P[8] = new Product(8, "Adapter", 15, 3);
                    ProductList1.Add(P[i]);
                }
                foreach (Product item in ProductList1)
                {
                    Console.WriteLine("Product id is: " + item.Id);
                    Console.WriteLine("Product Name: " + item.Name);
                    Console.WriteLine("Product Price: " + item.Price);
                    Console.WriteLine("Product Quantity: " + item.Quantity + "\n ");
                }
            }
            public static void Clothing()
            {
                List<Product> ProductList2 = new List<Product>(10);
                Product[] P = new Product[10];
                Shopping ShoppingObj = new Shopping();
                for (int i = 1; i < 9; i++)
                {
                    P[1] = new Product(1, "Pant", 150, 6);
                    P[2] = new Product(2, "Shirt", 170, 4);
                    P[3] = new Product(3, "Jeans", 20, 2);
                    P[4] = new Product(4, "Top", 30, 3);
                    P[5] = new Product(5, "Tie", 25, 5);
                    P[6] = new Product(6, "Kurtas", 5, 3);
                    P[7] = new Product(7, "Tshirt", 6, 1);
                    P[8] = new Product(8, "Hoddies", 15, 3);
                    ProductList2.Add(P[i]);
                }
                foreach (Product item in ProductList2)
                {
                    Console.WriteLine("Product id is: " + item.Id);
                    Console.WriteLine("Product Name: " + item.Name);
                    Console.WriteLine("Product Price: " + item.Price);
                    Console.WriteLine("Product Quantity: " + item.Quantity + "\n ");
                }
            }
            public static void Grocery()
            {
                List<Product> ProductList3 = new List<Product>(10);
                Product[] P = new Product[10];
                Shopping ShoppingObj = new Shopping();
                for (int i = 1; i < 9; i++)
                {
                    P[1] = new Product(1, "Biscuits", 150, 6);
                    P[2] = new Product(2, "ColdDrinks", 170, 4);
                    P[3] = new Product(3, "Butter", 20, 2);
                    P[4] = new Product(4, "Bread", 30, 3);
                    P[5] = new Product(5, "BreadSpread", 25, 5);
                    P[6] = new Product(6, "Atta", 5, 3);
                    P[7] = new Product(7, "Oil", 6, 1);
                    P[8] = new Product(8, "Spices", 15, 3);
                    ProductList3.Add(P[i]);
                }
                foreach (Product item in ProductList3)
                {
                    Console.WriteLine("Product id is: " + item.Id);
                    Console.WriteLine("Product Name: " + item.Name);
                    Console.WriteLine("Product Price: " + item.Price);
                    Console.WriteLine("Product Quantity: " + item.Quantity + "\n ");
                }
            }
            public static void Cosmetics()
            {
                List<Product> ProductList4 = new List<Product>(10);
                Product[] P = new Product[10];
                Shopping ShoppingObj = new Shopping();
                for (int i = 1; i < 9; i++)
                {
                    P[1] = new Product(1, "HairOil", 150, 6);
                    P[2] = new Product(2, "Shampoo", 170, 4);
                    P[3] = new Product(3, "Facewash", 20, 2);
                    P[4] = new Product(4, "Bodywash", 30, 3);
                    P[5] = new Product(5, "Soap", 25, 5);
                    P[6] = new Product(6, "ColdCream", 5, 3);

                    ProductList4.Add(P[i]);
                }
                foreach (Product item in ProductList4)
                {
                    Console.WriteLine("Product id is: " + item.Id);
                    Console.WriteLine("Product Name: " + item.Name);
                    Console.WriteLine("Product Price: " + item.Price);
                    Console.WriteLine("Product Quantity: " + item.Quantity + "\n ");
                }
            }
        }*/
    }
}
