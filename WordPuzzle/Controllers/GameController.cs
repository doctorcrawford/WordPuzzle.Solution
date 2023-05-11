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
      List<Game> allGames = Game.GetAll();
      return View(allGames);
    }
    [HttpPost("/game")]
    public ActionResult Create()
    {
      Game newGame = new Game();
      return RedirectToAction("Index");
    }
  }
}