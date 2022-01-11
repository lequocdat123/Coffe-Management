 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeShopManagerment.DAO;

namespace CoffeShopManagerment
{
    public partial class BillControl : UserControl
    {
        class Temp
        {
            public string ID { get; set; }
            public string NameEmp { get; set; }
            public int IDTable { get; set; }
            public string Checkin { get; set; }
            public string CheckOut { get; set; }
            public int Status { get; set; }
            public long totalPrice { get; set; }


        }
        List<Temp> temps = new List<Temp>();

        public BillControl()
        {
            InitializeComponent();
            grdBill.BorderStyle = BorderStyle.None;
            grdBill.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdBill.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdBill.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grdBill.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdBill.BackgroundColor = Color.White;

            grdBill.EnableHeadersVisualStyles = false;
            grdBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grdBill_Detail.BorderStyle = BorderStyle.None;
            grdBill_Detail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdBill_Detail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdBill_Detail.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grdBill_Detail.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdBill_Detail.BackgroundColor = Color.White;

            grdBill_Detail.EnableHeadersVisualStyles = false;
            grdBill_Detail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdBill_Detail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdBill_Detail.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void LoadgrdBill()
        {
            try
            {
                string sql = "Select b.ID,e.Name as 'NameEmp', b.IDTable,b.Checkin,b.CheckOut , b.Status,b.totalPrice from Bill b,Employee e WHERE e.ID = b.IDEmployee";
                DataTable tblBill = new DataTable();
                tblBill = DBConnection.Instance.ExecuteQuery(sql);
                grdBill.DataSource = tblBill;
                grdBill.AllowUserToAddRows = false;
                temps.Clear();
                foreach (DataRow row in tblBill.Rows)
                {


            
                    temps.Add(new Temp() {
                        ID = row[0].ToString(),
                        NameEmp = row[1].ToString(),
                        IDTable = (int)row[2],
                        Checkin = row[3].ToString(),
                        CheckOut = row[4].ToString(),
                        Status = (int)row[5],
                        totalPrice = long.Parse(row[6].ToString())

                });

                }

            }
            catch (Exception) { }
        }

        public void LoadgrdBill_Detail(string id)
        {
            try
            {
                string query = $"SELECT bi.id,b.id as Idbill,f.name, bi.Count, bi.totalPrice FROM Bill_Detail AS bi, Bill AS b, Product AS f WHERE bi.idBill = b.id AND bi.IDProduct = f.ID AND b.ID = {id}";
                DataTable tblBill_Detail = DBConnection.Instance.ExecuteQuery(query);
                //string sql = "tblBill_Detail N'" + str + "'";
                /*string sql = "select bd.ID,b.ID as 'IDBILL', sr.Numberofseat,st.Price from Bill_Detail bd, Bill b, Seats_Reserved sr,ShowTime st where bd.IDBill = b.ID and sr.ID = bd.IDSeats_Reserved  and st.ID = b.IDShowtime and b.ID =" + str;
                DataTable tblBill_Detail = new DataTable();
                tblBill_Detail = bill.DisplayBill(sql);*/
                grdBill_Detail.DataSource = tblBill_Detail;
                grdBill_Detail.AllowUserToAddRows = false;
            }catch(Exception) { }
        }
        private void BillControl_Load(object sender, EventArgs e)
        {
            LoadgrdBill();
            
        }

        private void grdBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String str = grdBill.CurrentRow.Cells[0].Value.ToString();
            LoadgrdBill_Detail(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Temp> tempSecond = new List<Temp>();
                foreach (Temp item in temps)
                {
                    DateTime billDate = DateTime.Parse(item.Checkin);
                    DateTime startDate = dateTimePicker1.Value;
                    DateTime endDate = dateTimePicker1.Value;


                    if (billDate.ToFileTimeUtc() >= startDate.ToFileTimeUtc() && billDate.ToFileTimeUtc() <= endDate.ToFileTimeUtc())
                    {
                        tempSecond.Add(item);
                    }
                }
                grdBill.DataSource = null;
                grdBill_Detail.DataSource = null;
                grdBill.DataSource = tempSecond;
            }
            catch (Exception ) { }
        }

        private void grdBill_Detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
