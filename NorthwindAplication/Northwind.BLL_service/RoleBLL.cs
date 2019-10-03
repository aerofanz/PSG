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
    public class RoleBLL : IRoleBLL
    {
        private IDapperContext _context;
        private IUnitOfWork _uow;
        public RoleBLL()
        {
            _context = new DapperContext();
            _uow = new UnitOfWork(_context);
        }
        public int Delete(Roles obj)
        {
            throw new NotImplementedException();
        }

        public IList<Roles> GetAll()
        {
            try
            {
                var role = _uow.RoleRepository.GetAll().ToList();
                _uow.Commit();
                return role;
            }
            catch 
            {
                _uow.Rollback();
                throw;
            }
            
        }

        public int Save(Roles obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Roles obj)
        {
            throw new NotImplementedException();
        }
    }
}
