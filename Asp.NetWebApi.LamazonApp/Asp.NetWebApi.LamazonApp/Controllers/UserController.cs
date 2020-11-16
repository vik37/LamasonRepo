using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NToastNotify;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

namespace Asp.NetWebApi.LamazonApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;
        public UserController(IUserService userService, IToastNotification toastNotification)
        {
            _userService = userService;
            _toastNotification = toastNotification;
        }

        public IActionResult LogIn()
        {
            LoginVM model = new LoginVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult LogIn(LoginVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isAdmin;
                    Log.Debug($"Authenticathing user with username {model.UserName}");
                    _userService.LogIn(model, out isAdmin);
                    if (isAdmin)
                    {
                        _toastNotification.AddSuccessToastMessage($"Welcome {model.UserName}. You are logged in as a admin!");

                        Log.Debug($"User with username {model.UserName} successfully logged in! Admin user");
                        return RedirectToAction("listallorders", "order");
                    }
                    else
                    {
                        _toastNotification.AddSuccessToastMessage($"Welcome {model.UserName}. You are logged in as a customer!");

                        Log.Debug($"User with username {model.UserName} successfully logged in! Customer user");
                        return RedirectToAction("products", "product");
                    }
                }
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message}");
            }

            return View(model);
        }
        public IActionResult Register()
        {
            RegisterVM model = new RegisterVM();
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userService.Register(model);
                    return RedirectToAction("products", "product");
                }
            }
            catch (Exception ex)
            {

                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            
            return View(model);
        }
        public IActionResult LogOut()
        {
            _userService.LogOut();
            return RedirectToAction("index", "home");
        }

        
    }
}
