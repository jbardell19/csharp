using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterMind
{
    class Program
    {
        static bool isRunning = true;
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int colorRandom1 = rnd.Next(1, 4);
            int colorRandom2 = rnd.Next(1, 4);
            do
            {
                Console.WriteLine(" I am thinking of 2 random colors");
                Console.WriteLine("Please choose from red, yellow, & blue");
                Console.WriteLine("Enter your first color");
                string colorChoice1 = Console.ReadLine().ToLower();
                Console.WriteLine("Enter your next guess");
                string colorChoice2 = Console.ReadLine().ToLower();
                int colorA = 0;
                int colorB = 0;
                //1st color
                if (colorChoice1 == "red")
                {
                    colorA = 1;
                }
                else if (colorChoice1 == "yellow")
                {
                    colorA = 2;
                }
                else if (colorChoice1 == "blue")
                {
                    colorA = 3;
                }

                if (colorChoice2 == "red")
                {
                    colorB = 1;
                }
                else if (colorChoice2 == "yellow")
                {
                    colorB = 2;
                }
                else if (colorChoice2 == "blue")
                {
                    colorB = 3;
                }
                getClue(colorRandom1, colorRandom2, colorA, colorB);

            } while (isRunning);

            Console.ReadKey();
        }

        public static void getClue(int colorRandom1, int colorRandom2, int colorA, int colorB)
        {
            if (colorRandom1 == colorA && colorRandom2 == colorB)
            {
                Console.WriteLine("you won!");
                isRunning = false;
            }
            else if (colorRandom1 != colorA && colorRandom2 != colorB)
            {
                Console.WriteLine("clue 0-0");
            }
            else if (colorRandom1 == colorB || colorRandom2 == colorA)
            {
                Console.WriteLine("clue 1-0");
            }
            else if (colorRandom1 == colorA && colorRandom2 != colorB || colorRandom1 != colorA && colorRandom2 == colorB)
            {
                Console.WriteLine("clue 1-1");
            }
            else if (colorRandom1 == colorB && colorRandom1 == colorA)
            {
                Console.WriteLine("clue 2-0");
            }
        }
    }
}