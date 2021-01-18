using FianlGUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FianlGUI.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult HealthForm()
        {
            var model = new FatTrack();
            
            ViewBag.ActivityLevel = model.ActivityLevel;
            return View();
        }

        

        [HttpPost]
        public IActionResult HeathForm(FatTrack tracking)
        {
            var model = new FatTrack();
            model = tracking;
            return View("Information", model);
        }
        
        public IActionResult Information()
        {
            var model = new FatTrack();
            //model.FirstN = "Test";
            //model.LastN = "Test";
            //model.Email = "Test";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
