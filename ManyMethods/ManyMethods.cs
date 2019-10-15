using System;

namespace ManyMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			hello();
			addition();
			catDog();
			oddEvent();
			inches();
			echo();
			killGrams();
			printDateTime();
			printAge();
			guess();
		}

		static void hello ()
		{
			Console.WriteLine("Hello! What is your name?");

			string name = Console.ReadLine();

			Console.WriteLine("Bye" + name);


                }

		static void addition()
		{
			Console.WriteLine("What is the first number you'd like to add? ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("What is the second number you'd like to add? ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			int added = num1 + num2;
			Console.WriteLine("The two numbers added together are: " + added);
		}


		static void catDog()
		{
			Console.WriteLine("Do you prefer cats or dogs? ");
			string answer = Console.ReadLine();
			if (answer == "cats")
			{
				Console.WriteLine("MEOW!");
			}
			if (answer == "dogs")
			{
				Console.WriteLine("WOOF!!!");
			}
		}


		static void oddEvent()
		{
				Console.WriteLine("Please enter a number: ");
				var answer = Convert.ToInt32(Console.ReadLine());
				if (answer % 2 == 0)
				{
					Console.WriteLine("That number is even");

				}
				else
				{
					Console.WriteLine("That number is odd");
				}
			
		}


		static void inches()
		{
			Console.WriteLine("Please enter a height in feet");
			int answer = Convert.ToInt32(Console.ReadLine());
			int ConvertedHeight = answer * 12;
			Console.WriteLine("The height you entered in inches is: " + ConvertedHeight);

		}


		static void echo()
		{
			Console.WriteLine("What word would you like to echo?");
			string answer = Console.ReadLine();
			Console.WriteLine(answer.ToUpper());
			Console.WriteLine(answer.ToLower());
			Console.WriteLine(answer.ToLower());
		}


		static void killGrams()
		{
			Console.WriteLine("Enter a weight in pounds to convert");
			float answer = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The weight in Killograms is: " + (answer / 2.2));

		}


		static void date()
		{
			Console.WriteLine("Do you know what today is?");
			DateTime aDay = DateTime.Now;
			Console.WriteLine(aDay.ToString("dddd, dd MMMM yyyy"));
		}


		static void age()
		{
			Console.WriteLine("What year were you born?");
			int answer = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You are " + (2019 - answer) + " years old");
		}

		static void guess()
		{
			Console.WriteLine("Guess what word I'm thinking of?");
			string answer = Console.ReadLine();
			if (answer == "csharp")
				Console.WriteLine("CORRECT!!");
			else
			{
				Console.WriteLine("WRONG!!");
			}


		}
	}

}
