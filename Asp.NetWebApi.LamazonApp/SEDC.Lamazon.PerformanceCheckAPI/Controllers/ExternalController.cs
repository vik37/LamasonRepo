using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.PerformanceCheckAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public ExternalController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("performance/getorder")]
        public ActionResult<long> GetUserOrderPerformance()
        {
            string userId = "664341bc-8c90-4ee9-bb64-6ef3fe09f371";
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 10; i++)
            {
                _orderService.GetCurrentOrder(userId);
            }
            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            return time;
        }
    }
}
