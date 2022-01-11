using CoffeShopManagerment.DAO;
using CoffeShopManagerment.DTO;
using CoffeShopManagerment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagerment
{
    public partial class Login : Form
    {


        List<Employee> lstemp = Employee_DAO.Instance.GetEmployees();
        public Login()
        {
            
            InitializeComponent();
            ButtonSetup.Instance.AllButtonsTransparent(this.Controls);
            
        }

        public bool LoginSuccess = false;
        public Employee empLogin;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            foreach (var i in lstemp)// duyệt qua danh sách nhân viên
            {

                if (i.checkLogin(textBox1.Text, textBox2.Text)) // kiểm tra có nhập đúng account k
                {
                    LoginSuccess = true;
                    empLogin = i;
                    MessageBox.Show("Login Success");
                    Form2 maingui = new Form2(empLogin);
                    this.Hide();
                    maingui.ShowDialog();
                    this.Dispose();
                }
            }
            if (!LoginSuccess)
                MessageBox.Show("Login Fail");

            textBox2.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
/*            panel3.BackColor = Color.White;
            panel2.BackColor = Color.White;*/
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            /*textBox1.ForeColor = Color.Black;*/
            /*panel2.BackColor = Color.Black;
            panel3.BackColor = Color.White;*/
            /*textBox2.ForeColor = Color.White;*/
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
            /*textBox2.ForeColor = Color.Black;
            *//*panel3.BackColor = Color.Black;
            panel2.BackColor = Color.White;*//*
            textBox1.ForeColor = Color.White;*/
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            /*btnLogin.BackColor = Color.DimGray;*/
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            /*btnLogin.BackColor = Color.FromArgb(153, 153, 153);*/
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }

    }
}
