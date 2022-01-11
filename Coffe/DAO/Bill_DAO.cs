using CoffeShopManagerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DAO
{
    public class Bill_DAO
    {
        private static Bill_DAO instance;

        public static Bill_DAO Instance
        {
            get { if (instance == null) instance = new Bill_DAO(); return Bill_DAO.instance; }
            private set { Bill_DAO.instance = value; }
        }

        private Bill_DAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int idTable)
        {
            DataTable data = DBConnection.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + idTable + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public void CheckOut(int id,  long totalPrice)
        {
            string query = $"UPDATE Bill SET CheckOut = '{DateTime.Now.ToString()}', status = 1, totalPrice = {totalPrice} WHERE id = {id}";
            DBConnection.Instance.ExecuteNonQuery(query);
        }
        public int InsertBill(int id,int idEmp, int idTable, string checkIn,string checkOut,int status, long totalPrice)
        {
            string query = $"INSERT INTO Bill(ID,IDEmployee, IDTable, CheckIn,CheckOut, Status, TotalPrice) VALUES({id},{idEmp},{idTable},N'{checkIn}',N'{checkOut}',{status},{totalPrice});";

            try
            {
                return DBConnection.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ) { 
                return -1;
            }

        }

        public int UpdateItemBill(int id, long totalPrice)
        {
            string query = "UPDATE Bill SET totalPrice = " + totalPrice + " WHERE id = " + id;
            return DBConnection.Instance.ExecuteNonQuery(query);
        }

        public List<Bill> GetDBills()
        {
            List<Bill> listBill = new List<Bill>();

            try
            {
                DataTable data =  DBConnection.Instance.ExecuteQuery("SELECT * FROM Bill");
                foreach (DataRow item in data.Rows)
                {
                    Bill Product = new Bill(item);
                    listBill.Add(Product);
                }

                return listBill;
            }
            catch
            {
                return listBill;
            }
        }
    }
}
