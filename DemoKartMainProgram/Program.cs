using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    class Program
    {
        public List<Categories> Items = new List<Categories>();

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("         \n \n                    Welcome to Our Website                       \n \n  ");
                Console.WriteLine("Enter your user name : ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter your password : ");
                string pass = Console.ReadLine();
                User m = new User();
                int log = m.LoginCheck(user, pass);
               
                //Object declaration
                Product PrObj = new Product();
                OrderManage odrObj = new OrderManage();
                Cart CatObj = new Cart();

                //function creation
                void Display(int n)
                {
                    if (n == 1)
                    {
                        foreach (Product item in PrObj.Items)
                            if (item.Id >= 1 && item.Id < 9)
                            {
                                Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
                            }
                    }

                    else if (n == 2)
                    {
                        foreach (Product item in PrObj.Items)
                            if (item.Id >= 9 && item.Id < 17)
                            {
                                Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
                            }
                    }
                    else if (n == 3)
                    {
                        foreach (Product item in PrObj.Items)
                            if (item.Id >= 17 && item.Id < 25)
                            {
                                Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
                            }
                    }
                    else if (n == 4)
                    {
                        foreach (Product item in PrObj.Items)
                            if (item.Id >= 25 && item.Id < 32)
                            {
                                Console.WriteLine("Product ID : " + item.Id + "\n" + "Product Name : " + item.Name + "\n" + "Product Quantity : " + item.Quantity + "\n" + "Product Price : " + item.Quantity);
                            }
                    }
                    else
                        Console.WriteLine("Wrong CHOICE!!");
                }
                void ShowCart()
                {
                    Console.WriteLine("\n Your Cart Items: - \n");
                    foreach (var item in CatObj.cust_cart)
                    {

                        Console.WriteLine("\n Product ID : " + item.Id);
                        Console.WriteLine(" Product Name : " + item.Name);
                        Console.WriteLine(" Product Quantity in cart : " + item.Quantity);
                        Console.WriteLine(" Product Price after tax : " + item.Price);
                    }
                }

                if (log == 1)
                {
                    Console.WriteLine(" Select which categories do you want to see \n Enter 1 for Elcetronics \n Enter 2 for Clothing \n Enter 3 for Grocery \n Enter 4 for Cosmetics ");
                    int s = Convert.ToInt32(Console.ReadLine());

                    if (s == 1)
                    {
                        Display(s);
                        Console.WriteLine("Enter how many products do you want to add in Cart");
                        int num = Convert.ToInt32(Console.ReadLine());
                        double cost = 0;
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine("Enter Id of product to add in Cart");
                            int id = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in PrObj.Items)
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
                                    Product customer_cart = new Product(item.Id, item.Name, cost, Quant, 1, "Electronics");
                                    CatObj.cust_cart.Add(customer_cart);
                                }
                            }
                        }
                    }
                    else if (s == 2)
                    {
                        Display(s);
                        Console.WriteLine("Enter how many products do you want to add in Cart");
                        int num = Convert.ToInt32(Console.ReadLine());
                        double cost = 0;
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine("Enter Id of product to add in Cart");
                            int id = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in PrObj.Items)
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
                                    Product customer_cart = new Product(item.Id, item.Name, cost, Quant, 2, "Clothing");
                                    CatObj.cust_cart.Add(customer_cart);
                                }
                            }
                        }
                    }
                    else if (s == 3)
                    {
                        Display(s);
                        Console.WriteLine("Enter how many products do you want to add in Cart");
                        int num = Convert.ToInt32(Console.ReadLine());
                        double cost = 0;
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine("Enter Id of product to add in Cart");
                            int id = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in PrObj.Items)
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
                                    Product customer_cart = new Product(item.Id, item.Name, cost, Quant, 3, "Grocery");
                                    CatObj.cust_cart.Add(customer_cart);
                                }
                            }
                        }
                    }
                    else if (s == 4)
                    {
                        Display(s);
                        Console.WriteLine("Enter how many products do you want to add in Cart");
                        int num = Convert.ToInt32(Console.ReadLine());
                        double cost = 0;
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine("Enter Id of product to add in Cart");
                            int id = Convert.ToInt32(Console.ReadLine());

                            foreach (Product item in PrObj.Items)
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
                                    Console.WriteLine("Product amount is = " + cost);
                                    cost = cost + ((cost * 18) / 100);
                                    Console.WriteLine("Product amount after category tax = " + cost);
                                    Console.WriteLine("amount = " + cost);
                                    Product customer_cart = new Product(item.Id, item.Name, cost, Quant, 4, "Cosmetics");
                                    CatObj.cust_cart.Add(customer_cart);
                                }
                            }
                        }
                    }
                    else
                        Console.WriteLine("INVALID CHOICE!!");
                    ShowCart();
                    Console.WriteLine("Your total cart cost with category tax is: -");
                    double Tamount = CatObj.TotalCost();
                    Console.WriteLine(Tamount);
                    Console.WriteLine("Enter 1 for order cart items else enter zero: -");
                    int order = Convert.ToInt32(Console.ReadLine());
                    double Tprice = 0;
                    double Gprice = 0;
                    if (order == 1)
                    {
                        Console.WriteLine("enter reciever's name");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter reciever's address");
                        string address = Console.ReadLine();
                        Console.WriteLine("enter reciever's phone number");
                        long phone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("\n Customer Details \n");
                        Console.WriteLine(odrObj.GetInfo(name, address, phone));
                        Console.WriteLine("SELECT THE PAYMENT MODE");
                        Console.WriteLine("Enter 1 for cash \n Enter 2 for Credit card \n Enter 3 for debit card ");
                        int pay = Convert.ToInt32(Console.ReadLine());
                        if (pay == 1)
                        {
                            Console.WriteLine("HEKKO");
                            Console.WriteLine("Your total pay amount is :" + Tprice);
                        }
                        else if (pay == 2)
                        {
                            Gprice = Gprice + (Tamount * (3 / 100));
                            Tprice = Gprice + Tamount;
                            Console.WriteLine("Your total pay amount is :" + Tprice);
                        }
                        else if (pay == 3)
                        {
                            Tprice = Tamount + (Tamount * (4 / 100));
                            Console.WriteLine("Your total pay amount is :" + Tprice);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Place your order soon, items are limited in stock, Thank you!!");
                    }

                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
         }
      }
   }
}
