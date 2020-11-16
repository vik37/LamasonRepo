using SEDC.Lamazon.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.LAMAZON.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);

    }
}
