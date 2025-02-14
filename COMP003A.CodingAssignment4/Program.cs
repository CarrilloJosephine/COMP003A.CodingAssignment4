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
                    Console.WriteLine("2. Update product quantity ");
                    Console.WriteLine("3. View inventory ");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    int questionsMenu = int.Parse(Console.ReadLine());

                    if (questionsMenu == 1)
                    {
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();

                        int quantity;
                        Console.Write("Enter product quantity: ");
                        int quantitites = int.Parse(Console.ReadLine());


                        if (useList)
                        {
                            productName.Add(name);
                            productQuantities.Add(quantity);
                            Console.WriteLine("Product added successfully!");
                        }
                        else if (useArray)
                        {
                            if (count >= 10)
                            {
                                Console.WriteLine("Inventory is full!");
                            }
                            else
                            {
                                products[count] = name;
                                quantities[count] = quantity;
                                count++;
                                Console.WriteLine("Product added successfully!");
                            }
                        }
                    }
                    else if (questionsMenu == 2)
                    {
                        Console.Write("Enter product name to update: ");
                        string name = Console.ReadLine().Trim();

                        int index = -1;
                        if (useList)
                        {
                            index = productName.IndexOf(name);
                        }
                        else if (useArray)
                        {
                        int indexnull = Array.IndexOf(products, name);           // tried useing null to get rid of swiggly line dont think used correctly            
                        }

                        if (index == -1)
                        {
                            Console.WriteLine("Product not found.");
                        }
                        else
                        {
                            int newQuantity;
                            Console.Write("Enter new quantity: ");
                            quantities[index] = int.Parse(Console.ReadLine());
                            {
                            Console.WriteLine("Invalid input.");
                                Console.Write("Enter new quantity: ");
                            }

                            if (useList)
                            {
                                productQuantities[index] = newQuantity;
                            }
                            else if (useArray)
                            {
                                quantities[index] = newQuantity;
                            }

                            Console.WriteLine("Product quantity updated successfully!");
                        }
                    }
                    else if (questionsMenu == 3)                                        // recheck 2 and 3 to convert check loop in video
                    {
                        Console.WriteLine("\nInventory Summary:");

                        if (useList)
                        {
                            if (productName.Count == 0)
                            {
                                Console.WriteLine("Inventory is empty.");
                            }
                            else
                            {
                                for (int i = 0; i < productName.Count; i++)
                                {
                                    Console.WriteLine($"{productName[i]} - {productQuantities[i]}");
                                }
                            }
                        }
                        else if (useArray)
                        {
                            if (count == 0)
                            {
                                Console.WriteLine("Inventory is empty.");
                            }
                            else
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine($"{products[i]} - {quantities[i]}");
                                }
                            }
                        }
                    }
                    else if (questionsMenu == 4)
                    {
                        Console.WriteLine("Thank you for using the Inventory Management System. Goodbyeee!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 & 4.");
                    }
                }
            }
        }
    }
