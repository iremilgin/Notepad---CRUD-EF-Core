using ErdincHocaCozumAss15.Context;
using ErdincHocaCozumAss15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincHocaCozumAss15.Repositories
{
    internal class UserRepository
    {
        public UserRepository()
        {
            dbContext = new();
        }
        AppDbContext dbContext;

        public User GetById(int id)
        {
            return dbContext.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return dbContext.Users.Where(a => a.UserType == Enum.UserType.Standart).ToList();
        }

        public User GetByUserName(string userName)
        {
            return dbContext.Users.FirstOrDefault(a => a.UserName == userName);
        }

        public bool Add(User user)
        {
            dbContext.Users.Add(user);
            int affRows = dbContext.SaveChanges();
            return  affRows > 0;
        }

        public bool Delete(int id)
        {
            User user = GetById(id);
            dbContext.Users.Remove(user);
            return dbContext.SaveChanges() > 0; 
        }

        public bool Update(User user) 
        {
             dbContext.Users.Update(user); //Database'de veri yok ise bir değer ekler. Var ise günceller.
            return dbContext.SaveChanges() > 0;
        }


    }
}
