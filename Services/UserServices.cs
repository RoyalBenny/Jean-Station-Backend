using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using JeanStationModels;

namespace Services
{
    public class UserServices:IUserService
    {
        private readonly IUserRepository _repo;
        public UserServices(IUserRepository repo)
        {
            _repo = repo;
        }

        public User CreateUser(User user)
        {
            try
            {
                return _repo.CreateUser(user);
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUser(string id)
        {
            try
            {
               return _repo.GetUser(id);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
