using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session
using Microsoft.AspNetCore.Identity; ///////////password hashing

namespace LoginReg.Controllers
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
        /////////////////////Register/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            // We can take the User object created from a form submission
            // And pass this object to the .Add() method
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                } else {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    // OR dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetString("Email", newUser.Email);
                    return RedirectToAction("Success");
                }
            }
            return View("Index");
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////Login/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        [HttpPost("login")]
        public IActionResult Login(string Email, string Password)
        {
            // If a User exists with provided email
            if(dbContext.Users.Any(u => u.Email == Email))
            {
                User logger = dbContext.Users.FirstOrDefault(User => User.Email == Email);
                // Initialize hasher object
                var hasher = new PasswordHasher<User>();
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(logger, logger.Password, Password);
                if(result != 0){
                    HttpContext.Session.SetString("Email", Email);
                    return RedirectToAction("Success", logger);
                }
            }
            ViewBag.fail = "Incorrect email or password.";
            return View("Index");
        }
        public IActionResult Index()
        {
			return View();
        }
        public IActionResult Success()
        {
            string email = HttpContext.Session.GetString("Email");
            User logger = dbContext.Users.FirstOrDefault(User => User.Email == email);
            ViewBag.user = logger;
			return View();
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
