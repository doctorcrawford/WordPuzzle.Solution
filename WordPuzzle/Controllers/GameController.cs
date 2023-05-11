using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordPuzzle.Models;

namespace WordPuzzle.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game")]
    public ActionResult Index()
    {
      List<Game> allGames = Game.GetAll();
      return View(allGames);
    }
    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}