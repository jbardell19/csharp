using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2_ToDo
{
	class App
	{
		ItemRepository CallItemRep;
		public App()
		{
			CallItemRep = new ItemRepository();
		}
		public void CallsMethods()
		{
			string Task = ConsoleUtils.AskForToDo();

			if (Task == "delete")
			{
				int GetId = ConsoleUtils.MethodDeleting();
				CallItemRep.DeleteItem(GetId);
			}
			else if (Task == "add")
			{
				string[] addList = ConsoleUtils.MethodAdding();  ///task completed
				CallItemRep.AddItem(addList[0], addList[1]);
			}

			else if (Task == "list done")
			{
				List<ToDoItem> DoneList = CallItemRep.ListDoneItem();
				ConsoleUtils.PrintList(DoneList);
			}
			else if (Task == "pending list")
			{
				List<ToDoItem> PendingList = CallItemRep.ListPendingItem();
				ConsoleUtils.PrintList(PendingList);
			}
			else if (Task == "all")
			{
				List<ToDoItem> AllList = CallItemRep.StoreInfo();
				ConsoleUtils.PrintList(AllList);
			}
			else
			{
				Console.WriteLine("typing error, make sure all letters are lowercase");
			}
		}
		public static bool EndProgram()
		{
			Console.WriteLine("Do you want to continue? 'y' to continue, 'n' to end");
			string answer = Console.ReadLine();
			if (answer == "y")
			{
				return true;
			}
			else if (answer == "n")
			{
				return false;
			}
			else
				return true;
		}
	}
}