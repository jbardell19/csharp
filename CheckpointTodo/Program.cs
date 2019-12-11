using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace CheckpointTodo
{
    // ... Test against known Importance values.
        //if (value == Importance.Trivial)

	enum Priority { none, low, medium, high }
    enum Sort { ID, Pending, Complete, DateAscending, DateDecending, PritorityAscending, PriorityDescending}
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            
           
        }
    }
}
