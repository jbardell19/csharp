using System;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Hello();
            Addition();
            CatDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            date();
            age();
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
			Console.WriteLine("What numbers would you like to add");
		}


		static void catDog()
		{
			Console.WriteLine("Do you perfer dogs or cats?");
		}


		static void oddEvent()
		{
			Console.WriteLine("What is your number?");
		}


		static void inches()
		{
			Console.WriteLine("What is your height in feet?");
		}


		static void echo()
		{
			Console.WriteLine("What word would you like to echo?");
		}


		static void killGrams()
		{
			Console.WriteLine("What is your weight?");
		}


		static void date()
		{
            Console.WriteLine("")
		}


		static void age()
		{
			Console.WriteLine("What year were you born?");
		}

		static void guess()
		{
			Console.WriteLine("Guess what word I'm thinking of?");
		}


