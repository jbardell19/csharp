using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine("Please choose rock, paper or scissors:");
            string Guess = Console.ReadLine();
            RockPaperScissor(Guess);
        }

        public static void RockPaperScissor(string Guess)
        {
            Random generator = new Random();
            //creates a number 0, 1 or 2
            int RandomNumber = generator.Next(0, 3);
            if (RandomNumber == 0)
            {
                if (Guess == "rock")
                {
                    Console.WriteLine("Computer Chose Rock");
                    Console.WriteLine("It's a TIE");
                }
                else if (Guess == "paper")
                {
                    Console.WriteLine("Computer Chose Rock");
                    Console.WriteLine("You WIN!! Paper beats Rock");
                }

                else if (Guess == "scissors")
                {
                    Console.WriteLine("Computer Chose Rock");
                    Console.WriteLine("Sorry you LOSE! Rock beats Scissors");
                }
            }
            else if (RandomNumber == 1)
            {
                if (Guess == "rock")
                {
                    Console.WriteLine("Computer chose Paper");
                    Console.WriteLine("Sorry you LOSE! Paper beat Rock");
                }
                else if (Guess == "paper")
                {
                    Console.WriteLine("Computer chose Paper");
                    Console.WriteLine("It's a TIE");
                }
                else if (Guess == "scissors")
                {
                    Console.WriteLine("Computer chose Paper");
                    Console.WriteLine("You WIN!! Scissors beats Paper");
                }
            }
            else if (RandomNumber == 2)
            {
                if (Guess == "rock")
                {
                    Console.WriteLine("Computer chose Scissors");
                    Console.WriteLine("You WIN!! Rock beats Scissors");
                }
                else if (Guess == "paper")
                {
                    Console.WriteLine("Computer chose Scissors");
                    Console.WriteLine("Sorry you LOSE!! Scissors beats Paper");
                }
                else if (Guess == "scissors")
                {
                    Console.WriteLine("Computer chose Scissors");
                    Console.WriteLine("It's a TIE");
                }

            }
        }
    }
}
