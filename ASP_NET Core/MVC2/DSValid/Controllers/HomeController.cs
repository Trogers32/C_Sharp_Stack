using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DSValid.Models;

namespace DSValid.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
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
        
        [HttpPost("user/create")]
        public IActionResult Create(IndexViewModel user)
        {
            if(ModelState.IsValid)
            {
                User newUs = user.newUser;
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Result", newUs);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
        [HttpGet("result")]
        public IActionResult Result(User user){
            return View("Result", user);
        }
    }
}
