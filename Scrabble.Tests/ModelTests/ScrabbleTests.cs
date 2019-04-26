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
      public void WordToUpper_WordToUpper_UpperCaseString()
      {
        string word = "bob";
        string expectedResult = "BOB";
        Scrabble newScrabble = new Scrabble(word);
        newScrabble.WordToUpper();
        Assert.AreEqual(expectedResult, newScrabble.GetWord());
      }
      [TestMethod]
      public void WordToCharArray_WordToCharArray_CharArray()
      {
          string word = "joe";
          char[] expectedResult = new char[] {'j', 'o', 'e'};
          Scrabble newScrabble = new Scrabble(word);
          char[] actualResult = newScrabble.WordToCharArray();
          CollectionAssert.AreEqual(expectedResult, actualResult);
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
      [TestMethod]
      public void GetScore_SingleLetterWord_1()
      {
        string word = "A";
        int expectedResult = 1;
        Scrabble newScrabble = new Scrabble(word);
        Assert.AreEqual(expectedResult, newScrabble.GetScore());
      }
      public void GetScore_MultipleLetterWord_6()
      {
        string word = "the";
        int expectedResult = 6;
        Scrabble newScrabble = new Scrabble(word);
        Assert.AreEqual(expectedResult, newScrabble.GetScore());
      }
  }
}