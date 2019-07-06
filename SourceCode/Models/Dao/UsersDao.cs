using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class UsersDao
    {
        Demomvc5DbContext db = null;
        public UsersDao()
        {
            db = new Demomvc5DbContext();
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.UserId;

        }

        public User  GetById(string UserName)
        {
            return db.Users.SingleOrDefault(x=>x.UserName == UserName);
        }

        public bool Login (string UserName ,string Password)
        {
            var result = db.Users.Count(x => x.UserName == UserName && x.Password == Password);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
