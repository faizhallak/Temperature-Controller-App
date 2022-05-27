using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class Doctor : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}
