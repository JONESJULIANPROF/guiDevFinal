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
            
            ViewBag.ActivityLevelList = model.ActivityLevelList;
            ViewBag.GenderList = model.GenderList;
           
            return View();
        }

        

        [HttpPost]
        public IActionResult HealthForm(FatTrack tracking)
        {
            var model = new FatTrack();
            ViewBag.ActivityLevelList = model.ActivityLevelList;
            ViewBag.GenderList = model.GenderList;
            CompleteInfo.addModel(tracking);

                return View();
            
            
           
        }
        
        public IActionResult Information()
        {
            
            return View(CompleteInfo.ListModels);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
