using Northwind.Repository_api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository_service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDapperContext _context;
        private IAuthRepository _authRepository;

        public UnitOfWork(IDapperContext context)
        {
            _context = context;
        }
        public IAuthRepository AuthRepository => _authRepository ?? (_authRepository = new AuthRepository(_context));

        public void Commit()
        {
            _context.Commit();
        }

        public void Rollback()
        {
            _context.Rollback();
        }
    }
}
