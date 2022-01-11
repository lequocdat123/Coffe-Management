using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagerment
{
    public partial class Manage : Form
    {
        
        public Manage()
        {
            InitializeComponent();

        }
        public void LoadgrdMovie()
        {
        }
        
        private void lblHours_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Movie_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Movie_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Movie_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadgrdMovie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            button6.BringToFront();
            panel5.Location = new Point(3,173);
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            //userControl11.Visible = true;
            controllMovie1.BringToFront();
            button6.BringToFront();
            panel5.Location = new Point(0, 267);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showTime1.BringToFront();
            button6.BringToFront();
            panel5.Location = new Point(0, 364);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            staffControll1.BringToFront();
            button6.BringToFront();
            panel5.Location = new Point(0, 455);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            billControl1.BringToFront();
            button6.BringToFront();
            panel5.Location = new Point(0, 552);
        }
    }
}
