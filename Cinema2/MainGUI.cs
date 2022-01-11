using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeShopManagerment.Utils;
using CoffeShopManagerment.DTO;

namespace CoffeShopManagerment
{   

    public partial class Form2 : Form
    {
        Employee emp = new Employee();
        public Form2()
        {
            InitializeComponent();
             ButtonSetup.Instance.AllButtonsTransparent(this.Controls);
        }
        public Form2(Employee emp)
        {
            this.emp = emp;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           /* if (login.LoginSuccess)
            {*/
                //Logout.Visible = true;
                this.Hide();
                Booking f = new Booking(emp);
                f.ShowDialog();
                this.Show();
            //}
/*            else
            {
                login.ShowDialog();
                if (login.LoginSuccess)
                {
                    Logout.Visible = true;
                    this.Hide();
                    Booking f = new Booking(login.empLogin);
                    f.ShowDialog();
                    this.Show();
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
           /* this.Hide();
            login.ShowDialog();
            this.Show();*/
/*            if (login.LoginSuccess)
            {*/
                //Logout.Visible = true;
                this.Hide();
                Manage f = new Manage();
                f.ShowDialog();
                this.Show();
/*            }
            else
            {
                login.ShowDialog();
                if (login.LoginSuccess)
                {
                    Logout.Visible = true;
                    this.Hide();
                    Manage f = new Manage();
                    f.ShowDialog();
                    this.Show();
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            /*            this.Hide();
                        Form2 f = new Form2();
                        f.ShowDialog();
                        this.Dispose();*/
            this.Hide();
            new Login().ShowDialog();
            this.Dispose();
        }
    }
}
