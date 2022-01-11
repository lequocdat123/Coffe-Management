using CoffeShopManagerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DAO
{
    public class BillDetail_DAO
    {
        private static BillDetail_DAO instance;

        public static BillDetail_DAO Instance
        {
            get { if (instance == null) instance = new BillDetail_DAO(); return BillDetail_DAO.instance; }
            private set { BillDetail_DAO.instance = value; }
        }

        private BillDetail_DAO() { }

        public void DeleteBillDetail(int id)
        {
            DBConnection.Instance.ExecuteQuery("delete From Bill_Detail WHERE ID = " + id);
        }

        public void DeleteBillDetailByIDBill(int idbill)
        {
            DBConnection.Instance.ExecuteQuery("delete From Bill_Detail WHERE IDBill = " + idbill);
        }
        public List<BillDetail> GetListBillDetail(int id)
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();

            DataTable data = DBConnection.Instance.ExecuteQuery("SELECT * FROM Bill_Detail WHERE IDBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillDetail info = new BillDetail(item);
                listBillDetail.Add(info);
            }

            return listBillDetail;
        }
        public List<BillDetail> GetAllBillDetail()
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();

            DataTable data = DBConnection.Instance.ExecuteQuery("SELECT * FROM Bill_Detail");

            foreach (DataRow item in data.Rows)
            {
                BillDetail info = new BillDetail(item);
                listBillDetail.Add(info);
            }

            return listBillDetail;
        }

        public int InsertBillDetail(int idBill, int iDProduct, int count,long totalPrice)
        {
            string query = $"INSERT INTO Bill_Detail(IdBill, IDProduct, Count, TotalPrice) VALUES({idBill},{iDProduct},{count},{totalPrice});";

            return DBConnection.Instance.ExecuteNonQuery(query);
        }
    }
}
