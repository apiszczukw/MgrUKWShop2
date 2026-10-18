using System.Diagnostics;
using MgrUKWShop2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MgrUKWShop2.Controllers
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

    }
}
