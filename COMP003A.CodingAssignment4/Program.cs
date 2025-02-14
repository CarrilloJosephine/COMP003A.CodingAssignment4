/* -*-
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory msnagement application with a minimun of 10 elements in the collection
*/

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
            bool uselist = false;

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
                    Console.Write("Enter product name: ");
                string name = Console.ReadLine().Trim();

                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Product name cannot be empty.");
                    Console.Write("Enter product name: ");
                    name = Console.ReadLine().Trim();
                }

                int quantity;
                Console.Write("Enter product quantity: ");
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                    Console.Write("Enter product quantity: ");
                }

                if (useList)
                {
                    productNamesList.Add(name);
                    productQuantitiesList.Add(quantity);
                    Console.WriteLine("Product added successfully!");
                }
                else
                {
                    if (count >= 10)
                    {
                        Console.WriteLine("Inventory is full. Cannot add more products.");
                        return;
                    }

                    products[count] = name;
                    quantities[count] = quantity;
                    count++;
                    Console.WriteLine("Product added successfully!");
                }

                if (questionsMenu == 2)
                {
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine().Trim();

                    while (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Product name cannot be empty.");
                        Console.Write("Enter product name: ");
                        name = Console.ReadLine().Trim();
                    }

                    int quantityy;
                    Console.Write("Enter product quantity: ");
                    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                        Console.Write("Enter product quantity: ");
                    }

                    if (useList)
                    {
                        productList.Add(name);
                        productquantities
                            List.Add(quantity);
                        Console.WriteLine("Product added successfully!");
                    }
                    else
                    {
                        if (count >= 10)
                        {
                            Console.WriteLine("Inventory is full. Cannot add more products.");
                            return;
                        }

                        products[count] = name;
                        quantities[count] = quantity;
                        count++;
                        Console.WriteLine("Product added successfully!");
                    }
                }
                else if (questionsMenu == 3)
                    if ((useList && productNamesList.Count == 0) || (!useList && count == 0))
                    {
                        Console.WriteLine("\nNo products in inventory to update.");
                        return;
                    }

                Console.Write("Enter product name to update: ");
                string name = Console.ReadLine().Trim();
                int index = -1;

                if (useList)
                {
                    index = productNamesList.IndexOf(name);
                }
                else
                {
                    index = Array.IndexOf(products, name, 0, count);
                }

                if (index == -1)
                {
                    Console.WriteLine("Product not found.");
                    return;
                }

                int newQuantity;
                Console.Write("Enter new quantity: ");
                while (!int.TryParse(Console.ReadLine(), out newQuantity) || newQuantity < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                    Console.Write("Enter new quantity: ");
                }

                if (useList)
                {
                    productQuantitiesList[index] = newQuantity;
                }
                else
                {
                    quantities[index] = newQuantity;
                }

                Console.WriteLine("Product quantity updated successfully!");

                else if (questionsMenu == 4)
                {
                    {
                        if ((useList && productNamesList.Count == 0) || (!useList && count == 0))
                        {
                            Console.WriteLine("\nInventory is empty.");
                            return;
                        }

                        Console.WriteLine("\nInventory Summary:");

                        if (useList)
                        {
                            for (int i = 0; i < productNamesList.Count; i++)
                            {
                                Console.WriteLine($"- {productNamesList[i]}: {productQuantitiesList[i]}");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"- {products[i]}: {quantities[i]}");
                            }
                        }
                    }
                }
                
            }
        }

    }
}

      
