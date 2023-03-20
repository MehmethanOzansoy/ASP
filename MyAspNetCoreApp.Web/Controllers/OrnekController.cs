using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class Product2
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
          

            ViewBag.name = "Asp.net Core 7 Mühendisler";

            TempData["surname"] = "Akıncı";

            ViewData["age"] = 30;

            ViewData["names"] = new List<string>() { "Ahmet", "Mehmet Han ", "Can " };

            ViewBag.person = new { id = 1, name = "Ayşe", age= 33};
          

            

            return View();
        }

        public IActionResult Details()
        {
            TempData["surname"] = "Akıncı";
            var productList = new List<Product2>()
            {
                new(){id=1,name="Kalem"},
                new(){id=2,name="Defter"},
                new(){id=3,name="Kalemlik"}
            };
            return View(productList);
        }

        public IActionResult Index2()
        {
            return RedirectToAction("Index", "Ornek");
        }

        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek",new {id=id});
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { id = id});
        }

        public IActionResult ContentResult()
        {
            return Content("Content Result");
        }
        
        public IActionResult JsonResult()
        {
            return Json(new { id = 1, name = "Kalem", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
       


    }
}
