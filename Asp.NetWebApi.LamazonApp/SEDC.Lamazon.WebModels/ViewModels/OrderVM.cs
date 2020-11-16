using SEDC.Lamazon.WebModels.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class OrderVM
    {
        public int Id { get; set; }
        public StatusTypeVM StatusTypeVM { get; set; }
        public UserViewModel UserVM { get; set; }
        public List<ProductVM> ProductsVM { get; set; }
        public double Price => ProductsVM.Sum(p => p.Price);
    }
}
