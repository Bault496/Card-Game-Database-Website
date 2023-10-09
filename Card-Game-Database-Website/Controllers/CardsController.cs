using Card_Game_Database_Website.Data;
using Card_Game_Database_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Card_Game_Database_Website.Controllers
{
    public class CardsController : Controller
    {
        private readonly TradingCardContext _context;
        public CardsController(TradingCardContext context)
        {
            _context = context;
        }
        public IActionResult CardCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CardCreate(Card TradingCard)
        {
            if (ModelState.IsValid)
            {
                _context.Cards.Add(TradingCard); //prepares insert
                _context.SaveChanges(); // executes pending insert
                // show sucess message
                ViewData["Message"] = $"{TradingCard.CardName} was added successfully!";
               
                return View();
            }

            return View(TradingCard);
        }
    }
}
