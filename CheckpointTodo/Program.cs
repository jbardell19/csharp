using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace CheckpointTodo
{
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
