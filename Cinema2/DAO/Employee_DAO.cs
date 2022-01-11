using CoffeShopManagerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DAO
{
    public class Employee_DAO
    {
        private static Employee_DAO instance;
        public static Employee_DAO Instance
        {
            get { if (instance == null) instance = new Employee_DAO(); return instance; }
            private set { instance = value; }
        }

        private Employee_DAO() { }

        public List<Employee> GetEmployees()
        {
                List<Employee> listEmployee = new List<Employee>();

                DataTable data = DBConnection.Instance.ExecuteQuery("SELECT * FROM Employee");

                foreach (DataRow item in data.Rows)
                {
                    Employee employee = new Employee(item);
                listEmployee.Add(employee);
                }

                return listEmployee;
        }
        public bool InsertEmployee(string name, string dateofbirth, string user, string pass)
        {

            string SQL = $"INSERT INTO Employee ( Name, Dateofbirth, Username, Password) VALUES ( N'{name}', N'{dateofbirth}', N'{user}', N'{pass}');";

            int check = DBConnection.Instance.ExecuteNonQuery(SQL);


            return check == 1 ? true : false;
        }
        public bool InsertEmployee(int id,string name, string dateofbirth, string user, string pass)
        {

            string SQL = $"INSERT INTO Employee ( ID,Name, Dateofbirth, Username, Password) VALUES ( {id},N'{name}', N'{dateofbirth}', N'{user}', N'{pass}');";

            int check = DBConnection.Instance.ExecuteNonQuery(SQL);


            return check == 1 ? true : false;
        }
        public bool DeleteEmployee(string ID)
        {

            string SQL = string.Format("Delete from Employee where ID ='{0}'", ID);
            int check = DBConnection.Instance.ExecuteNonQuery(SQL);


            return check == 1? true : false;
        }
        public bool EditEmployee(int id, string name, string dateofbirth, string user, string pass)
        {
            

                string SQL = string.Format("UPDATE Employee SET " +
                    "Name = '{1}',Dateofbirth = '{2}',username = '{3}' ,Password = '{4}'  where ID = {0}", id, name, dateofbirth, user, pass);
            int check = DBConnection.Instance.ExecuteNonQuery(SQL);


            return check == 1 ? true : false;

        }
       
    }
}
