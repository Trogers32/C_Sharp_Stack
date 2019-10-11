using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session
using Microsoft.AspNetCore.Identity; ///////////password hashing

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
//////////////////////////////////////////////////
        public IActionResult Index()
        {
            IEnumerable<Chef> chefs = dbContext.Chefs;
            ViewBag.c = chefs;
            return View();
        }
//////////////////////////////////////////////////
        [HttpGet("new")]
        public IActionResult Chef()
        {
            return View("AddChef");
        }
//////////////////////////////////////////////////
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            
            IEnumerable<Chef> chefs = dbContext.Chefs;
            IEnumerable<Dish> dishes = dbContext.Dishes;
            ViewBag.c = chefs;
            ViewBag.d = dishes;
            return View();
        }
//////////////////////////////////////////////////
        [HttpGet("dishes/new")]
        public IActionResult AddDish()
        {
            IEnumerable<Chef> chefs = dbContext.Chefs;
            ViewBag.c = chefs;
            return View();
        }

        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Create Chef/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("AddChef")]
        public IActionResult CreateChef(Chef newChef)
        {
            Console.WriteLine(newChef.Age);
            DateTime testDate = DateTime.Now;
            testDate.AddYears(18);
            if(newChef.Age >= DateTime.Now){
                ModelState.AddModelError("Age", "Birthday must be in the past.");
                return View("AddChef");
            } else if(newChef.Age >= testDate){
                ModelState.AddModelError("Age", "Chef must be 18 or older.");
                return View("AddChef");
            }
            if(ModelState.IsValid)
            {
                dbContext.Chefs.Add(newChef);
                // OR dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddChef");
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Create Dish/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                newDish.Creator = dbContext.Chefs.FirstOrDefault(c => c.ChefId == newDish.ChefId);
                newDish.Creator.dishes += 1;
                dbContext.Dishes.Add(newDish);
                // OR dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            IEnumerable<Chef> chefs = dbContext.Chefs;
            ViewBag.c = chefs;
            return View("AddDish");
        }
//////////////////////////////////////////////////
//////////////////////////////////////////////////
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
