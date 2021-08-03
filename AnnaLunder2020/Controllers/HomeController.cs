using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnnaLunder2020.Models;
using Microsoft.AspNetCore.Http;

namespace AnnaLunder2020.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Message!", "Hello!");
            HttpContext.Session.SetInt32("Year", 2021);
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FeverCheck()
        {
            ViewBag.Message = HttpContext.Session.GetString("Temperatur");
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(Temperature fevermodel)
        {
                var t = fevermodel.temperature;
                var message = Fever.FeverCheck(t);

                ViewBag.Message = message;

                return View();
        }

        public IActionResult GuessingGame()
        {
            ViewBag.Message = HttpContext.Session.GetString("Gissning");
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(GuessingGame guessModel)
        {
            var n = guessModel.guessNumber;
            var message = GuessRandom.Guess(n);

            ViewData["Message"] = message;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}