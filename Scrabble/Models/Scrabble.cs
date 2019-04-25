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
    }
}
