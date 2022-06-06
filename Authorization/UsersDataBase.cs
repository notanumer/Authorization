using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    public class UsersDataBase
    {
        private const string connectionString = @"Data Source=LAPTOP-2V5DCBSC\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True";
        private readonly SqlConnection dbConnection = new(connectionString);

        public void OpenConnection()
        {
            if (dbConnection.State == System.Data.ConnectionState.Closed)
                dbConnection.Open();
        }

        public void CloseConnection()
        {
            if (dbConnection.State == System.Data.ConnectionState.Open)
                dbConnection.Close();
        }

        public SqlConnection GetConnection() => dbConnection;
    }
}
