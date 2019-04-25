using System;
namespace Scrabble
{
    public class Scrabble
    {
        private string _word;
        public Scrabble(string word)
        {
            _word = word;
        }
        public string GetWord()
        {
            return _word;
        }

        public void SetWord(string newWord)
        {
            _word = newWord;
        }
        public int GetScore(string word)
        {
            string upperWord = WordToUpper(word);
            char[] result = WordToCharArray(upperWord);
            int score = 0;
            foreach(char letter in result) 
            {
                score += LookupLetterScore(letter);
            }

             return score;
        }
        public int LookupLetterScore(char letter)
        {
            if ("AEIOULNRST".Contains(letter))
            {
                 return 1;
            }
            else if ("DG".Contains(letter))
            {
                return 2;
            }
            else if ("BCMP".Contains(letter))
            {
                return 3;
            }
            else if ("FHVWY".Contains(letter))
            {
                return 4;
            }
            else if ("K".Contains(letter))
            {
                return 5;
            }
            else if ("JX".Contains(letter))
            {
                return 8;
            }
            else if ("QZ".Contains(letter))
            {
                return 10;
            }
            else
            {
                return 0;
            }
            
        }
        public string WordToUpper(string word)
        {
            return word.ToUpper();
        } 
        public char[] WordToCharArray(string word)
        {
            char[] result = word.ToCharArray();
            return result;
        }


    }
}
