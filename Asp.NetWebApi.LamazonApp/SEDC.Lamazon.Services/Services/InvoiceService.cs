using AutoMapper;
using SEDC.Lamazon.Domain.DomainModels;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepo;
        private readonly IRepository<Order> _orderRepo;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        public InvoiceService(IRepository<Invoice> invoiceRepo, IRepository<Order> orderRepo, IUserRepository userRepo, IMapper mapper)
        {
            _invoiceRepo = invoiceRepo;
            _orderRepo = orderRepo;
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public IEnumerable<InvoiceVM> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public InvoiceVM GetById(int id, string userId)
        {
            return _mapper.Map<InvoiceVM>(_invoiceRepo.GetById(id));
        }

        public InvoiceVM GetByOrderId(int id, string userId)
        {
            Order order = _orderRepo.GetById(id);
            return _mapper.Map<InvoiceVM>(_invoiceRepo.GetById(order.Invoice.Id));
        }

        public int Insert(InvoiceVM model, string userId, int orderId)
        {
            Order order = _orderRepo.GetById(orderId);
            Invoice invoice = _mapper.Map<Invoice>(model);
            invoice.Order = order;
            return _invoiceRepo.Insert(invoice);
        }
    }
}
