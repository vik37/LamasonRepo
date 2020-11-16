using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please insert first name!")]
        [Display(Name ="Enter first name:")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please insert last name!")]
        [Display(Name = "Enter last name:")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please insert email!")]
        [Display(Name = "Enter email:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please insert address!")]
        [Display(Name = "Enter address:")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please insert user name!")]
        [Display(Name = "Enter user name:")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please insert password!")]
        [Display(Name = "Enter password:")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please insert confirm password!")]
        [Display(Name = "Enter confirm password:")]
        public string ConfirmPassword { get; set; }
    }
}
