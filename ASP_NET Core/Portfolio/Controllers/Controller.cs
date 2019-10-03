using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is my index!";
        }
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects!";
        }
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact!";
        }
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