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
      Words word1 = new Words("hurdle");
      Words word2 = new Words("turtle");
      newGame.AddGuess(word1);
      newGame.AddGuess(word2);
      List<Words> expected = new List<Words> { word1, word2 };
      CollectionAssert.AreEqual(expected, newGame.AllGuesses);
    }

  }
}