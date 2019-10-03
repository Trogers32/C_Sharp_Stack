using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            List<String> li = new List<string>();
            li.Add("apple");
            li.Add("cherry");
            li.Add("REEEEEE");
            ViewBag.Example = li;
            return View();
        }
        [HttpGet("any")]
        public RedirectToActionResult Method()
        {
            // Will redirect to the "OtherMethod" method
            return RedirectToAction("Index");
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
        // Other code
        // public RedirectToActionResult Method()
        // {
        //     // The anonymous object consists of keys and values
        //     // The keys should match the parameter names of the method being redirected to
        //     return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
        // }
        // [HttpGet]
        // [Route("other/{Food}/{Quantity}")]
        // public ViewResult OtherMethod(string Food, int Quantity)
        // {
        //     Console.WriteLine($"I ate {Quantity} {Food}.");
        //     // Writes "I ate 5 sandwiches."
        // }

        // [HttpGet("pizza/{topping}")]
        // // [Route("pizza/{topping}")]
        // public string PizzaParty(string topping)
        // {
        //     return $"Who's ready for a {topping} Pizza!";
        // }
        // [HttpGet("user/{name}/{location}/{age}")]
        // // [Route("user/{name}/{location}/{age}")]
        // public string UserInfo(string name, string location, int age)
        // {
        //     return $"{name}, aged {age}, is from {location}";
        // }
    }
}