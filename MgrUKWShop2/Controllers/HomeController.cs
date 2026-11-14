using System.Diagnostics;
using MgrUKWShop2.DAL;
using MgrUKWShop2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MgrUKWShop2.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var allCategories = db.Categories.ToList();

            return View(allCategories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
