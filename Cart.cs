using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    class Cart
    {
        Categories catObj = new Categories();
        List<Product> cust_cart = new List<Product>();
        public void AddToCart(int s)
        {
            if (s == 1)
            {

                catObj.Display(s);
                Console.WriteLine("Enter how many products do you want to add in Cart");
                int num = Convert.ToInt32(Console.ReadLine());
                decimal cost = 0;
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Enter Id of product to add in Cart");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Product item in catObj.Electronics)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\nEnter how many quantity you want\n");
                            int Quant = Convert.ToInt32(Console.ReadLine());

                            
                            if (Quant > item.Quantity)
                            {
                                Console.WriteLine("Currently out of stock\n");
                            }
                            else
                            {
                                item.Quantity = item.Quantity - Quant;

                            }
                            cost = item.Price * Quant;
                            Console.WriteLine("amount = " + cost);

                            cost = cost + ((cost * 18) / 100);                            
                            Console.WriteLine("GST amount = " + cost);
                            Product customer_cart = new Product(item.Id, item.Name,cost,Quant);
                            cust_cart.Add(customer_cart);

                        }
                    }

                }
            }

            else if (s == 2)
            {

                catObj.Display(s);
                Console.WriteLine("Enter how many products do you want to add in Cart");
                int num = Convert.ToInt32(Console.ReadLine());
                decimal cost = 0;
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Enter Id of product to add in Cart");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Product item in catObj.Clothing)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\nEnter how many quantity you want\n");
                            int Quant = Convert.ToInt32(Console.ReadLine());

                            
                            if (Quant > item.Quantity)
                            {
                                Console.WriteLine("Currently out of stock\n");
                            }
                            else
                            {
                                item.Quantity = item.Quantity - Quant;

                            }
                            cost = item.Price * Quant;
                            Console.WriteLine("amount = " + cost);

                            cost = cost + ((cost * 7) / 100);
                            Console.WriteLine("GST amount = " + cost);
                            Product customer_cart = new Product(item.Id, item.Name, cost, Quant);
                            cust_cart.Add(customer_cart);

                        }
                    }

                }
            }

            else if (s == 3)
            {

                catObj.Display(s);
                Console.WriteLine("Enter how many products do you want to add in Cart");
                int num = Convert.ToInt32(Console.ReadLine());
                decimal cost = 0;
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Enter Id of product to add in Cart");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Product item in catObj.Grocery)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\nEnter how many quantity you want\n");
                            int Quant = Convert.ToInt32(Console.ReadLine());

                            
                            if (Quant > item.Quantity)
                            {
                                Console.WriteLine("Currently out of stock\n");
                            }
                            else
                            {
                                item.Quantity = item.Quantity - Quant;

                            }
                            cost = item.Price * Quant;
                            
                            Console.WriteLine("amount = " + cost);

                            cost = cost + ((cost * 4) / 100);
                            Console.WriteLine("GST amount = " + cost);

                            Console.WriteLine("amount = " + cost);
                            Product customer_cart = new Product(item.Id, item.Name, cost, Quant);
                            cust_cart.Add(customer_cart);

                        }
                    }

                }
            }

            else if (s == 4)
            {

                catObj.Display(s);
                Console.WriteLine("Enter how many products do you want to add in Cart");
                int num = Convert.ToInt32(Console.ReadLine());
                decimal cost = 0;
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine("Enter Id of product to add in Cart");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Product item in catObj.Cosmetics)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine("Product id : " + item.Id);
                            Console.WriteLine("Product Name : " + item.Name);
                            Console.WriteLine("Product Price : " + item.Price);
                            Console.WriteLine("Product Quantity : " + item.Quantity);
                            Console.WriteLine("\nEnter how many quantity you want\n");
                            int Quant = Convert.ToInt32(Console.ReadLine());

                            
                            if (Quant > item.Quantity)
                            {
                                Console.WriteLine("Currently out of stock\n");
                            }
                            else
                            {
                                item.Quantity = item.Quantity - Quant;

                            }
                            cost = item.Price * Quant;
                            Console.WriteLine("amount = " + cost);

                            cost = cost + ((cost * 18) / 100);
                            Console.WriteLine("GST amount = " + cost);

                            Console.WriteLine("amount = " + cost);
                            Product customer_cart = new Product(item.Id, item.Name, cost, Quant);
                            cust_cart.Add(customer_cart);

                        }
                    }

                }
            }
            else
                Console.WriteLine("INVALID CHOICE!!");
        }

        public void showCart()
        { 
            foreach(var item in cust_cart)
            {
                Console.WriteLine("Product ID : "+item.Id);
                Console.WriteLine("Product Name : " + item.Name);
                Console.WriteLine("Product Quantity : " + item.Quantity);
                Console.WriteLine("Product Price : " + item.Price);
            }
        }
           
    }
}
