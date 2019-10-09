using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
     
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // Get all Users
            List<User> AllUsers = dbContext.Users.ToList();
            // Get Users with the LastName "Jefferson"
            // List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson");
            // Get the 5 most recently added Users
            List<User> MostRecent = dbContext.Users
                .OrderByDescending(u => u.CreatedAt)
                .ToList();
            ViewBag.users = MostRecent;
			return View();
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Create one/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            // We can take the User object created from a form submission
            // And pass this object to the .Add() method
            if(ModelState.IsValid)
            {
                dbContext.Add(newUser);
                // OR dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Update ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpGet("update/{userId}")]
        public IActionResult UpdateUser(int userId)
        {
            // We must first Query for a single User from our Context object to track changes.
            User RetrievedUser = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
            // Then we may modify properties of this tracked model object
            RetrievedUser.FirstName = "New name";
            RetrievedUser.UpdatedAt = DateTime.Now;
            
            // Finally, .SaveChanges() will update the DB with these new values
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            
            // Other code
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Remove ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpGet("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            // Like Update, we will need to query for a single user from our Context object
            User RetrievedUser = dbContext.Users.SingleOrDefault(user => user.UserId == userId);
            
            // Then pass the object we queried for to .Remove() on Users
            dbContext.Users.Remove(RetrievedUser);
            
            // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            // Other code
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////GET ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public IActionResult GetOneUser(string Email)
        {
            User oneUser = dbContext.Users.FirstOrDefault(user => user.Email == Email);
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
