using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.Lamazon.Domain.DomainModels
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public List<Order> Orders { get; set; }

    }
}
