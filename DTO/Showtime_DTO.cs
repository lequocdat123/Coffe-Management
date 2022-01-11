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
    public class Showtime_DTO:DBConnection
    {
        private int ID;
        private int IDMovie;
        //private string nameMovie;
        private int Numberofseats; 
        private int Numberofroom;
        private string timeStart;
        private string timeEnd;
        private string date;
        private int Price;
        public Showtime_DTO() { }
        public Showtime_DTO(int id,int IDMV, int IDRoom, int numberofseats, string timeStart, string timeEnd,string date,int price)
        {
            this.ID = id;
            this.IDMovie = IDMV;
            this.Numberofroom = IDRoom;
            this.Numberofseats = numberofseats;
            //this.nameMovie = name;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.date = date;
            this.Price = price;
        }
        public DataTable Display(string sql)
        {
            DataTable dtbShowTime = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();
            try
            {
                con.Open();
                MySqlCommand  cmd = new MySqlCommand (sql, con);
                adt.SelectCommand = cmd;
                adt.Fill(dtbShowTime);
                return dtbShowTime;
            }
            catch (Exception e) { }
            finally
            {
                con.Close();
            }
            return null;
        }
        public bool Insert()
        {
            try
            {
                con.Open();
                string sql = string.Format("Insert into ShowTime values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ID, IDMovie, Numberofroom,Numberofseats,timeStart,timeEnd,Price,date);
                MySqlCommand  cmd = new MySqlCommand (sql, con);
                if(cmd.ExecuteNonQuery() > 0)
                {
                   /* DataTable data = this.Display("Select * from Seats_Reserved");
                    int i = data.Rows.Count;
                    for (int j = 0; j < 4; j++)
                    {

                        sql = string.Format("Insert into Seats_Reserved values('{0}','{1}','{2}','{3}'", ++i, ID, j + 1, 0);
                        cmd = new MySqlCommand (sql, con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }*/
                    return true;
                }
            }
            catch (Exception e){ }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool Delete (string id)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Delete from ShowTime where ID ='{0}'", id);

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { 
                con.Close(); 
            }
      
            return false;
        }

        public bool Edit(int id, int idmv, int idroom, int numberofseats, string timeStart, string timeEnd, string date, int price)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE ShowTime SET " +
                    "IDMovie = '{1}',Numberofroom = '{2}', Numberofseats = '{3}',TimeStart = '{4}',timeEnd = '{5}',Date = '{6}',Price = '{7}'  where ID = '{0}'", id, idmv, idroom,numberofseats,timeStart,timeEnd,date,price);

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
    }
}
