using System.Collections.Generic;
namespace WordPuzzle.Models
{
  public class Game
  {
    private static List<Game> _gameInstances = new List<Game> { };
    public int Id { get; }
    public List<Words> AllGuesses { get; set; }

    public Game()
    {
      _gameInstances.Add(this);
      Id = _gameInstances.Count;
      AllGuesses = new List<Words> { };
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
    public void AddGuess(Words guess)
    {
      AllGuesses.Add(guess);
    }

  }
}
