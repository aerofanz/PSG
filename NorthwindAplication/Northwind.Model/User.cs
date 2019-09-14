using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model
{
    [Table("TblUser")]
    public class User
    {
        [ExplicitKey]
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
        public bool notActive { get; set; }
        public int roles { get; set; }
    }
}
