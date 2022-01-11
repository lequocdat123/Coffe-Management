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
    public partial class ControllMovie : UserControl
    {
        public ControllMovie()
        {
            InitializeComponent();
            grdMovie.BorderStyle = BorderStyle.None;
            grdMovie.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdMovie.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdMovie.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grdMovie.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdMovie.BackgroundColor = Color.White;

            grdMovie.EnableHeadersVisualStyles = false;
            grdMovie.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdMovie.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        public void LoadgrdMovie( )
        {
            string sql = "Select * from Product";
            DataTable tblProduct = new DataTable();
            tblProduct = DBConnection.Instance.ExecuteQuery(sql);
            grdMovie.DataSource = tblProduct;
            grdMovie.AllowUserToAddRows = false;

        }
        private void grdMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDProduct.Text = grdMovie.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = grdMovie.CurrentRow.Cells[1].Value.ToString();
                txtType.Text = grdMovie.CurrentRow.Cells[2].Value.ToString();
                txtImage.Text = grdMovie.CurrentRow.Cells[4].Value.ToString();
                txtPriceProduct.Text = grdMovie.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ){ }
           
        }

        private void btnInsert_Moive_Click(object sender, EventArgs e)
        {
            if (txtNameProduct.Text != "" && txtType.Text != "" && txtImage.Text != "" && txtPriceProduct.Text != "")
            {
                
                if (Product_DAO.Instance.InsertProduct(txtNameProduct.Text, txtType.Text, long.Parse(txtPriceProduct.Text), txtImage.Text))
                {
                    MessageBox.Show("Add Success!");
                    LoadgrdMovie();
                }
                else
                {
                    MessageBox.Show("Add Error!");
                }

            }
            else
            {
                MessageBox.Show("Please Input Full Infomation ");
            }
        }

        private void btnEdit_Movie_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có chắc muốn cập nhật lại sản phẩm này?", "EDIT employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                if (txtIDProduct.Text != "")
                {
                    if (txtIDProduct.Text != "" && txtNameProduct.Text != "" && txtType.Text != "" && txtImage.Text != "" && txtPriceProduct.Text != "")
                    {
                        if (Product_DAO.Instance.UpdateProduct(int.Parse(txtIDProduct.Text), txtNameProduct.Text, txtType.Text, long.Parse(txtPriceProduct.Text), txtImage.Text))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            LoadgrdMovie();
                        }
                        else
                            MessageBox.Show("Cập nhật thất bại");
                    }
                    else
                        MessageBox.Show("Dung de trong ban oi!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm");
                }
            }
        }

        private void btnDelete_Movie_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có chắc muốn xoá sản phẩm này", "Xoá sản phẩm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {
                if (txtIDProduct.Text != "")
                {
                    if (Product_DAO.Instance.DeleteProduct(int.Parse(txtIDProduct.Text)))
                    {
                        MessageBox.Show("Deleting success");
                        LoadgrdMovie();
                    }
                    else
                        MessageBox.Show("Deleting fail");
                }
                else
                {
                    MessageBox.Show("Please select one employee to delete");
                }
            }
        }

        private void ControllMovie_Load(object sender, EventArgs e)
        {
            LoadgrdMovie();
        }

        private void dateTimePicker1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
