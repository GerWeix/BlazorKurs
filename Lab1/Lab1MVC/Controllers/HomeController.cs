using Lab1MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1MVC.Controllers
{
    public class HomeController(IModelService modelService) : Controller
    {

        public IActionResult Index()
        {
            modelService.Inhaber = new InhaberModel { Status = "Freigegeben", Person = new PersonModel { Name = "Weix", Vorname = "Gerhard" } };
            return View(modelService.Inhaber);
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
