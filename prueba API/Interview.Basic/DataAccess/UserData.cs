using Interview.Basic.DataAccess.Interfaces;
using Interview.Basic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Basic.DataAccess
{
    public class UserData : IUserData
    {
        private List<User> _data = new List<User>
        {
            new User {Id = 1, Name="Yuraima", LastName="Gonzalez", Address ="Montevideo Uruguay", CreateDate = DateTime.Now},
            new User {Id = 2, Name="Ernesto", LastName="Gonzalez", Address = "Puerto Ordaz Venezuela", CreateDate = DateTime.Now},
            new User {Id = 3, Name="Nesby", LastName="Gonzalez", Address = "Puerto Ordaz Venezuela", CreateDate = DateTime.Now}
        };

        public User Add(User user)
        {
            int nextId = 1;
            if (_data != null && _data.Count > 0)
            {
                nextId = _data.Max(t => t.Id) + 1;
            }
            user.CreateDate = DateTime.Now;
            user.Id = nextId;
            _data.Add(user);
            return user;
        }

        public bool Delete(int id)
        {
            if (id > 0)
            {
                _data.RemoveAll(i => i.Id == id);
                return true;
            }
            else
            {
                throw new Exception("No se puede eliminar el Usuario Administrador");
            }
        }

        public List<User> GetAll()
        {
            return _data;
        }

        public User GetById(int id)
        {
            return _data.FirstOrDefault(u => u.Id == id);
        }

        public bool Update(int id, User user)
        {
            User toUpdate = _data.FirstOrDefault(u => u.Id == id);
            if(toUpdate != null)
            {
                toUpdate.UpdateDate = DateTime.Now;
                toUpdate.Name = user.Name;
                toUpdate.LastName = user.LastName;
                toUpdate.Address = user.Address;
                return true;
            }
            return false;
        }
    }
}
