using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using Northwind.Model;
using Northwind.Repository_api;

namespace Northwind.Repository_service
{
    public class AuthRepository : IAuthRepository
    {
        private IDapperContext _context;

        public AuthRepository(IDapperContext context)
        {
            _context = context;
        }

        public void ChangePassword(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(User obj)
        {
            throw new System.NotImplementedException();
        }

        public IList<User> GetAll()
        {
            var user = _context.db.GetAll<User>().ToList();
            return user;
        }

        public User Login(string username, string password)
        {
            var user = _context.db.Get<User>(username);

            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.passwordHash, user.passwordSalt))
                return null;

            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for(int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }

                return true;
            }
        }

        public int Save(User obj)
        {
            throw new System.NotImplementedException();
        }

        public int Update(User obj)
        {
            throw new System.NotImplementedException();
        }

        public bool UserExists(string username)
        {
            throw new System.NotImplementedException();
        }

       
    }
}