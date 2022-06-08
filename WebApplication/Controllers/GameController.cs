using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace WebApplication.Controllers
{
    public class GameController : Controller
    {
        public IActionResult MessageToPlayer()
        {
            ViewBag.Message1 = Models.GuessingGame.MessageToPlayer();
            return View();
        }

        public void RandomNr()
        {
            int rndNr = new Random().Next(1, 100);
            HttpContext.Session.SetInt32("RandomNr", rndNr);
        }
        public IActionResult GuessingGame()
        {
            RandomNr();
            return View();
        }
        private void CheckGuessNr(int guess)
        {
            if (HttpContext.Session.GetInt32("RandomNr") != null)
            {
                int rndNr = (int)HttpContext.Session.GetInt32("RandomNr");
                string Result = Models.GuessingGame.GuessNumber(guess, rndNr);
                ViewBag.Message2 = Result;
            }
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            CheckGuessNr(guess);
            return View();
        }
    }
}