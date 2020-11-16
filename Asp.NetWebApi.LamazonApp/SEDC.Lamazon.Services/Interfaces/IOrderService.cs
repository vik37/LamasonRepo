using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderVM> GetAllOrders();

        OrderVM GetOrderById(int id, string userId);
        OrderVM GetOrderById(int id);
        int CreateOrder(OrderVM order, string userId);
        int AddProduct(int orderId, int productId, string userId);
        OrderVM GetCurrentOrder(string userId);
        int ChangeStatus(int orderId, string userId, StatusTypeVM status);
    }
}
