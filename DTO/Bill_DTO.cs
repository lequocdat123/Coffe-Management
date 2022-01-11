using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Utils;
using MySql.Data.MySqlClient;
namespace DTO
{
    public class Bill_DTO :DBConnection
    {
        private int ID;
        private int IDEmployee;
        private int IDTable;
        private string CheckIn;
        private string CheckOut;
        private int Status;

        private long TotalPrice;


        public Bill_DTO() { }
        public Bill_DTO(int id, int idemp, int idshowtime, string date, long totalprice)
        {
            this.ID = id;
            this.IDEmployee = idemp;
            this.TotalPrice = totalprice;
            this.CheckIn = date;
        }
        public Bill_DTO(int id ,int idemp, int idtable, long totalprice)
        {
            this.ID = id;
            this.IDEmployee = idemp;
            this.TotalPrice = totalprice;
            this.IDTable = idtable;
        }
        public Bill_DTO(int id, int idemp, string checkin,string checkout, int status,int idtable, long totalprice)
        {
            this.ID = id;
            this.IDEmployee = idemp;
            this.TotalPrice = totalprice;
            this.IDTable = idtable;
            this.CheckIn = checkin;
            this.CheckOut = checkout;
            this.Status = status;

    }
        public bool InsertBill()
        {
            try
            {
                con.Open();

                string SQL = $"INSERT INTO Bill(ID,IDEmployee, IDTable, CheckIn, CheckOut, Status, TotalPrice) VALUES({ID},{IDEmployee}, {IDTable}, '{DateTime.Now.ToString()}', '{DateTime.Now.ToString()}', 1, {TotalPrice});";

                MySqlCommand cmd = new MySqlCommand(SQL, con);
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
        
        public DataTable DisplayBill(string sql)
        {
            DataTable tblBil = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                adt.SelectCommand = cmd; 
                adt.Fill(tblBil); 
                return tblBil;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }

        public DataTable getItemsBill(int idBill)
        {
            DataTable tblBil = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();

            Bill_BillDetail billData = new Bill_BillDetail();
            try
            {
                con.Open();
                string SQL = $"SELECT * FROM BILL WHERE ID={idBill}";
                MySqlCommand cmd = new MySqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblBil);
                foreach (DataRow element in tblBil.Rows)
                {
                    //ShowTime_BUS showtime = new ShowTime_BUS(element);

                    Bill_DTO bill = new Bill_DTO((int)element["ID"], (int)element["IDEmployee"], element["CheckIn"].ToString(),element["CheckOut"].ToString(), (int)element["Status"], (int)element["IDTable"], (long)element["TotalPrice"]);
                    billData.setBill(bill);
                }
                return tblBil;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            DataTable tbBillDetail = new DataTable();
            MySqlDataAdapter adt2 = new MySqlDataAdapter();

            try
            {
                con.Open();
                string SQL = $"SELECT * FROM BILL_DETAIL WHERE IDBLL={idBill}";
                MySqlCommand cmd = new MySqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(tbBillDetail);
                List<Bill_Detail_DTO> billDetails = new List<Bill_Detail_DTO>();

                foreach (DataRow element in tbBillDetail.Rows)
                {
                    //ShowTime_BUS showtime = new ShowTime_BUS(element);

                   /* billDetails.Add(new Bill_Detail_DTO()
                    {
                        ID = (int)element["ID"],
                        IDBill = idBill,
                        IDProduct = (int)element["IDProduct"],

                        Quantity = (int)element["SL"],

                        Price = (long)element["TotalPrice"]
                    });
                    billData.setBill(bill);*/
                }
                return tblBil;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
