using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CricketAcademy.Library
{
    public class DataAccessLayer : IDisposable
    {

        private static DataAccessLayer instance = null;

        private IDbConnection _sharedConnection;
        private IDbTransaction _sharedTransaction;

        public DataAccessLayer()
        {
            try
            {
                _sharedConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TheConnectionString"].ConnectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create connection. " + ex.Message);
            }
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["TheConnectionString"].ConnectionString;
        }

        public static DataAccessLayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccessLayer();
                }
                return instance;
            }
        }

        public string ExecuteScalar(string query)
        {
            OpenSharedConnection();

            SqlCommand cmd = new SqlCommand(query, ((SqlConnection)_sharedConnection));
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }
            var val = cmd.ExecuteScalar();

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            if (val == null)
                return "-1";
            else
                return val.ToString();
        }

        public string ExecuteScalar(SqlCommand cmd)
        {
            OpenSharedConnection();

            cmd.Connection = (SqlConnection)_sharedConnection;
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }

            string val = cmd.ExecuteScalar().ToString();

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return val;
        }

        public DataTable ExecuteQuery(string query)
        {
            OpenSharedConnection();

            SqlCommand cmd = new SqlCommand(query, ((SqlConnection)_sharedConnection));
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return dt;
        }

        public DataTable ExecuteQuery(SqlCommand cmd)
        {
            OpenSharedConnection();

            cmd.Connection = (SqlConnection)_sharedConnection;
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            OpenSharedConnection();

            SqlCommand cmd = new SqlCommand(query, (SqlConnection)_sharedConnection);
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }

            int val = cmd.ExecuteNonQuery();

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return val;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            OpenSharedConnection();

            cmd.Connection = (SqlConnection)_sharedConnection;
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }

            int val = cmd.ExecuteNonQuery();

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return val;
        }

        public string GetLastInsertedId()
        {
            OpenSharedConnection();

            SqlConnection conn = (SqlConnection)GetSharedConnection();
            SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY();", conn);
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }

            string val = cmd.ExecuteScalar().ToString();

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return val;
        }

        public string GetLastInsertedId(string tableName)
        {
            OpenSharedConnection();

            SqlConnection conn = (SqlConnection)GetSharedConnection();
            SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('" + tableName + "');", conn);
            if (_sharedTransaction != null)
            {
                cmd.Transaction = (SqlTransaction)_sharedTransaction;
            }

            string val = cmd.ExecuteScalar().ToString();

            if (_sharedTransaction == null)
            {
                CloseSharedConnection();
            }

            return val;
        }


        public void CreateSharedConnection(string connectionString_)
        {
            if (_sharedConnection == null)
            {
                _sharedConnection = new SqlConnection(connectionString_);
            }
            else
            {
                throw new Exception("The connection is already created!");
            }
        }

        public void OpenSharedConnection()
        {
            try
            {
                if (_sharedConnection.State == ConnectionState.Closed)
                    _sharedConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to open connection. " + ex.Message);
            }
        }

        public void CloseSharedConnection()
        {
            try
            {
                if (_sharedConnection.State == ConnectionState.Open)
                    _sharedConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to close connection. " + ex.Message);
            }

        }

        public void BeginTransaction()
        {
            try
            {
                if (_sharedTransaction == null)
                {
                    OpenSharedConnection();
                    _sharedTransaction = _sharedConnection.BeginTransaction();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CommitTransaction()
        {
            try
            {
                if (_sharedTransaction != null)
                    _sharedTransaction.Commit();
                _sharedTransaction = null;
                CloseSharedConnection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                if (_sharedTransaction != null)
                    _sharedTransaction.Rollback();
                _sharedTransaction = null;
            }
            catch (Exception)
            {
                CloseSharedConnection();
                throw;
            }
        }

        public IDbConnection GetSharedConnection()
        {
            if (_sharedConnection != null)
                return _sharedConnection;
            else
                throw new Exception("The connection is not created.");
        }

        public IDbTransaction GetSharedTransaction()
        {
            if (_sharedTransaction != null)
                return _sharedTransaction;
            else
                throw new Exception("The transaction is not created.");
        }

        public void Dispose()
        {
            if (_sharedConnection != null)
            {
                _sharedConnection.Dispose();
                _sharedConnection = null;
            }

            if (_sharedTransaction != null)
            {
                _sharedTransaction.Dispose();
                _sharedTransaction = null;
            }
        }
    }

}
