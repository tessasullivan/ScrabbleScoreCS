using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
      [TestMethod]
      public void ScrabbleConstructor_CreatesInstanceOfScrabble_Scrabble()
      {
          Scrabble newScrabble = new Scrabble("");
          Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
      }
      [TestMethod]
      public void GetWord_GetWord_String()
      {
        string word = "test";
        Scrabble newScrabble = new Scrabble(word);
        string result = newScrabble.GetWord();
        Assert.AreEqual(word, result);
      }
      [TestMethod]
      public void SetWord_SetWord_String()
      {
          string word = "Yay";
          Scrabble newScrabble = new Scrabble(word);
          string updatedWord = "Wow";
          newScrabble.SetWord(updatedWord);
          string result = newScrabble.GetWord();
          Assert.AreEqual(updatedWord, result);
      }
      [TestMethod]
      public void LookupLetterScore_Integer()
      {
        char letter = 'A';
        string word = "a";
        int expectedResult = 1;
        Scrabble newScrabble = new Scrabble(word);
        Assert.AreEqual(expectedResult, newScrabble.LookupLetterScore(letter));
      }
    //   [TestMethod]
    //   public void GetScore_SingleLetterWord_1()
    //   {
    //     string word = "A";
    //     int expectedResult = 1;
    //     Scrabble newScrabble = new Scrabble(word);
    //     Assert.AreEqual(expectedResult, newScrabble.GetScore(word));
    //   }
  }
}