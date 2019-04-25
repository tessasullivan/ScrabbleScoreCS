using System;

namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to The Scrabble Score Generator");
            Console.WriteLine("Please enter a word to find out your score.");

            string word = Console.ReadLine();
            Scrabble newScrabble = new Scrabble(word);

            int score = newScrabble.GetScore(word);
            Console.WriteLine("Your score is " + score);
            
        }
    }

}