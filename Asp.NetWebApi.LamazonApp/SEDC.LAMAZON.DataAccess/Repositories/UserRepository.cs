using SEDC.Lamazon.Domain.DomainModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.LAMAZON.DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(LamazonDbContext db) : base(db) { }
        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }
        public User GetById(string id)
        {
            return _db.Users.SingleOrDefault(x => x.Id == id);
        }

        public User GetByUsername(string userName)
        {
            return _db.Users.SingleOrDefault(x => x.UserName == userName);
        }

        public int Insert(User entity)
        {
            _db.Users.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(User entity)
        {
            _db.Users.Update(entity);
            return _db.SaveChanges();
        }
        public int Delete(string id)
        {
            User user = _db.Users.SingleOrDefault(x => x.Id == id);

            if (user == null)
                return -1;
            _db.Users.Remove(user);
            return _db.SaveChanges();
        }
    }
}
