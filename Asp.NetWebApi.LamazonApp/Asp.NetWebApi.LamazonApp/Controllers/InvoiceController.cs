using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetWebApi.LamazonApp.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        public InvoiceController(IInvoiceService invoiceService, IOrderService orderService, IUserService userService)
        {
            _invoiceService = invoiceService;
            _orderService = orderService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            InvoiceVM model = new InvoiceVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(string address, int paymentType,int orderId)
        {
            if (ModelState.IsValid)
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                InvoiceVM model = new InvoiceVM();
                model.Address = address;
                model.PaymentType = (PaymentTypeVM)paymentType;

                OrderVM order = _orderService.GetOrderById(orderId);

                if(order != null)
                {
                    model.OrderVM = order;
                    _invoiceService.Insert(model, user.Id, orderId);
                }
            }
            return RedirectToAction("invoice", new { orderId });
        }
        public IActionResult Invoice(int orderId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceVM model = _invoiceService.GetByOrderId(orderId,user.Id);

            return View(model);
        }
    }
}
