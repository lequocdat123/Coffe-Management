using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DTO
{
    public class Bill
    {
        public Bill(int id, string dateCheckin, string dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            /*this.DateCheckIn = (DateTime?)row["Checkin"];*/

            var dateCheckOutTemp = row["CheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = dateCheckOutTemp.ToString();

            this.Status = (int)row["status"];

            /*if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];*/
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string dateCheckOut;

        public string DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private string dateCheckIn;

        public string DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
