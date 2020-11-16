using SEDC.Lamazon.WebModels.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public CategoryTypeVM CategoryTypeVM { get; set; }
    }
}
