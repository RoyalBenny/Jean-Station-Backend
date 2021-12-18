using JeanStationModels;

namespace DAL
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        User GetUser(string id);

        User CheckUser(User user); 
    }
}