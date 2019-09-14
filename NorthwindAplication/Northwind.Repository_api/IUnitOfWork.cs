using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository_api
{
    public interface IUnitOfWork
    {
        IAuthRepository AuthRepository { get;  }
        void Commit();
        void Rollback();
    }
}
