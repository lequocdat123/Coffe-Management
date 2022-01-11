using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bill_BUS
    {
        public int ID;
        public int IDEmployee;
        public int IDTable;
        public string Date;
        public long TotalPrice;

        Bill_DTO bill = new Bill_DTO();
        public Bill_BUS() {  }
        public Bill_BUS(int id, int idemp, int idshowtime, string date, long totalprice)
        {
            bill = new Bill_DTO(id, idemp, idshowtime, date, totalprice);
        }
        public Bill_BUS(int id,int idemp, int idtable, long totalprice)
        {
            bill = new Bill_DTO(id,idemp, idtable, totalprice);
        }
        public bool Insert()
        {
            return bill.InsertBill();
        }
        public DataTable DisplayBill(string sql)
        {
            return bill.DisplayBill(sql);
        }
    }
}
