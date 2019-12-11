using System;
using System.Collections.Generic;
using System.Text;

namespace CheckpointTodo

{

	class Todo
    {
        public int Id { get; private set; }
        public bool Complete { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool HasDue { get; set; }
        public DateTime Due { get; set; }
        public bool NearDue { get; set; }
        public bool PastDue { get; set; }
        public Priority Priority{get; set;}
        //Basic Construct
        public Todo(string Title, string Description)
        {
            Complete = false;
            this.Title = Title;
            this.Description = Description;
            this.HasDue = false;
            Priority = Priority.none;
        }
        public Todo(string Title, string Description, DateTime Due)
        {
            Complete = false;
            this.Title = Title;
            this.Description = Description;
            this.Due = Due;
            HasDue = true;
            GetDueStatus();
            Priority = Priority.none;
        }
        public Todo(string Title, string Description, Priority Priority)
        {
            Complete = false;
            this.Title = Title;
            this.Description = Description;
            this.Priority = Priority;
            this.HasDue = false;
        }
        public Todo(string Title, string Description, DateTime Due, Priority Priority)
        {
            Complete = false;
            this.Title = Title;
            this.Description = Description;
            this.Due = Due;
            HasDue = true;
            GetDueStatus();
            this.Priority = Priority;
        }
        public void GetDueStatus()
        {
            
                if (Due.Day >= (DateTime.Now.Day - 1) && Due.Day > DateTime.Now.Day)
                {
                    NearDue = true;
                    PastDue = false;
                }
                else if (Due.Day > DateTime.Now.Day)
                {
                    NearDue = false;
                    PastDue = true;
                } 
        }
        public void DisplayTodo()
        {
            String Marker, Time;
            if (Complete) { Marker = "Complete"; } else { Marker = "Pending"; }
            if (HasDue) Time = Due.ToShortDateString(); else Time = ""; 
            if (Priority == Priority.medium) Console.ForegroundColor = ConsoleColor.DarkYellow; 
            else if (Priority == Priority.high) Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"------------------------------------------------------------------------------\n" +
                          $"{Id}. [ {Marker} ]     {Title}          \n" +
                          $"{Description}\n" +
                          $"Due: {Time}        ");
            if (PastDue)
            {
                Console.Write("Todo is past due!");
            }else if (NearDue)
            {
                Console.Write("Todo is nearly due!");
            }
            Console.Write("\n" +
                          "Priority: ");
            if(Priority != Priority.none)
            {
                Console.Write($"{Priority}\n");
            }
            else Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------\n");
            Console.ResetColor();
        }
    }
}
