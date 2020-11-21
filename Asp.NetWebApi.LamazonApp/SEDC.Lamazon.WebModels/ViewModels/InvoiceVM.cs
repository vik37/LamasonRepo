using SEDC.Lamazon.WebModels.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class InvoiceVM
    {
        public int Id { get; set; }
        public string Address { get; set; }
        //public int CardNumber { get; set; }
        public int SumOfPrice { get; set; }
        public PaymentTypeVM PaymentType { get; set; }
        public OrderVM OrderVM { get; set; }
    }
}
