using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordPuzzle.Models;
using System;

namespace WordPuzzle.Tests
{
  [TestClass]
  public class GameTests : IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }
    
    [TestMethod]
    public void Find_ReturnsGameInstanceById_Game()
    {
      Game newGame = new Game();
      Game someGame = Game.Find(1);
      int expected = 1;
      Assert.AreEqual(expected, someGame.Id);
    }
    
    [TestMethod]
    public void AddGuess_AddGuessWordToAllGuessesList_List()
    {
      Game newGame = new Game();
      Guess word1 = new Guess("hurdle");
      Guess word2 = new Guess("turtle");
      newGame.AddGuess(word1);
      newGame.AddGuess(word2);
      List<Guess> expected = new List<Guess> { word1, word2 };
      CollectionAssert.AreEqual(expected, newGame.AllGuesses);
    }
    [TestMethod]
    public void CompareChars_AddsTrueBooleanToCompareListIfTrue_List()
    {
      Game newGame = new Game();
      Guess guessWord = new Guess("charts");
      newGame.AddGuess(guessWord);
      newGame.Comparator = "change";
      List<bool> expected = new List<bool> { true, true, true, false, false, false };
      newGame.CompareChars();
      CollectionAssert.AreEqual(expected, newGame.CompareList);
    }
  }
}