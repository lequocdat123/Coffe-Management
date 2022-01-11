using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DTO
{
    public class Bill_Detail_DTO :DBConnection
    {
        private int ID;
        private int IDBill;
        private int IDProduct;

        private int Quantity;
        private long Price;

        public Bill_Detail_DTO() { }

        public Bill_Detail_DTO( int idbill, int IDProduct, int quantity,long price)
        {
            this.IDBill = idbill;
            this.IDProduct = IDProduct;
            this.Quantity = quantity;
            this.Price = price;
        }
        public bool InsertBill_Detail()
        {
            try
            {
                con.Open();

                string SQL = $"INSERT INTO Bill_Detail ( IDBill, IDProduct,SL, TotalPrice) VALUES ({IDBill}, {IDProduct},{Quantity}, {Price});";
                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception )
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public DataTable Display_Bill_Detail(string sql)
        {
            DataTable tblBill_Detail = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();

            try
            {
                con.Open();
                MySqlCommand  cmd = new MySqlCommand (sql, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblBill_Detail);
                return tblBill_Detail;
            }

            catch (Exception ) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}

