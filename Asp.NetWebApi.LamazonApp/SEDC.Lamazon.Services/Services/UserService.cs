using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SEDC.Lamazon.Domain.DomainModels;
using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepository;
        protected readonly SignInManager<User> _signInManager;
        protected readonly UserManager<User> _userMenager;
        protected readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, 
                           IMapper mapper, 
                           SignInManager<User> signInManager,
                           UserManager<User> userMenager)
        {
            _userRepository = userRepository;
            _signInManager = signInManager;
            _userMenager = userMenager;
            _mapper = mapper;
        }
        public void Register(RegisterVM registerUser)
        {
            User user = new User
            {
                UserName = registerUser.Username,
                FullName = String.Format("{0} {1}", registerUser.FirstName, registerUser.LastName),
                Email = registerUser.Email,
                Orders = new List<Order>()
                {
                    new Order
                    {
                        Status = StatusType.Init                        
                    }
                }
            };
            var password = registerUser.Password;
            var result = _userMenager.CreateAsync(user, password).Result;
            bool isAdmin = false;
            if (result.Succeeded)
            {
                var currentUser = _userMenager.FindByNameAsync(user.UserName).Result;
                var roleResult = _userMenager.AddToRoleAsync(currentUser, "user").Result;
                if (roleResult.Succeeded)
                {
                    LogIn(new LoginVM
                    {
                        UserName = registerUser.Username,
                        Password = registerUser.Password
                    }, out isAdmin);
                }
                else
                {
                    throw new Exception("Adding user to role failed!");
                }
                
            }
        }
        public void LogIn(LoginVM loginModel, out bool isAdmin)
        {
            var result = _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, false).Result;
            User user = _userRepository.GetByUsername(loginModel.UserName);
            isAdmin = false;
            if (result.Succeeded)
            {
                isAdmin = _userMenager.IsInRoleAsync(user, "admin").Result;
            }

            if (result.IsNotAllowed)
            {
                throw new Exception("Username or password is not correct!");
            }
        }
        public UserViewModel GetCurrentUser(string userName)
        {
            try
            {
                User user = _userRepository.GetByUsername(userName);
                return new UserViewModel
                {
                    Id = user.Id,
                    Username = user.UserName,
                    FullName = user.FullName
                };
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }      

        public void LogOut()
        {
            _signInManager.SignOutAsync();
        }

        
    }
}
