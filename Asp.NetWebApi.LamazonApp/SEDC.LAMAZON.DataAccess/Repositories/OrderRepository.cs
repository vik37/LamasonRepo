using SEDC.Lamazon.Domain.DomainModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.LAMAZON.DataAccess.Repositories
{
    public class OrderRepository : BaseRepository,IRepository<Order>
    {
        public OrderRepository(LamazonDbContext db) : base(db){ }

        public IEnumerable<Order> GetAll()
        {
            return _db.Orders;
        }

        public Order GetById(int id)
        {
            return _db.Orders.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            _db.Orders.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(Order entity)
        {
            _db.Orders.Update(entity);
            return _db.SaveChanges();
        }
        public int Delete(int id)
        {
            Order order = _db.Orders.SingleOrDefault(x => x.Id == id);
            if (order == null)
                return -1;
            _db.Orders.Remove(order);
            return _db.SaveChanges();
        }
    }
}
