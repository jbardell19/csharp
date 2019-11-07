using System;
using System.Collections.Generic;

namespace toDo
{
    class Program
    {
        static List<ToDoItem> listOfItems = new List<ToDoItem>();
        public static string answer;
        static void Main(string[] args)
        {
            ToDoItem firstItem = new ToDoItem("homework", "11-10-19", "high");
            firstItem.DueDate = "11-10";
            ToDoItem.AskQuestion(answer, listOfItems);
            ToDoItem.PrintOutList(listOfItems);
            Console.ReadKey();
        }
    }

    class ToDoItem
    {
        public string Description;
        public string DueDate;
        public String Priority;
        public ToDoItem()
        {
        }
        public ToDoItem(string describe, string date, string importance)
        {
            Description = describe;
            DueDate = date;
            Priority = importance;
        }
        public static void AskQuestion(string answer, List<ToDoItem> listOfItems)
        {
            Console.WriteLine("Do you want to add an item to your to do list? Type 'y' for yes and 'n' for no");
            answer = Console.ReadLine();
            while (answer == "y")
            {
                Console.WriteLine("Describe your task");
                string describe = Console.ReadLine();
                Console.WriteLine("When is this due? (enter dates as mm-dd");
                string date = Console.ReadLine();
                Console.WriteLine("Is this a high, medium, or low priority?");
                string importance = Console.ReadLine();
                listOfItems.Add(new ToDoItem(describe, date, importance));
                Console.WriteLine("Do you wan to add an item to your to do list? Type 'y' for yes and 'n' for no");
                answer = Console.ReadLine();
            }
        }
        public static void PrintOutList(List<ToDoItem> listOfItems)
        {
            foreach (ToDoItem item in listOfItems)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("task: " + item.Description + " Due by: " + item.DueDate + " Priority: " + item.Priority);
                Console.WriteLine("*******************************************");
            }
        }
    }
}
