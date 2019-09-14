using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository_api
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection db { get;  } // koneksi ke database
        IDbTransaction transaction { get;  } // transaksi database
        bool IsOpenConnection(); // cek apakah koneksi terbuka
        bool ExecSQL(string sql); // cek eksekusi database berhasil atau tidak
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted); // transaksi awal 
        void Commit(); // kalau transaksi berhasil , data di masukan ke database
        void Rollback(); // kalau ada transaksi gagal, data akan di tarik kembali
        string getGUID(); // untuk mengambil Penanda Unik Global atau Globally Unique Identifier

    }
}
