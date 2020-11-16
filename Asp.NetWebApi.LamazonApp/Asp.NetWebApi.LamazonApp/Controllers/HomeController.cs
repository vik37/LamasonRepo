using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.NetWebApi.LamazonApp.Models;
using SEDC.Lamazon.Services.Interfaces;

namespace Asp.NetWebApi.LamazonApp.Controllers
{
    public class HomeController : Controller
    {
        protected readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Hello! Welcome to Lamazon online store! We are the cheapest store in the world!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Email: lamazon@gmail.com";

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
