using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordPuzzle.Models;
using System;

namespace WordPuzzle.Tests
{
  [TestClass]
  public class WordsTests
  {
    [TestMethod]
    public void GetWord_ReturnsRandomWordFromList_String()
    {
      Words.GetWord();
      Assert.AreEqual(typeof(String), Words.Comparator.GetType());
    }

    [TestMethod]
    public void CompareChars_AddsTrueBooleanToCompareListIfTrue_List()
    {
      Words guessWord = new Words("charts");
      Words.Comparator = "change";
      List<bool> expected = new List<bool> { true, true, true, false, false, false };
      guessWord.CompareChars();
      CollectionAssert.AreEqual(expected, Words.CompareList);
    }
  }
}