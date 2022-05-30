using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            ViewBag.Message = Models.FeverCheck.WriteMessage();
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(int temp)
        {
            ViewBag.Info = Models.FeverCheck.Check(temp);
            return View();
        }
    }
}
