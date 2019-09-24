using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL_api
{
    public interface IBaseBLL<T> where T : class
    {
        int Save(T obj);
        int Update(T obj);
        int Delete(T obj);
        IList<T> GetAll();
    }
}
