using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Seats_BUS
    {
        private int _ID;

        private int _Status;
        Seats_DTO s =new Seats_DTO();
        public Seats_BUS() { }
        public Seats_BUS(int id, int status)
        {
            s = new Seats_DTO(id,status);
        }
        public int Id { get => _ID; set => _ID = value; }

        public int Status { get => _Status; set => _Status = value; }
        public bool Insert()
        {
            return s.Insert();
        }
        public bool UpdateStatus(int id,bool status)
        {
            return s.UpdateStatus(id, status);
        }
        public bool Delete(int id)
        {
            return s.Delete(id);
        }
        public DataTable Display(string sql)
        {
            return s.Display(sql);
        }
    }
}
