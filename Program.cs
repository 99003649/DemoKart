using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         \n \n                    Welcome to Our Website                       \n \n  ");
            Console.WriteLine("Enter your user name : ");
            string user = Console.ReadLine();
            Console.WriteLine("Enter your password : ");
            string pass = Console.ReadLine();
            User m = new User();
            int log = m.LoginCheck(user, pass);

            Categories catObj = new Categories();

            if (log == 1)
            {

                Console.WriteLine(" Select which categories do you want to see \n Enter 1 for Elcetronics \n Enter 2 for Clothing \n Enter 3 for Grocery \n Enter 4 for Cosmetics ");
                int s = Convert.ToInt32(Console.ReadLine());

                Cart cartObj = new Cart();
                cartObj.AddToCart(s);

                cartObj.showCart();
                
                Console.WriteLine(cartObj.TotalCost()); 

                /*if (s == 1)
                {
                    
                    Console.WriteLine(catObj.Display(s)); 
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
                                    // ShoppingObj.AddToCart(Quant);

                                    item.Price = item.Price * Quant;
                                    cost = cost + item.Price;

                                }

                            }


                        }

                    }
                }
                else if (s == 2)
                {
                    
                }

                else if (s == 3)
                {
                    Categories.Grocery();
                }

                else if (s == 4)
                {
                    Categories.Cosmetics();
                }

                Console.WriteLine("Enter how many products do you want to add in Cart");
                int n = Convert.ToInt32(Console.ReadLine());
                int price = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter Id of product to add in Cart");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Product item in ProductList)
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
                                // ShoppingObj.AddToCart(Quant);

                                item.Price = item.Price * Quant;
                                price = price + item.Price;

                            }

                        }


                    }

                }
                //  ShoppingObj.CalcPrice(price);

            }
            else
            {
                Console.WriteLine("Enter correct id & pass");
                Console.ReadLine();
            }
        }*/
            }
        }
    }
}
