using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetWebApi.LamazonApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

namespace Asp.NetWebApi.LamazonApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        public OrderController(IOrderService orderService, IUserService userService, IProductService productService)
        {
            _orderService = orderService;
            _userService = userService;
            _productService = productService;
        }
        [Authorize(Roles = "user")]
        public IActionResult ListOrders()
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                List<OrderVM> userOrders = _orderService.GetAllOrders()
                                            .Where(x => x.UserVM.Id == user.Id)
                                            .ToList();

                return View(userOrders);
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
        [Authorize(Roles = "admin")]
        public IActionResult ListAllOrders()
        {
            try
            {
                List<OrderVM> orders = _orderService.GetAllOrders().ToList();
                return View(orders);
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
        [Authorize(Roles = "user")]
        public IActionResult OrderDetails(int orderId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderVM order = _orderService.GetOrderById(orderId, user.Id);
                if (order.Id > 0)
                {
                    return View("order", order);
                }
                else
                {
                    return View("Error", new ErrorViewModel());
                    
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
        [Authorize(Roles = "user")]
        public IActionResult Order()
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderVM order = _orderService.GetCurrentOrder(user.Id);
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }

            return PartialView("ErrorView");
        }
        [Authorize(Roles = "admin")]
        public IActionResult ApproveOrder(int orderId)
        {
            try
            {
                OrderVM order = _orderService.GetOrderById(orderId);
                _orderService.ChangeStatus(order.Id, order.UserVM.Id, StatusTypeVM.Confirmed);
                return RedirectToAction("listallorders");
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
        [Authorize(Roles = "admin")]
        public IActionResult DeclineOrder(int orderId)
        {
            try
            {
                OrderVM order = _orderService.GetOrderById(orderId);
                _orderService.ChangeStatus(order.Id, order.UserVM.Id, StatusTypeVM.Declined);
                return RedirectToAction("listallorders");
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
        [Authorize(Roles = "user")]
        public IActionResult ChangeStatus(int orderId,int statusId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                _orderService.ChangeStatus(orderId, user.Id, (StatusTypeVM)statusId);
                return RedirectToAction("ListOrders");
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }
        [Authorize(Roles = "user")]
        public int AddProduct(int productId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderVM order = _orderService.GetCurrentOrder(user.Id);

                int result = _orderService.AddProduct(order.Id, productId, user.Id);

                if (result >= 0)
                {
                    Log.Debug($"Product was added successfully. Result: {result}");
                    return result;
                }
                else
                {
                    Log.Debug($"Product was not added successfully. Result: {result}");
                    return result;
                }
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return -1;
        }
    }
}
