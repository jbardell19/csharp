using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
	class MainClass
	{
		static string userChoice;
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the student's full name or type 'finished' when done");
			userChoice = Console.ReadLine().ToLower();
			Dictionary<string, string> Gradebook = new Dictionary<string, string>();
			while (userChoice != "finished")
			{
				Console.WriteLine("Enter each assignment number grade separated by a space");
				string studentGrades = Console.ReadLine();
				Gradebook.Add(userChoice, studentGrades);
				Console.WriteLine("Enter the student's full name or type 'finished' when done");
				userChoice = Console.ReadLine().ToLower();
			}
			int lowestGrade;
			int highestGrade;
			double averageGrade; //var for avg grade
			foreach (string key in Gradebook.Keys)
			{
				Console.WriteLine($"Name: {key}");
				Console.WriteLine($"Grades: {Gradebook[key]}");
				int[] SingleGrades;
				SingleGrades = Array.ConvertAll<string, int>(Gradebook[key].Split(), Convert.ToInt32);
				//hi low avg
				lowestGrade = SingleGrades.Min();
				highestGrade = SingleGrades.Max();
				averageGrade = SingleGrades.Average();
				Console.WriteLine(key + " ");
				Console.WriteLine(key + "'s lowest grade is: " + lowestGrade);
				Console.WriteLine(key + "'s highest grade is: " + highestGrade);
				Console.WriteLine(key + "'s average grade is: " + averageGrade);
			}
		}
	}
}
