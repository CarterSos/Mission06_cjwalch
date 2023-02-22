using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieFormContext movieContext { get; set; }
        // Constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            movieContext = someName;
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
        public IActionResult MovieForm() // GET
        {
            ViewBag.Categories = movieContext.Categories.ToList(); // allows to access both tables

            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar) // POST
        {

            if (ModelState.IsValid)
            {
                movieContext.Add(ar);
                movieContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else // if invalid
            {
                ViewBag.Categories = movieContext.Categories.ToList();

                return View();
            }
            
        }

        [HttpGet]
        public IActionResult MovieList() 
        {
            var movies = movieContext.Responses
                .Include(x => x.Category)
                //.Where(c => c.CreeperStalker == false)
                //.OrderBy(x => x.LastName)
                .ToList();

            return View(movies);
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
        [HttpGet]
        public IActionResult Edit(string title)
        {

            ViewBag.Categories = movieContext.Categories.ToList();

            var movie = movieContext.Responses.Single(x => x.Title == title);

            return View("MovieForm", movie);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            movieContext.Update(blah);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(string title)
        {
            var movie = movieContext.Responses.Single(x => x.Title == title);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            movieContext.Responses.Remove(ar);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
