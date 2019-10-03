using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using Northwind.Model;
using Northwind.Repository_api;

namespace Northwind.Repository_service
{
    internal class RoleRepository : IRoleRepository
    {
        private IDapperContext _context;

        public RoleRepository(IDapperContext context)
        {
            _context = context;
        }

        public int Delete(Roles obj)
        {
            throw new System.NotImplementedException();
        }

        public IList<Roles> GetAll()
        {
            var roles = _context.db.GetAll<Roles>().ToList();
            return roles;
        }


        public int Save(Roles obj)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Roles obj)
        {
            throw new System.NotImplementedException();
        }
    }
}