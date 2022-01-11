using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeShopManagerment.DAO
{
    public class DBConnection
    {
        private static DBConnection instance;
        public static DBConnection Instance
        {
            get { if (instance == null) instance = new DBConnection(); return DBConnection.instance; }
            private set { DBConnection.instance = value; }
        }
        private DBConnection() { }
        string connString = @"Data Source=DESKTOP-NEURE7V\TAOLADAT;Initial Catalog=QLCafe;Integrated Security=True"; 
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            DataTable tblBil = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                adt.SelectCommand = cmd;
                adt.Fill(data);
            }
            catch (Exception ) { }
            finally
            { conn.Close(); }

            return data;

        }
        public int ExecuteNonQuery(string query)
        {
            DataTable data = new DataTable();
            DataTable tblBil = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return 1;
            }

            catch (Exception ) { return -1; }

            finally
            { conn.Close(); }

            return -1;

        }
    }


}
