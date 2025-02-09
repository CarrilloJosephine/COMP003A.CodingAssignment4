/*
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory msnagement application with a minimun of 10 elements in the collection
*/


using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System! ");

            Console.WriteLine("Choose data storage type: ");
            Console.WriteLine("1. Arrays: ");
            Console.WriteLine("2. List: ");
            Console.WriteLine("Enter your choose.");
            int number = int.Parse(Console.ReadLine());

            string[] products = new string[10];
            int[] quantities = new int[10];
            int count = 0;
            List<string> productName = new List<string>();
            List<int> productQuantities = new List<int>();
            bool useList = number == 2;
            bool useArray = number == 1;

            while (true)
            {
                Console.WriteLine("\nInventory Management System Menu: ");
                Console.WriteLine("1. Add a product ");
                Console.WriteLine("2. update product quantity");
                Console.WriteLine("3. view inventory: ");
                Console.WriteLine("4. exit");
                Console.WriteLine("Enter your choice:");
                int questionsMenu = int.Parse(Console.ReadLine());

                if (questionsMenu == 1)
                {
                    Console.WriteLine("Enter product name: ");
                    string product = Console.ReadLine();
                    Console.WriteLine("Enter product quantity(how many you want a #) : ");
                    int quantity = Array.IndexOf(quantities,product);

                    if (count < productName.Count)
                    {
                        if (count < 10)
                        {
                            products[count] = "Apples";
                            quantities[count] = 50;
                            count++;
                            Console.WriteLine("Product added successfully!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!");
                    }
                    if (useArray)
                    {
                        products[count] = "Apples";
                        quantities[count] = 50;
                        count++;
                        Console.WriteLine("Product added successfully!");
                    }
                    else if (useList)
                    {
                        productName.Add("Apples");
                        productQuantities.Add(50);
                        Console.WriteLine("Product added successfully!");
                    }

                }
                else if (questionsMenu == 2)
                {
                    Console.WriteLine("update the product quantity: ");
                    string product = Console.ReadLine();
                    Console.WriteLine("new product quantity: ");
                    int index = Array.IndexOf(products, "apples");
                    if (index != -1)
                    {
                        productQuantities[index] = 100;
                        Console.Write("enter new product ammount: ");
                        productQuantities[index] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Product updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Product not found!");
                    }
                    if (useList) 
                    {
                        int quantity = productName.IndexOf("apples");
                        if (index != -1)
                        {
                            productQuantities[index] = 100;
                            Console.Write("enter new product ammount: ");
                            productQuantities[index] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Product updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Product not found!");
                        }
                    }
                }
                else if (questionsMenu == 3)
                {
                    Console.WriteLine("Inventory: ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(products[i] + " - " + quantities[i]);
                    }
                    if (useList)
                    {
                        for (int i = 0; i < productName.Count; i++)
                        {
                            Console.WriteLine(productName[i] + " - " + productQuantities[i]);
                        }
                    }

                }
                else if (questionsMenu == 4)
                {
                    Console.WriteLine("Thank you for using the Inventory Management System. Goodbyeeee! ");

                }

            }
        }
    }
}
