using System;
using System.Collections.Generic;
using System.Linq;

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

        public void WordToUpper()
        {
            SetWord(GetWord().ToUpper());
        } 
        
        public char[] WordToCharArray()
        {
            return GetWord().ToCharArray();
        }

        public int GetScore()
        {
            WordToUpper();
            char[] result = WordToCharArray();
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
    }
}
