using Northwind.Model;

namespace Northwind.Repository_api
{
    public interface IAuthRepository : IBaseRepository<User>
    {
        User Login(string username, string password);
        bool UserExists(string username);
        void ChangePassword(string username, string password);
    }
}