using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DTO
{
    public class Seats_DTO :DBConnection
    {
        private int _ID;
        private int _Status;

        public Seats_DTO() { }
        public Seats_DTO(int id,int status) {
            _ID = id;
            _Status = status;
        }
        public int ID { get => ID; set => ID = value; }
        public int Status { get => _Status; set => _Status = value; }
        public bool Insert()
        {
            try
            {
                con.Open();

                string MySql = string.Format("Insert into Seat values('{0}')", _Status);

                MySqlCommand cmd = new MySqlCommand(MySql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }
        public bool Delete(int id)
        {
            try
            {
                con.Open();

                string MySql = string.Format("Delete from Seat where ID ='{0}'", id);

                MySqlCommand cmd = new MySqlCommand(MySql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public bool UpdateStatus(int id,bool status)
        {
            try
            {
                con.Open();

                string MySql = string.Format("UPDATE Seat SET " +
                    "Status = {1}  where ID = {0}", id,status);

                MySqlCommand cmd = new MySqlCommand(MySql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }

        public DataTable Display(string MySql)
        {
            DataTable tblSeats_Reserved = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(MySql, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblSeats_Reserved);
                return tblSeats_Reserved;
            }

            catch (Exception e) {
              
            }

            finally
            { con.Close(); }

            return null;
        }
    }
}
