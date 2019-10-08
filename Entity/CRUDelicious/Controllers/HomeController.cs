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
			List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson");
    		// Get the 5 most recently added Users
            List<User> MostRecent = dbContext.Users
    			.OrderByDescending(u => u.CreatedAt)
    			.Take(5)
    			.ToList();
			return View();
        }
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////GET ONE/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        public IActionResult GetOneUser(string Email)
        {
            Person oneUser = dbContext.Users.FirstOrDefault(user => user.Email == Email);
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
