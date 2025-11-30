using System;
using System.Data.SqlClient;

namespace WindowsFormsApp13
{
    public static class DbHelper
    {
        private static readonly string connectionString = @"Data Source=LAPTOP-F9EU6O5J\SQLEXPRESS;Initial Catalog=LeaveDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
