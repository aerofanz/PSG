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
            try
            {
                var result = _uow.AuthRepository.GetAll().ToList();
                _uow.Commit();
                return result;
            }
            catch 
            {
                _uow.Rollback();
                throw;
            }
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

        public int Register(UserForRegister userForRegister)
        {
            try
            {
                if (_uow.AuthRepository.UserExists(userForRegister.UserId))
                    return 2; // user telah ada

                var userToCreate = new User
                {
                    firstName = userForRegister.FirstName,
                    lastName = userForRegister.LastName,
                    roles = userForRegister.Roles,
                    userId = userForRegister.UserId
                };
                _uow.AuthRepository.Register(userToCreate, userForRegister.Password);
                _uow.Commit();
                return 1;

            }
            catch (Exception)
            {
                _uow.Rollback();
                return 0;
                throw;
            }
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
