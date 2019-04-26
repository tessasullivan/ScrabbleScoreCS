using System;
using System.Text.RegularExpressions;

namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to The Scrabble Score Generator");
            interactWithUser();

        }
        public static void interactWithUser()
        {
            Console.WriteLine("Please enter a word to find out your score or q to quit.");
            string word = Console.ReadLine();

            if (word.ToLower() == "q")
            {
                System.Console.WriteLine("Thanks for using Scrabble Score");
                Environment.Exit(0);
            }
            else
            {
                checkInput(word);
                Scrabble newScrabble = new Scrabble(word);

                int score = newScrabble.GetScore();
                Console.WriteLine("Your score is " + score);
                interactWithUser();
            }          
        }
        public static void checkInput(string word)
        {
            // Test that return prompts for word
            // If word is longer than 15 characters, error and prompt for word
            // If word contains non-alphabet characters, error and prompt for word.

            Match result = Regex.Match(word, @"^[a-zA-Z]+$");

            if (word == "")
            {
                interactWithUser();
            }
            else if (word.Length > 15)
            {
                System.Console.WriteLine("Your word is longer than the Scrabble board.");
                interactWithUser();
            }
            else if (!result.Success)
            {
                System.Console.WriteLine("Your word contains non-alpahbet characters.");
                interactWithUser();
            }
        }
    }

}