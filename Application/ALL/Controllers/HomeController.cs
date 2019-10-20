using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ALL.Models;
using Microsoft.AspNetCore.Http;
using WebApplication.Constants;
using System;

namespace ALL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Usuario = HttpContext.Session.GetString(Sessions.SessionUser);
            return View(HttpContext.Session);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(Exception exception)
        {
            return View();
        }
    }
}
