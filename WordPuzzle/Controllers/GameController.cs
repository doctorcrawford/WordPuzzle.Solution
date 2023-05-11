using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordPuzzle.Models;

namespace WordPuzzle.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game")]
    //goes to the game index
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/game")]
    public ActionResult Create()
    {
      Game newGame = new Game();
      return RedirectToAction("Index");
    }

    [HttpPost("/game/guess/new")]
    public ActionResult Update(char[] letter, int gameId)
    {
      string guessString = letter.ToString();
      Guess newGuess = new Guess(guessString);
      Game currentGame = Game.Find(gameId);
      currentGame.AddGuess(newGuess);
      return RedirectToAction("Index");
    }
  }
}