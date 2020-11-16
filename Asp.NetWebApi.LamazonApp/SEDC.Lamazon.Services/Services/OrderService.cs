using AutoMapper;
using SEDC.Lamazon.Domain.DomainModels;
using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using SEDC.LAMAZON.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IRepository<Product> _productRepository;
        protected readonly IRepository<Order> _orderRepository;
        protected readonly IUserRepository _userRepository;
        protected readonly IMapper _mapper;
        public OrderService(IRepository<Product> productRepository, IRepository<Order> orderRepository, 
            IUserRepository userRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public IEnumerable<OrderVM> GetAllOrders()
        {
            IEnumerable<Order> orders = _orderRepository.GetAll();
            List<OrderVM> mappedOrder = _mapper.Map<List<OrderVM>>(orders);
            return mappedOrder;
        }
        public OrderVM GetCurrentOrder(string userId)
        {            
            try
            {
                Order order = _orderRepository.GetAll()
                                              .Where(x => x.UserId == userId)
                                              .LastOrDefault();
                OrderVM mappedOrder = _mapper.Map<OrderVM>(order);
                return mappedOrder;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                throw new Exception(message);
            }
        }
        public OrderVM GetOrderById(int id, string userId)
        {            
            try
            {
                User user = _userRepository.GetById(userId);
                Order order = _orderRepository.GetById(id);
                if(user.Id == order.UserId)
                {
                    return _mapper.Map<OrderVM>(order);
                }
                else
                {
                    return new OrderVM();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }
        //We add this additional GetOrderById method because we need to call it without userId in the OrderController
        //So instead of mixing the things, we separate the logic into two same methods with different declaration
        public OrderVM GetOrderById(int id)
        {
            try
            {
                return _mapper.Map<OrderVM>(_orderRepository.GetById(id));
            }
            catch (Exception ex)
            {
                string message = $"Order not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }
        public int AddProduct(int orderId, int productId, string userId)
        {
            try
            {
                Product product = _productRepository.GetById(productId);
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);
                order.ProductOrders.Add(
                    new ProductOrder
                    {
                        Product = product,
                        Order = order
                    }
                    );
                order.User = user;
                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public int CreateOrder(OrderVM order, string userId)
        {
            try
            {
                User user = _userRepository.GetById(userId);
                Order mappedOrder = _mapper.Map<Order>(order);
                mappedOrder.User = user;
    
                return _orderRepository.Insert(mappedOrder);
                
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                throw new Exception(message);
            }
            
        }
                 

        

        
        public int ChangeStatus(int orderId, string userId, StatusTypeVM status)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);

                //order.Status = status;
                order.Status = (StatusType)status;
                if(status == StatusTypeVM.Pending)
                {
                    _orderRepository.Insert(
                           new Order
                           {
                               User = user,
                               DateOfOrder = DateTime.Now,
                               Status = StatusType.Init
                           }
                        );
                }
                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                throw new Exception(message);
            }
        }
    }
}
