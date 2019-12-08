using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2_ToDo
{
	class ItemRepository
	{
		ItemContext CallItemCon = new ItemContext();


		ItemContext context;

		public ItemRepository()
		{
			context = new ItemContext(); 
			context.Database.EnsureCreated();

		}
		public List<ToDoItem> StoreInfo() 
		{
			IEnumerable<ToDoItem> ListItems = context.itemRepositories;
			return ListItems.ToList();
		}

		public List<ToDoItem> ListDoneItem()
		{

			IEnumerable<ToDoItem> ListItems = context.itemRepositories.Where(X => X.Done == "done");
			return ListItems.ToList();

		}
		public List<ToDoItem> ListPendingItem() 
		{
			IEnumerable<ToDoItem> ListItems = context.itemRepositories.Where(X => X.Done == "pending");
			return ListItems.ToList();

		}


		public void AddItem(string description, string done)
		{
			ToDoItem Item = new ToDoItem(description, done);
			context.itemRepositories.Add(Item); //?????
			context.SaveChanges();
		}
		public void DeleteItem(int Id)
		{
			ToDoItem SearchItem = context.itemRepositories.Where(X => X.Id == Id).FirstOrDefault();
			context.Remove(SearchItem);
			context.SaveChanges();

		}
		public void Update(string description, string done, int Id)
		{
			ToDoItem SearchItem = context.itemRepositories.Where(X => X.Id == Id).FirstOrDefault();
			SearchItem.Description = description;
			SearchItem.Done = done;

			context.Update(SearchItem);
			context.SaveChanges();

		}
	}
}