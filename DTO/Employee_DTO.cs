using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee_DTO :DBConnection
    {
        private int _ID;
        private string _Name;
        private string _Dateofbirth;
        private string _Username;
        private string _Password;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Dateofbirth { get => _Dateofbirth; set => _Dateofbirth = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }

        public Employee_DTO(){}
        public Employee_DTO(int id, string name, string dateofbirth, string user, string pass) 
        {
            this.ID = id;
            this.Name = name;
            this.Dateofbirth = dateofbirth;
            this.Username = user;
            this.Password = pass;
        }
        public bool InsertEmployee()
        {
            try
            {
                con.Open();

                string SQL = string.Format("Insert into Employee values('{1}','{2}','{3}','{4}')" ,Name ,Dateofbirth , Username, Password );

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
        public bool DeleteEmployee(string ID)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from Employee where ID ='{0}'", ID);

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public bool EditEmployee(int id, string name, string dateofbirth, string user, string pass)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE Employee SET " +
                    "Name = '{1}',Dateofbirth = '{2}',username = '{3}' ,Password = '{4}'  where ID = {0}", id,name,dateofbirth,user,pass);

                MySqlCommand  cmd = new MySqlCommand (SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public DataTable DisplayEmployee(string sql)
        {
            DataTable tblEmp = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();
            MySqlConnection conn = DBConnection.GetDBConnection();
            try
            {
                conn.Open();
                MySqlCommand  cmd = new MySqlCommand (sql, conn);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblEmp);  //Fill vào một biến kiểu Datatable
                return tblEmp;
            }

            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            finally
            { conn.Close(); }

            return null;
        }
        public bool checkLogin(string user, string pass)
        {   
            if (_Username.Equals(user) && _Password.Equals(pass))
                return true;
            return false;
        }
    }
    }
