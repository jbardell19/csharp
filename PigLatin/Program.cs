using System;
using System.Linq;

//LINQ (check out msoft docs for ref)//

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a word or sentence to be converted to Pig Latin:");
            string input = Console.ReadLine();
            string input2 = input.ToLower();
            PigLatin(input2);

            static void PigLatin(string word)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                //array//

                int firstVowelPosition = word.IndexOfAny(vowels);
                if (firstVowelPosition == -1)
                {
                    Console.WriteLine(word + "ay");
                }
                else
                {
                    char firstLetter = word[0];
                    char lastLetter = word[word.Length - 1];
                    if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                        //if condition//
                    {
                        Console.WriteLine(word + "ay");
                    }
                    else
                    {
                        string firstHalf = word.Substring(0, firstVowelPosition);
                        string secondHalf = word.Substring(firstVowelPosition);
                        Console.WriteLine(secondHalf + firstHalf + "yay");
                    }

                }

            }

        }

    }

}