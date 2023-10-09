using Microsoft.AspNetCore.Mvc;

namespace Card_Game_Database_Website.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult CardCreate()
        {
            return View();
        }
    }
}
