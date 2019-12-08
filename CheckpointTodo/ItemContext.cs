using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace CheckPoint2_ToDo
{
	class ItemContext : DbContext
	{
		public DbSet<ToDoItem> itemRepositories { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
			DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
			string DataBaseFile = Path.Combine(ProjectBase.FullName, "ToDo.db");
			optionsBuilder.UseSqlite("Data source=" + DataBaseFile);
		}
	}
}