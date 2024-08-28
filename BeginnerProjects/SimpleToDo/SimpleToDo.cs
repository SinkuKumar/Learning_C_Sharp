using System;
using System.IO;

namespace BeginnerProjects.SimpleToDo
{
    class ToDo
    {
        static void Main(string[] args)
        {
            
            string filePath = "ToDo.txt";
            List<string> todos;

            if (File.Exists(filePath))
            {
                todos = new List<string>(File.ReadAllLines(filePath));
            }
            else
            {
                using (File.Create(filePath)) { }
                todos = new List<string>();
            }

            Console.WriteLine("Simple To Do App");
            while (true)
            {
                Console.WriteLine();
                if (todos.Count == 0)
                {
                    Console.WriteLine("You've no To Do items.");
                }
                else
                {
                    for(int i=0; i<todos.Count; i++) 
                    {
                        Console.WriteLine($"{i+1}: {todos[i]}");
                    }
                }
                Console.WriteLine("\n1. Create an item");
                Console.WriteLine("2. Delete an item");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddToDo(todos);
                        break;
                    case 2: 
                        DeleteToDo(todos);
                        break;
                    case 3:
                        File.WriteAllLines(filePath, todos);
                        Console.WriteLine("\nTo do items are written to the file successfully.");
                        Console.WriteLine("\nThank you for using to do app.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You've selected and invalid option");
                        break;
                }
            }

        }

        static void AddToDo(List<string> todos)
        {
            Console.WriteLine("\nEnter a to do item.");
            string todo = Console.ReadLine();
            todos.Add(todo);
            Console.WriteLine("The item has been added.");
        }

        static void DeleteToDo(List<string> todos)
        {
            try
            {
                Console.Write("\nEnter a to do id to delete: ");
                int todoIndex = int.Parse(Console.ReadLine());
                todos.RemoveAt(todoIndex - 1);
                Console.WriteLine("The item has been deleted.");
            }
            catch
            {
                Console.WriteLine("Unable to delete specified item.");
            }

        }
    }
}