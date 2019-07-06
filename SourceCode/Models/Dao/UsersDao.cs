using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    class UsersDao
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
    }
}
