using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DTO
{
    public class Table
    {
        public Table(int id, int status)
        {
            this.ID = id;
            this.Status = status;
        }
        public Table()
        {

        }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Status = (int)row["status"];
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }



        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
