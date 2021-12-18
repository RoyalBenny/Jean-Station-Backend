using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IUserService
    {
        User CreateUser(User user);
        User GetUser(string id);

        User CheckUser(User user);
    }
}
