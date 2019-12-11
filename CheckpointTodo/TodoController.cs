using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;

namespace CheckpointTodo

{
	class TodoController: DbContext
    {
        public DbSet<Todo> Todos { get; set; } 

        //DB link
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
            string DatabaseFile = Path.Combine(ProjectBase.FullName, "Todo.db");
            optionsBuilder.UseSqlite("Data Source =" + DatabaseFile);
        }
        public void DisplayByTitle()
        {
            
            List<Todo> TempList = new List<Todo>(); 
            
            foreach(Todo item in Todos)
            {
                TempList.Add(item);
            }
            List<Todo> SortedList = TempList.OrderBy(o => o.Title).ToList();
            
            
        }
    }
}
