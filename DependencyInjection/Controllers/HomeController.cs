using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        IManager manager;
        public HomeController(IManager _manager)
        {
            manager = _manager;



        }
      
        public IActionResult Index()
        {
         
            ViewBag.Test = manager.EkranaYazdir();
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.Test = manager.EkranaYazdir();
            return View();



        }

    }
}
