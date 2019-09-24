using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL_api
{
    public interface IAuthBLL : IBaseBLL<User>
    {
        bool Login(string username, string password, ref User user);
    }
}
