using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DTO
{
    public class DBConnection
    {
        /*
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KB47I4H\SQLEXPRESS;Initial Catalog=SQLCinema;Integrated Security=True");
         */
        public static MySqlConnection
         GetDBConnection()
        {
            // Connection String.
            string host = "localhost";
            int port = 8080;
            string database = "quanlycafe";
            string username = "root";
            string password = "1234";

            string connString = $"Server=localhost; Database=quanlycafe; Port=3306; User ID=root; Password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
        protected MySqlConnection con = GetDBConnection();
    }
}
