using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

namespace Asp.NetWebApi.LamazonApp.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [Authorize(Roles = "user")]
        public IActionResult Products()
        {            
            Log.Information("Fetching all products sturted");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            List<ProductVM> products = _productService.GetAllProducts().ToList();
            if(products.Count() < 0)
            {
                return View("ErrorView");
            }
            stopwatch.Stop();

            Log.Information($"Time for fetching all products: {stopwatch.ElapsedMilliseconds}ms");
            return View(products);
        }
    }
}
