using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealCRUD.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session
using Microsoft.EntityFrameworkCore; 

namespace RealCRUD.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Index/////////////////////////////////////////////////////
        [HttpGet("")]
        public IActionResult Index()
        {
            // Get all Goods
            List<Good> AllGoods = dbContext.Goods.ToList();
            // Get Goods with the LastName "Jefferson"
            // List<Good> Jeffersons = dbContext.Goods.Where(u => u.LastName == "Jefferson");
            // Get the 5 most recently added Goods
            List<Good> MostRecent = dbContext.Goods
                .OrderByDescending(u => u.CreatedAt)
                .ToList();
            ViewBag.goods = MostRecent;
			return View();
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////New/////////////////////////////////////////////////////
        [HttpGet("new")]
        public IActionResult New()
        {
			return View("New");
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Individual/////////////////////////////////////////////////////
        [HttpGet("{Id}")]
        public IActionResult Indi(int Id)
        {
            Good oneGood = dbContext.Goods.FirstOrDefault(Good => Good.Id == Id);
			return View("Indi", oneGood);
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Edit/////////////////////////////////////////////////////
        [HttpGet("edit/{Id}")]
        public IActionResult Edit(int Id)
        {
            Good oneGood = dbContext.Goods.FirstOrDefault(Good => Good.Id == Id);
			return View("Edit", oneGood);
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Create one/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("create")]
        public IActionResult CreateGood(Good newGood)
        {
            // We can take the Good object created from a form submission
            // And pass this object to the .Add() method
            if(ModelState.IsValid)
            {
                dbContext.Add(newGood);
                // OR dbContext.Goods.Add(newGood);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("New");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Update ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("update/{Id}")]
        public IActionResult UpdateGood(int Id, Good up)
        {
            if(ModelState.IsValid)
            {
                Good RetrievedGood = dbContext.Goods.FirstOrDefault(Good => Good.Id == Id);
                RetrievedGood.Name = up.Name;
                RetrievedGood.Chef = up.Chef;
                RetrievedGood.Tastiness = up.Tastiness;
                RetrievedGood.Calories = up.Calories;
                RetrievedGood.Description = up.Description;
                RetrievedGood.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Edit");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Remove ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpGet("delete/{Id}")]
        public IActionResult DeleteGood(int Id)
        {
            // Like Update, we will need to query for a single Good from our Context object
            Good RetrievedGood = dbContext.Goods.SingleOrDefault(Good => Good.Id == Id);
            
            // Then pass the object we queried for to .Remove() on Goods
            dbContext.Goods.Remove(RetrievedGood);
            
            // Finally, .SaveChanges() will remove the corresponding row representing this Good from DB 
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            // Other code
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////GET ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public IActionResult GetOneGood(string Email)
        {
            // Good oneGood = dbContext.Goods.FirstOrDefault(Good => Good.Email == Email);
            return RedirectToAction("Index");
            // Other code
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
