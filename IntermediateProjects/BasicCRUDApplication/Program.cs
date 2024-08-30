using System;
using System.IO;

namespace IntermediateProjects.BasicCRUDAplication
{
    class BasicCRUDApplication
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            Console.WriteLine("Welcome to basic CRUD application.");
            while (true)
            {
                Menu(items);
            }
        }

        static void Menu(List<string> items)
        {
            Console.WriteLine("\n1. Create an item");
            Console.WriteLine("2. Retrieve all items");
            Console.WriteLine("3. Update an item");
            Console.WriteLine("4. Delete an item");
            Console.WriteLine("5. Exit");
            Console.Write("\nSelect one of the options: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Create(items);
                    break;
                case 2:
                    Retrieve(items);
                    break;
                case 3:
                    Update(items);
                    break;
                case 4:
                    Delete(items);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid option, please try again.");
                    break;
            }
        }

        static void Create(List<string> items)
        {
            Console.Write("\nEnter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            Console.WriteLine("Item Added");
        }

        static void Retrieve(List<string> items)
        {
            if (items.Count > 0)
            {
                Console.WriteLine("\nItems: ");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {items[i]}");
                }
            }
            else
            {
                Console.WriteLine("\nNo item found");
            }
        }

        static void Update(List<string> items)
        {
            int itemsCount = items.Count;
            if (itemsCount > 0)
            {
                Console.Write("\nEnter the id of the item to udpate: ");
                int itemId = int.Parse(Console.ReadLine());
                if (itemsCount > 0 & itemId <= itemsCount)
                {
                    Console.WriteLine("Enter updated item: ");
                    string item = Console.ReadLine();
                    items.RemoveAt(itemId-1);
                    items.Insert(itemId-1, item);
                    Console.WriteLine("Item updated.");
                }
            }
            else
            {
                Console.WriteLine("\nNo item found");
            }
        }

        static void Delete(List<string> items)
        {
            int itemsCount = items.Count;
            if (itemsCount > 0)
            {
                Console.Write("\nEnter the id of the item to delete: ");
                int itemId = int.Parse(Console.ReadLine());
                if (itemsCount > 0 & itemId <= itemsCount)
                {
                    items.RemoveAt(itemId--);
                    Console.WriteLine("Item deleted.");
                }
            }
            else
            {
                Console.WriteLine("\nNo item found");
            }
        }
    }
}