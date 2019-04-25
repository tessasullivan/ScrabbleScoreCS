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
  }
}