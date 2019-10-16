using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
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

        public void ChangePassword(string userid, string password)
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

        public User Login(string userid, string password)
        {
            var user = _context.db.Get<User>(userid);

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

        public bool UserExists(string userid)
        {
            if (_context.db.QueryFirst<bool>("Select Count(1) From TblUser where UserId = @userid", new { userid }))
                return true;

            return false;
        }

        public User Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.passwordSalt = passwordSalt;
            user.passwordHash = passwordHash;
            _context.db.Insert<User>(user);
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}