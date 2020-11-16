using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Please insert username!")]
        public string  UserName { get; set; }
        [Required(ErrorMessage = "Please insert password!")]
        public string Password { get; set; }
    }
}
