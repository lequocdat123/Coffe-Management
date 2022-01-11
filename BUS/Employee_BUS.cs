using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Employee_BUS
    {
       /* private int iD;
        private string name;
        private string username;
        private string password;*/
        Employee_DTO emp = new Employee_DTO();

       /* public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }*/

        public Employee_BUS()
        {
        }
        public Employee_BUS(int id, string name, string date, string user, string pass)
        {
            emp = new Employee_DTO(id, name, date, user, pass);
        }
        public int ID { get => emp.ID; set => emp.ID = value; }
        public string Name { get => emp.Name; set => emp.Name = value; }
        public string Dateofbirth { get => emp.Dateofbirth; set => emp.Dateofbirth = value; }
        public string Username { get => emp.Username; set => emp.Username = value; }
        public string Password { get => emp.Password; set => emp.Password = value; }
        public bool insertEmployee()
        {
            return emp.InsertEmployee();
        }
        public bool deleteEmployee(string s)
        {
            return emp.DeleteEmployee(s);
        }
        public bool EditEmployee(int id, string name, string date, string user, string pass)
        {
            return emp.EditEmployee(id, name, date, user, pass);
        }
        public DataTable displayEmployee(string sql)
        {
            return emp.DisplayEmployee(sql);
        }
        public bool checkLogin(string user,string pass)
        {
            return emp.checkLogin(user, pass);
        }
    }
}
