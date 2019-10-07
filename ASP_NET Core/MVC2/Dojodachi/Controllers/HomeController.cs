// using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Fullness")==null){
                Dachi d1 = new Dachi();
                HttpContext.Session.SetInt32("Fullness", d1.fullness);
                HttpContext.Session.SetInt32("Happiness", d1.happiness);
                HttpContext.Session.SetInt32("Meals", d1.meals);
                HttpContext.Session.SetInt32("Energy", d1.energy);
            }
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            if(HttpContext.Session.GetString("Actions") == null){
                HttpContext.Session.SetString("Actions", "");
            }
            ViewBag.Actions = HttpContext.Session.GetString("Actions");
            return View();
        }

        [HttpGet("Feed")]
        public IActionResult Feed(){
            if(HttpContext.Session.GetInt32("Meals")>0){
                Random rand = new Random();
                if(rand.Next(0,100)<25){
                    HttpContext.Session.SetString("Actions", "Dachi didn't like that!");
                } else {
                    int full = (int)HttpContext.Session.GetInt32("Fullness");
                    int r = rand.Next(5,10);
                    full += r;
                    HttpContext.Session.SetInt32("Fullness", full);
                    HttpContext.Session.SetString("Actions", $"You fed your dachi! Meals decreased by 1 and fullness increased by {r}");
                }
                int meal = (int)HttpContext.Session.GetInt32("Meals");
                meal--;
                HttpContext.Session.SetInt32("Meals", meal);
            } else {
                HttpContext.Session.SetString("Actions", "No meals available to feed."); 
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Play")]
        public IActionResult Play(){
            if(HttpContext.Session.GetInt32("Energy")>=5){
                Random rand = new Random();
                if(rand.Next(0,100)<25){
                    HttpContext.Session.SetString("Actions", "Dachi didn't like that!");
                } else {
                    int happy = (int)HttpContext.Session.GetInt32("Happiness");
                    int r = rand.Next(5,10);
                    happy += r;
                    HttpContext.Session.SetInt32("Happiness", happy);
                    HttpContext.Session.SetString("Actions", $"You played with your dachi! Energy decreased by 5 and happiness increased by {r}");
                }
                int energy = (int)HttpContext.Session.GetInt32("Energy");
                energy -= 5;
                HttpContext.Session.SetInt32("Energy", energy);
            } else {
                HttpContext.Session.SetString("Actions", "Your Dachi is too tired to play."); 
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Work")]
        public IActionResult Work(){
            if(HttpContext.Session.GetInt32("Energy")>=5){
                Random rand = new Random();
                    int meal = (int)HttpContext.Session.GetInt32("Meals");
                    int r = rand.Next(1,3);
                    meal += r;
                    HttpContext.Session.SetInt32("Meals", meal);
                    HttpContext.Session.SetString("Actions", $"You made your Dachi work! Energy decreased by 5 and meals increased by {r}");
                int energy = (int)HttpContext.Session.GetInt32("Energy");
                energy -= 5;
                HttpContext.Session.SetInt32("Energy", energy);
            } else {
                HttpContext.Session.SetString("Actions", "Your Dachi is too tired to work."); 
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Sleep")]
        public IActionResult Sleep(){
            int happy = (int)HttpContext.Session.GetInt32("Happiness");
            int full = (int)HttpContext.Session.GetInt32("Fullness");
            int energy = (int)HttpContext.Session.GetInt32("Energy");
            happy -= 5;
            full -= 5;
            energy += 15;
            HttpContext.Session.SetInt32("Happiness", happy);
            HttpContext.Session.SetInt32("Fullness", full);
            HttpContext.Session.SetInt32("Energy", energy);
            return RedirectToAction("Index");
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
    public class Dachi {
        public int happiness{get;set;}
        public int fullness{get;set;}
        public int energy{get;set;}
        public int meals{get;set;}
        public Dachi(){
            happiness = 20;
            fullness = 20;
            energy = 50;
            meals = 3;
        }
        // public void Feed(){
        //     if(this.meals>0){
        //         Random rand = new Random();
        //         if(rand.Next(0,100)<25){
        //             Console.WriteLine("Dachi didn't like that!");
        //             this.meals--;
        //         } else {
        //             this.fullness += rand.Next(5,10);
        //             this.meals--;
        //         }
        //     } else {
        //         Console.WriteLine("No meals available to feed.");
        //     }
        // }
        // public void Play(){
        //     if(this.energy > 5){
        //         Random rand = new Random();
        //         if(rand.Next(0,100)<25){
        //             Console.WriteLine("Dachi didn't like that!");
        //             this.energy -= 5;
        //         } else {
        //             this.happiness += rand.Next(5,10);
        //             this.energy -= 5;
        //         }
        //     } else {
        //         Console.WriteLine("Your Dachi is too tired to play.");
        //     }
        // }
        // public void Work(){
        //     if(this.energy > 5){
        //         Random rand = new Random();
        //         this.meals += rand.Next(1,3);
        //         this.energy -= 5;
        //     } else {
        //         Console.WriteLine("Your Dachi is too tired to work.");
        //     }
        // }
        // public void Sleep(){
        //     this.energy += 15;
        //     this.fullness -= 5;
        //     this.happiness -= 5;
        // }
    }
}
