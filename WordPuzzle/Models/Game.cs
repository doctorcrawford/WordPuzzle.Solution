using System.Collections.Generic;
using System;
using System.Linq;

namespace WordPuzzle.Models
{
  public class Game
  {
    private static List<Game> _gameInstances = new List<Game> { };
    public int Id { get; }
    public List<Guess> AllGuesses { get; set; }



    public string Comparator { get; set; }
    public static List<string> AllWords = new List<string> { "candor", "change", "trader", "vermin" };
    public List<bool> CompareList = new List<bool> { };

    public Game()
    {
      _gameInstances.Add(this);
      Id = _gameInstances.Count;
      AllGuesses = new List<Guess> { };
      Comparator = GetWord();
    }
    public static void ClearAll()
    {
      _gameInstances.Clear();
    }
    public static List<Game> GetAll()
    {
      return _gameInstances;
    }
    public static Game Find(int searchId)
    {
      return _gameInstances[searchId - 1];
    }
    public void AddGuess(Guess guess)
    {
      AllGuesses.Add(guess);
    }


    public string GetWord()
    {
      int rnd = new Random().Next(AllWords.Count);
      return AllWords[rnd];
    }
    public void CompareChars()
    {
      Guess guess = AllGuesses.Last();
      string entry = guess.Entry;
      for (int i = 0; i < Comparator.Length; i++)
      {
        if (entry[i] == Comparator[i])
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
