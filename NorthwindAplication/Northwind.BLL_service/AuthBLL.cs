using Northwind.BLL_api;
using Northwind.Model;
using Northwind.Repository_api;
using Northwind.Repository_service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL_service
{
    public class AuthBLL : IAuthBLL
    {
        private IDapperContext _context;
        private IUnitOfWork _uow;
        public AuthBLL()
        {
            _context = new DapperContext();
            _uow = new UnitOfWork(_context);
        }
        public int Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password, ref User user)
        {
            bool result = false;

            try
            {
                user = _uow.AuthRepository.Login(username, password);
                if (user == null)
                    result = false;
                else
                    result = true;
            }
            catch
            {
                _uow.Rollback();
                throw;
            }
            finally
            {
                _uow.Commit();
            }

            return result;
        }

        public int Save(User obj)
        {
            throw new NotImplementedException();
        }

        public int Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
