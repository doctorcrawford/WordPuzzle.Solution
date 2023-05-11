using System.Collections.Generic;
using System;

namespace WordPuzzle.Models
{
  public class Words
  {
    public string Guess { get; set; }
    public static string Comparator { get; set; }
    // public static List<Words> AllGuesses = new List<Words> { };
    public static List<string> AllWords = new List<string> { "candor", "change", "trader", "vermin" };
    public static List<bool> CompareList = new List<bool> { };

    public Words(string guess)
    {
      Guess = guess;
    }
    public static void GetWord()
    {
      int rnd = new Random().Next(AllWords.Count);
      Comparator = AllWords[rnd];
    }
    public void CompareChars()
    {
      for (int i = 0; i < Comparator.Length; i++)
      {
        if (Guess[i] == Words.Comparator[i])
        {
          CompareList.Add(true);
        }
        else
        {
          CompareList.Add(false);
        }
      }
    }
  }
}