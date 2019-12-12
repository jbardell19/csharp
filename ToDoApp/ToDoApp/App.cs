using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;

namespace ToDoApp
{

    public class App
    {
        ItemRepository repo;

        public App()
        {
            repo = new ItemRepository();
        }
        public void Run()
        {
            string answer = ConsoleUtils.DisplayMenu();
            while (answer != "Q")
            {
                if (answer == "L")
                {
                    repo.GetToDoItems();
                    List<ToDoItems> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                }
                if (answer == "A")
                {
                    Console.WriteLine("Add a Description: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Enter a Importance Status for item: (Low, Medium, High) ");
                    string Status = Console.ReadLine();
                    Console.WriteLine("Enter a Due Date: month/day/year ");
                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.AddItem(Description, Status, DueDate);
                }
                if (answer == "U")
                {
                    Console.WriteLine(" What is the ID of what needs to be updated: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Update your Description of the item: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Update Importance Status of the item: ");
                    string Status = Console.ReadLine();
                    Console.WriteLine("Update your due date of the item: ");
                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.UpdateItem(Id, Description, Status, DueDate);
                }
                if (answer == "R")
                {
                    Console.WriteLine("What is the ID of the item you want to Delete: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    repo.DeleteItem(Id);
                }
                answer = ConsoleUtils.DisplayMenu();
            }
        }
    }
}
