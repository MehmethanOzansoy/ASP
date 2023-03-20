using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class Example : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
