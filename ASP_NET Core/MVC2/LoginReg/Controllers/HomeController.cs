using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private static Random random = new Random();
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("counter")!=null){
                int temp = (int)HttpContext.Session.GetInt32("counter");
                temp++;
                HttpContext.Session.SetInt32("counter", temp);
            } else {
                HttpContext.Session.SetInt32("counter", 1);
            }
            
            ViewBag.Count = HttpContext.Session.GetInt32("counter");
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            ViewBag.ran = "";
            for(int i = 0; i <15; i++){
                ViewBag.ran += chars[random.Next(0,35)];
            }
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
