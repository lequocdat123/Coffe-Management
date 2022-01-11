using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DTO
{
    public class Employee
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
        public Employee()
        {
           

        }
        public Employee(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = (string)row["name"];
            this.Dateofbirth = (string)row["Dateofbirth"];
            this.Username = (string)row["username"];
            this.Password = (string)row["password"];

        }
        public bool checkLogin(string user, string pass)
        {
            if (_Username.Equals(user) && _Password.Equals(pass))
                return true;
            return false;
        }
    }
}
