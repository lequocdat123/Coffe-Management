using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DTO
{
    public class BillDetail
    {
        public BillDetail(int id, int billID, int productID, int count,int totalPrice)
        {
            this.ID = id;
            this.IDBill = billID;
            this.IDProduct = idProduct;
            this.Count = count;
            this.TotalPrice = totalPrice;

        }

        public BillDetail(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idbill"];
            this.IDProduct = (int)row["IDProduct"];
            this.Count = (int)row["count"];
            this.Count = (int)row["count"];

        }

        private int totalPrice;

        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int idProduct;

        public int IDProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        private int idBill;

        public int IDBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
