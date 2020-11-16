using SEDC.Lamazon.Domain.DomainModels;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterVM registerUser);
        void LogIn(LoginVM loginModel, out bool isAdmin);
        void LogOut();
        UserViewModel GetCurrentUser(string Username);

    }
}
