using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace ToDoApp
{
    class ItemContext : DbContext
    {

        public DbSet<ToDoItems> ToDoItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
