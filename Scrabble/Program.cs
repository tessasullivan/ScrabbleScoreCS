using System;

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
            }
            else
            {
                Scrabble newScrabble = new Scrabble(word);

                int score = newScrabble.GetScore();
                Console.WriteLine("Your score is " + score);
                interactWithUser();
            }
            
            
        }
    }

}