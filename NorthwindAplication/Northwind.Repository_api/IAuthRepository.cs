using Northwind.Model;

namespace Northwind.Repository_api
{
    public interface IAuthRepository : IBaseRepository<User>
    {
        User Register(User user, string password);
        User Login(string userid, string password);
        bool UserExists(string userid);
        void ChangePassword(string userid, string password);
    }
}