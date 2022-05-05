using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TimeSwap.DAL
{
    public sealed class Connection
    {
        private SqlConnection connection;


        public void OpenConnection()
        {
            string server = "Data Source=217.71.207.123,54321;";
            string database = "Initial Catalog=TimeSwap;";
            string security = "Persist Security Info=True;";
            string user = "User ID=sa;";
            string pass = "Password=123456789";


            try
            {
                connection = new SqlConnection(server + database + security + user + pass);
                connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public SqlConnection SqlConnection
        {
            get { return connection; }
        }


    }
}