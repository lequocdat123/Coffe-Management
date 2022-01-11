using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CoffeShopManagerment.DAO;

namespace CoffeShopManagerment
{
    public partial class TableControl : UserControl
    {
        private String[] str = new String[20];
        private int[] index = new int[20];
        //Không quan trọng
        
        public TableControl()
        {
            InitializeComponent();
           /* string sql = "Select * from Movie";
            DataTable tblShowTime = new DataTable();
            tblShowTime = st_Bus.Display(sql);
            int i = 0;
            foreach(DataRow item in tblShowTime.Rows)
            {
                str[i] = item["Name"].ToString();
                index[i] =(int)item["ID"];
                cbbMovie.Items.Add(str[i]);
                i++;
            }
            grdShowTime.BorderStyle = BorderStyle.None;
            grdShowTime.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdShowTime.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdShowTime.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grdShowTime.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdShowTime.BackgroundColor = Color.White;

            grdShowTime.EnableHeadersVisualStyles = false;
            grdShowTime.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdShowTime.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdShowTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Khi nhấn 1 dòng trong bảng sẽ lấy dữ liệu ra ô text
        private void grdShowTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDTable.Text = grdShowTime.CurrentRow.Cells[0].Value.ToString();
                cbbStatus.SelectedIndex = 1;

                if (grdShowTime.CurrentRow.Cells[1].Value.ToString() == "Trống")
                    cbbStatus.SelectedIndex = 0;
                
            }
            catch (Exception ) { }
        }

        private void btnInsertShowTime_Click(object sender, EventArgs e)
        {

        }

        private void btnEditShowtime_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {

        }
        //Load bảng dữ liệu
        class Temp
        {
            public int ID { get; set; }
            public string Status { get; set; }

        };
        public void LoadgrdShowTime()
        {
            string sql = "Select * from seat";
            DataTable tblShowTime = new DataTable();
            tblShowTime = DBConnection.Instance.ExecuteQuery(sql);
            DataTable table = new DataTable();
            List<Temp> temps = new List<Temp>();
            
            foreach (DataRow row in tblShowTime.Rows)
            {

                temps.Add(new Temp() { ID = (int)row[0],Status=(int)row[1] == 1?"Có người":"Trống" });

            }
            grdShowTime.DataSource = temps;

            grdShowTime.AllowUserToAddRows = false;
        }
        private void ShowTime_Load(object sender, EventArgs e)
        {
            LoadgrdShowTime();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void btnInsertShowTime_Click_1(object sender, EventArgs e)
        {
            int status = 1;
            if(cbbStatus.Text == "Trống")
            {
                status = 0;
            }
            /* int check = Table_DAO.Instance.InsertTable(int.Parse(txtIDTable.Text), status);*/
            int check = Table_DAO.Instance.InsertTable(status);
            if (check != -1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");

            }
            cbbStatus.SelectedIndex = -1;
            txtIDTable.Text = "";
            LoadgrdShowTime();
        }

        private void btnEditShowtime_Click_1(object sender, EventArgs e)
        {
            int status = 1;
            if (cbbStatus.Text == "Trống")
            {
                status = 0;
            }
            int check = Table_DAO.Instance.UpdateStatus(int.Parse(txtIDTable.Text), status);
            if (check != -1)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");

            }
            cbbStatus.SelectedIndex = -1;
            txtIDTable.Text = "";
            LoadgrdShowTime();
        }

        private void btnDeleteShowtime_Click_1(object sender, EventArgs e)
        {
            int check = Table_DAO.Instance.DeleteTable(int.Parse(txtIDTable.Text));
            if (check != -1)
            {
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");

            }
            cbbStatus.SelectedIndex = -1;
            txtIDTable.Text = "";
            LoadgrdShowTime();
        }
    }
}
