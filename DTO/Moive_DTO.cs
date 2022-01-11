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
    public class Moive_DTO : DBConnection
    {
        public string nameMovie;
        public int idMovie;
        public string typeMovie;
        public string timeShow;
        public string hours;
        public void setnameMovie() { }
        public Moive_DTO(){}
        public Moive_DTO(int id, string name, string type, string time, string hours) 
        {
            this.idMovie = id;
            this.nameMovie = name;
            this.typeMovie = type;
            this.timeShow = time;
            this.hours = hours;
        }
        public bool InsertMovie()
        {
            try
            {
                con.Open();

                string SQL = string.Format("Insert into Movie values('{0}','{1}','{2}','{3}','{4}')",idMovie ,nameMovie ,typeMovie , hours, timeShow );

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
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
        public bool DeleteMovie(string ID)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from Movie where ID ='{0}'", ID);

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public bool EditMoive(int ID, string Name, string Type, string TimeShow, string Hours)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE Movie SET " +
                    "Name = '{1}',Type = '{2}',Date = '{3}' ,Time = '{4}'  where ID = {0}", ID,Name,Type,TimeShow,Hours);

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public DataTable DisplayMovie(string sql)
        {
            DataTable tblMovie = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();

            try
            {
                con.Open();
                MySqlCommand  cmd = new MySqlCommand (sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblMovie);  //Fill vào một biến kiểu Datatable
                return tblMovie;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
    
}
