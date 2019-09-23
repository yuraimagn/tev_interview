using Interview.Api.Models;
using Interview.Basic.DataAccess.Interfaces;
using Interview.Basic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Interview.Api.Controllers
{
    public class UserController : ApiController
    {
        private IUserData _userData;
        public UserController(IUserData userData)
        {
            _userData = userData;
        }
        public IEnumerable<User> Get()
        {
            return _userData.GetAll();
        }

        public User Get(int id)
        {
            return _userData.GetById(id);
        }

        public ApiResult Post([FromBody]User value)
        {
            ApiResult result = new ApiResult();
            try
            {
                User newData = _userData.Add(value);
                if(newData != null)
                {
                    result.IsError = false;
                    result.Message = "Usuario creado con exito";
                    result.data = newData;
                } else
                {
                    result.CodeMsg = 1;
                    result.IsError = true;
                    result.Message = "No se pudo crear el usuario";
                }
            }
            catch (Exception ex)
            {
                result.CodeMsg = 2;
                result.IsError = true;
                result.Message = ex.Message;
            }
            return result;
        }
        public ApiResult Put(int id, [FromBody]User value)
        {
            ApiResult result = new ApiResult();
            try
            {
                if(_userData.Update(id,value))
                {
                    result.IsError = false;
                    result.Message = "Usuario actualizado con exito";
                }
                else
                {
                    result.CodeMsg = 1;
                    result.IsError = true;
                    result.Message = "No se pudo actualizar el usuario";
                }
            }
            catch (Exception ex)
            {
                result.CodeMsg = 2;
                result.IsError = true;
                result.Message = ex.Message;
            }
            return result;
        }

        public ApiResult Delete(int id)
        {
            ApiResult result = new ApiResult();
            try
            {
                if(_userData.Delete(id))
                {
                    result.IsError = false;
                    result.Message = "Usuario eliminado con exito";
                }
                else
                {
                    result.CodeMsg = 1;
                    result.IsError = true;
                    result.Message = "No se pudo eliminar el usuario";
                }
            }
            catch (Exception ex)
            {
                result.CodeMsg = 2;
                result.IsError = true;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
