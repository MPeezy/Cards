using Cards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Controllers
{
    public class HomeController : Controller
    {
       CardsDAL CARDS = new CardsDAL();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Card()
        {
            CardsSearchResults csr = new CardsSearchResults();
            csr = CARDS.GetCard(1);
            return View(csr);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
