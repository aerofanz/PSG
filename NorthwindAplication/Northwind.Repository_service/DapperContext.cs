using Dapper;
using Northwind.Repository_api;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Repository_service
{
    public class DapperContext : IDapperContext
    {
        private IDbConnection _db;
        private IDbTransaction _transaction;

        private readonly string _providerName;
        private readonly string _connectionString;
        public DapperContext()
        {
            var server = "(local)";
            var dbName = "Northwind";
            var userId = "sa";
            var userPassword = "123";

            _providerName = "System.Data.SqlClient";
            _connectionString = string.Format("Server={0};Database={1};" +
                "User Id={2};Password={3}", server, dbName, userId, userPassword);

            if (_db == null)
                _db = GetOpenConnection(_providerName, _connectionString);

        }

        private IDbConnection GetOpenConnection(string providerName, string connectionString)
        {
            DbConnection conn = null;
            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
                conn = provider.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return conn;
        }

        public IDbConnection db
        {
            get { return _db ?? (_db = GetOpenConnection(_providerName, _connectionString)); }
        }

        public IDbTransaction transaction
        {
            get { return _transaction; }
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            if (_transaction == null)
                _transaction = _db.BeginTransaction(isolationLevel);
        }

        public void Commit()
        {
            if(_transaction != null)
            {
                _transaction.Commit();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            if(_db != null)
            {
                try
                {
                    if (_db.State != ConnectionState.Closed)
                    {
                        if (_transaction != null)
                            _transaction.Rollback();

                        _db.Close();
                    }
                }
                finally
                {
                    _db.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }

        public bool ExecSQL(string sql)
        {
            var result = false;
            try
            {
                _db.Execute(sql);
                result = true;
            }
            catch {}

            return result;
        }

        public string getGUID()
        {
            var result = string.Empty;
            try
            {
                result = Guid.NewGuid().ToString();
            }
            catch
            {}

            return result;
        }

        public bool IsOpenConnection()
        {
            var isConnected = false;
            try
            {
                using (var conn = GetOpenConnection(_providerName, _connectionString))
                {
                    isConnected = conn.State == ConnectionState.Open;
                }
            }
            catch {}
            return isConnected;
        }

        public void Rollback()
        {
            if(_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }
    }
}
