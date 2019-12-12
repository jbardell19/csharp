using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.EntityFrameworkCore;
//Super fun database stuff...do not break, it will crash the app
namespace ToDoApp
{
    public class ItemRepository
    {
        ItemContext context;

        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }

        public List<ToDoItems> GetToDoItems()
        {
            IEnumerable<ToDoItems> list = context.ToDoItems;
            return list.ToList();
        }

        public void AddItem(string description, string status, DateTime dueDate)
        {
            ToDoItems items = new ToDoItems(description, status, dueDate);
            context.ToDoItems.Add(items);
            context.SaveChanges();
        }

        public void UpdateItem(int id, string newDescription, string newStatus, DateTime newDueDate)
        {
            ToDoItems oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            oldItem.DueDate = newDueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }
        public void DeleteItem(int id)
        {
            ToDoItems items = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(items);
            context.SaveChanges();
        }
        public List<ToDoItems> Pending(int id)
        {
            IEnumerable<ToDoItems> list = context.ToDoItems.Where(item => item.Status == "Pending");
            return list.ToList();
        }
        public List<ToDoItems> Done(int id)
        {
            IEnumerable<ToDoItems> list = context.ToDoItems.Where(item => item.Status == "Done");
            return list.ToList();
        }

    }
}
