using Microsoft.AspNetCore.Mvc;
using ShopMVC.Application.Interfaces;
using ShopMVC.Application.Services;
using ShopMVC.Models;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace ShopMVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private readonly IItemService _itemService;

        //public HomeController(ILogger<HomeController> logger,IItemService itemService)
        //{
        //    _logger = logger;
        //    _itemService = itemService;
        //}

        public IActionResult Index()
        {
            return View();
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