using System.Collections.Generic;
using System;

namespace WordPuzzle.Models
{
  public class Guess
  {
    public string Entry { get; set; }
    // public static string Comparator { get; set; }
    // public static List<string> AllWords = new List<string> { "candor", "change", "trader", "vermin" };
    // public static List<bool> CompareList = new List<bool> { };

    public Guess(string entry)
    {
      Entry = entry;
    }
    // public static void GetWord()
    // {
    //   int rnd = new Random().Next(AllWords.Count);
    //   Comparator = AllWords[rnd];
    // }
    // public void CompareChars()
    // {
    //   for (int i = 0; i < Comparator.Length; i++)
    //   {
    //     if (Guess[i] == Words.Comparator[i])
    //     {
    //       CompareList.Add(true);
    //     }
    //     else
    //     {
    //       CompareList.Add(false);
    //     }
    //   }
    // }
  }
}