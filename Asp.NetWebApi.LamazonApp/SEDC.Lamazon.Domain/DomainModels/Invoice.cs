using SEDC.Lamazon.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.Lamazon.Domain.DomainModels
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Address { get; set; }
        public int CardNumber { get; set; }
        public int SumOfPrice { get; set; }
        public PaymentType  PaymentType { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
