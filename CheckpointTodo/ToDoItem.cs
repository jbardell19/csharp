using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2_ToDo
{
	class ToDoItem
	{
		public string Description { get; set; }
		public int Id { get; private set; }
		public string Done { get; set; }

		public ToDoItem(string description, string done)
		{
			Description = description;
			Done = done;
		}
	}
}
