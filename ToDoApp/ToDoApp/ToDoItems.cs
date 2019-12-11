using System;

namespace ToDoApp
{
    public class ToDoItems
    {
        public int Id { get; private set; }
        public String Description { get; set; }
        public String Status { get; set; }
        public DateTime DueDate { get; set; }

        public ToDoItems(String description, String status, DateTime dueDate)
        {
            this.Description = description;
            this.Status = status;
            this.DueDate = dueDate;
        }
    }
}
