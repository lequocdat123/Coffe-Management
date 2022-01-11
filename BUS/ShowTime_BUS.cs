using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
namespace BUS
{
    public class ShowTime_BUS
    {
        private int iD;
        private string Moviename;
        private string TimeStart;
        private string TimeEnd;
        int Roomnumber;
        private int Price;
        Showtime_DTO showtime = new Showtime_DTO();

        public string Moviename1 { get => Moviename; set => Moviename = value; }
        public string TimeStart1 { get => TimeStart; set => TimeStart = value; }
        public string TimeEnd1 { get => TimeEnd; set => TimeEnd = value; }
        public int ID { get => iD; set => iD = value; }
        public int Price1 { get => Price; set => Price = value; }

        public ShowTime_BUS() { }

        public ShowTime_BUS(DataRow row)
        {
            ID = (int)row["ID"];
            Moviename1 = row["Name"].ToString();
            Roomnumber =(int)row["Numberofroom"];
            TimeStart1 = row["TimeStart"].ToString();
            TimeEnd1 = row["TimeEnd"].ToString();
            Price1 =(int)row["Price"];
        }
        public ShowTime_BUS(int id, int IDMV, int IDRoom, int numberofseats, string timeStart, string timeEnd, string date, int price)
        {
            showtime = new Showtime_DTO(id, IDMV, IDRoom, numberofseats, timeStart, timeEnd, date ,price);
        }
        public bool Insert()
        {
            return showtime.Insert();
        }
        public bool Delete(string s)
        {
            return showtime.Delete(s);
        }
        public bool Edit(int id, int IDMV, int IDRoom, int numberofseats, string timeStart, string timeEnd, string date, int price)
        {
            return showtime.Edit(id, IDMV, IDRoom, numberofseats, timeStart, timeEnd, date, price);
        }
        public DataTable Display(string sql)
        {
            return showtime.Display(sql);
        }
    }
}
