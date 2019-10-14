using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProdCat.Models;
using Microsoft.AspNetCore.Http; ///////////////////////added for session
using Microsoft.AspNetCore.Identity; ///////////password hashing
using Microsoft.EntityFrameworkCore; 

namespace ProdCat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> Prods = dbContext.Products;
            ViewBag.Products = Prods;
            return View();
        }
        [HttpGet("categories")]
        public IActionResult Categories(){
            IEnumerable<Category> Cats = dbContext.Categories;
            ViewBag.Categories = Cats;
            return View();
        }
        [HttpGet("categories/{Id}")]
        public IActionResult Category(int Id){
            Category Cat = dbContext.Categories.Include(y=>y.Products).ThenInclude(i=>i.Product).FirstOrDefault(c => c.CategoryId == Id);
            ViewBag.Category = Cat;
            IEnumerable<Product> Prods = dbContext.Products;
            List<Product> p = new List<Product>();
            List<Product> np = new List<Product>();
            foreach(var x in Cat.Products){
                p.Add(x.Product);
            }
            foreach(Product i in Prods){
                if(!p.Contains(i)){
                    np.Add(i);
                }
            }
            ViewBag.Products = p;
            ViewBag.Productss = np;
            return View();
        }
        [HttpGet("products/{Id}")]
        public IActionResult Product(int Id){
            Product prod = dbContext.Products.Include(y=>y.Categories).ThenInclude(i=>i.Category).FirstOrDefault(c => c.ProductId == Id);
            ViewBag.Product = prod;
            IEnumerable<Category> Cats = dbContext.Categories;
            List<Category> currentCats = new List<Category>();
            List<Category> otherCats = new List<Category>();
            foreach(var x in prod.Categories){
                currentCats.Add(x.Category);
            }
            foreach(Category i in Cats){
                if(!currentCats.Contains(i)){
                    otherCats.Add(i);
                }
            }
            ViewBag.Categories = currentCats;
            ViewBag.NotCategories = otherCats;
            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product newProduct){
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            IEnumerable<Product> Prods = dbContext.Products;
            ViewBag.Products = Prods;
            return View("Index");
        }
        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category newCategory){
            if(ModelState.IsValid)
            {
                dbContext.Categories.Add(newCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            IEnumerable<Category> cats = dbContext.Categories;
            ViewBag.Categories = cats;
            return View("categories");
        }
        [HttpPost("AddProductToCategory")]
        public IActionResult AddProductToCategory(Associations newAssociation){
            dbContext.Associations.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Category", new{Id = newAssociation.CategoryId} );
        }
        [HttpPost("AddCategoryToProduct")]
        public IActionResult AddCategoryToProduct(Associations newAssociation){
            dbContext.Associations.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Product", new{Id = newAssociation.ProductId} );
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
