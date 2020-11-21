using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IInvoiceService
    {
        IEnumerable<InvoiceVM> GetAll(string userId);
        InvoiceVM GetById(int id, string userId);
        InvoiceVM GetByOrderId(int id, string userId);
        int Insert(InvoiceVM model, string userId, int orderId);
    }
}
