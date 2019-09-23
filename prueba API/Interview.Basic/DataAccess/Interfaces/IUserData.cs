using Interview.Basic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Basic.DataAccess.Interfaces
{
    public interface IUserData
    {
        List<User> GetAll();
        User GetById(int id);
        User Add(User user);
        bool Update(int id, User user);
        bool Delete(int id);
    }
}
