using SEDC.Lamazon.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.LAMAZON.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetByUsername(string userName);
        User GetById(string id);
    }
}
