using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class ConsoleUtils
    {
        public static string DisplayMenu() //Main Menu
        {
            Console.WriteLine("Welcome to Your ToDo App. Choose an option and let's do this: ");
            Console.WriteLine("L: List all Items");
            Console.WriteLine("A: Add new Item");
            Console.WriteLine("U: Update an Item");
            Console.WriteLine("R: Remove an Item");
            Console.WriteLine("Q: Quit program");
            Console.WriteLine("Please choose your option: ");
            string answer = Console.ReadLine().ToUpper();
            return answer;
        }
        public static string ItemInfo()
        {
            Console.WriteLine("Enter item for the list: ");
            string info = Console.ReadLine();
            return info;
        }
        public static void PrintToDoItems(List<ToDoItems> list)
        {
            foreach(ToDoItems item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Description} - {item.Status}");
            }
        }
        public static int GetItemId()
        {
            Console.WriteLine("Enter the ID of the item: ");
            string userInput = Console.ReadLine();
            int itemId = int.Parse(userInput);
            return itemId;
        }
    }
}
