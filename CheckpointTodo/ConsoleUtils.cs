using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2_ToDo
{
	class ConsoleUtils
	{
		//global vairable
		App CallApp = new App();

		public static string AskForToDo()
		{
			Console.WriteLine("What do you want to do?");
			Console.WriteLine("Type 'delete' to delete an item, 'add' to add an item");
			Console.WriteLine("Type 'list done', to list all completed items, 'pending list' to list all pending items','all' to list all");
			string Task = Console.ReadLine();
			return Task;
		}
		public static string[] MethodAdding()
		{
			string[] newList = new string[2];

			Console.WriteLine("Describe your task");
			newList[0] = Console.ReadLine();
			Console.WriteLine("is this task done? write 'done' for done, and 'pending' if not");
			newList[1] = Console.ReadLine().ToLower();
			return newList;
		}
		public static int MethodDeleting()
		{

			Console.WriteLine("what Id do you want to delete?");
			int ID = Convert.ToInt32(Console.ReadLine());
			return ID;
		}
		public static int UpdateConsole()
		{

			Console.WriteLine("which item do you want to update?");
			int Id = Convert.ToInt32(Console.ReadLine());
			return Id;
		}
		public static void PrintList(List<ToDoItem> ListItems) 
		{
			foreach (ToDoItem T in ListItems)
			{
				Console.WriteLine("* * * * * * * * * * * * * * * *");
				Console.WriteLine("{0}-- {1}-- {2} ", T.Id, T.Description, T.Done);

			}
		}


	}
}