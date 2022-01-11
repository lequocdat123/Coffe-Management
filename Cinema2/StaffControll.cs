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
using CoffeShopManagerment.DTO;

namespace CoffeShopManagerment
{
    public partial class StaffControll : UserControl
    {
        Employee emp = new Employee();
        public StaffControll()
        {
            InitializeComponent();
            grdEmployee.BorderStyle = BorderStyle.None;
            grdEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdEmployee.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grdEmployee.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdEmployee.BackgroundColor = Color.White;

            grdEmployee.EnableHeadersVisualStyles = false;
            grdEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void LoadgrdEmployee()
        {
            string sql = "Select * from Employee";
            DataTable tblEmployee = new DataTable();
            tblEmployee =DBConnection.Instance.ExecuteQuery(sql);
            grdEmployee.DataSource = tblEmployee;
            grdEmployee.AllowUserToAddRows = false;
        }
        private void btnInsert_Employee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Employee_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Employee_Click(object sender, EventArgs e)
        {
            
        }

        private void StaffControll_Load(object sender, EventArgs e)
        {
            LoadgrdEmployee();
        }

        private void grdEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDEmployee.Text = grdEmployee.CurrentRow.Cells[0].Value.ToString();
            txt_NameEmployee.Text = grdEmployee.CurrentRow.Cells[1].Value.ToString();
            txt_Dateofbirth.Text = grdEmployee.CurrentRow.Cells[2].Value.ToString();
            txt_Username.Text = grdEmployee.CurrentRow.Cells[3].Value.ToString();
            txt_Password.Text = grdEmployee.CurrentRow.Cells[4].Value.ToString();
            string date = txt_Dateofbirth.Text;
           /* int dd = int.Parse(date[0].ToString() + date[1].ToString());
            int mm = int.Parse(date[3].ToString() + date[4].ToString());
            int yyyy = int.Parse(date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString());*/
            DateTime d = DateTime.Parse(date);
            dateTimePicker1.Value = d;
        }

        private void dateTimePicker1_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt_Dateofbirth.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_Dateofbirth.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void btnInsert_Employee_Click_1(object sender, EventArgs e)
        {
            txt_Dateofbirth.Text = dateTimePicker1.Value.ToShortDateString();
            if ( txt_NameEmployee.Text != "" && txt_Dateofbirth.Text != "" && txt_Username.Text != "" && txt_Password.Text != "")
            {
                if (Employee_DAO.Instance.InsertEmployee(txt_NameEmployee.Text, txt_Dateofbirth.Text, txt_Username.Text, txt_Password.Text))
                {
                    MessageBox.Show("Add Success!");
                    LoadgrdEmployee();
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

        private void btnEdit_Employee_Click_1(object sender, EventArgs e)
        {
            int check;
            check = 0;
            check = Convert.ToInt16(MessageBox.Show("Are you sure you want to edit this row?", "EDIT employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (check == 1)
            {
                if (txt_IDEmployee.Text != "")
                {
                    if (txt_NameEmployee.Text != "" && txt_Dateofbirth.Text != "" && txt_Username.Text != "" && txt_Password.Text != "")
                    {
                        if (Employee_DAO.Instance.EditEmployee(int.Parse(txt_IDEmployee.Text), txt_NameEmployee.Text, txt_Dateofbirth.Text, txt_Username.Text, txt_Password.Text))
                        {
                            MessageBox.Show("Update success");
                            LoadgrdEmployee();
                        }
                        else
                            MessageBox.Show("Update fail");
                    }
                    else
                        MessageBox.Show("Dung de trong ban oi!");
                }
                else
                {
                    MessageBox.Show("Please select one employee to update");
                }
            }
        }

        private void btnDelete_Employee_Click_1(object sender, EventArgs e)
        {
            int check;
            check = 0;
            check = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting Show time", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (check == 1)
            {
                if (txt_IDEmployee.Text != "")
                {
                    if (Employee_DAO.Instance.DeleteEmployee(txt_IDEmployee.Text))
                    {
                        MessageBox.Show("Deleting success");
                        LoadgrdEmployee();
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
    }
}
