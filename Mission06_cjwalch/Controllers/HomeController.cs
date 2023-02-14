using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DateApplicationContext blahContext { get; set; }
        // Constructor
        public HomeController(ILogger<HomeController> logger, DateApplicationContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcasts()
        {
            return View();
        }
        //we added this
        [HttpGet]
        public IActionResult DatingApplication() // GET
        {
            return View();
        }
        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar) // POST
        {
            blahContext.Add(ar);
            blahContext.SaveChanges(); 
            return View("Confirmation", ar);
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
