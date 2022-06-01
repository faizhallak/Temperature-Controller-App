using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using Microsoft.AspNetCore.Http;

namespace WebApplication.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GuessingGame()
        {
            ViewBag.Message1 = Models.GuessingGame.MessageToPlayer();
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            HttpContext.Session.SetInt32("test session", guess);
            return View();
        }
    }
}
