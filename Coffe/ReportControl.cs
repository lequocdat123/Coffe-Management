using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeShopManagerment.DTO;
using CoffeShopManagerment.DAO;

namespace CoffeShopManagerment
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
            string str = "Select * from Bill_Detail";
            /*List<BillDetail> billDetails = new List<BillDetail>();*/
            /*billDetails = BillDetail_DAO.Instance.GetAllBillDetail();*/
            DataTable billDetails = DBConnection.Instance.ExecuteQuery(str);
            label4.Text = billDetails.Rows.Count.ToString();
            long total = 0;
            foreach(DataRow i in billDetails.Rows)
            {
                total += (int)i["TotalPrice"];
            }
            label3.Text = total.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
