using SEDC.Lamazon.Domain.DomainModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.LAMAZON.DataAccess.Repositories
{
    public class InvoiceRepository : BaseRepository, IRepository<Invoice>
    {
        public InvoiceRepository(LamazonDbContext db) : base(db) { }
                        
        public IEnumerable<Invoice> GetAll()
        {
            return _db.Invoice;
        }

        public Invoice GetById(int id)
        {
            return _db.Invoice.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Invoice entity)
        {
            _db.Invoice.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(Invoice entity)
        {
            _db.Invoice.Add(entity);
            return _db.SaveChanges();
        }
        public int Delete(int id)
        {
            Invoice invoice = _db.Invoice.FirstOrDefault(x => x.Id == id);
            if (invoice == null) return -1;
            _db.Invoice.Remove(invoice);
            return _db.SaveChanges();
        }

    }
}
