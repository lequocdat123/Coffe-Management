namespace CoffeShopManagerment
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnShowtime = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userControl11 = new CoffeShopManagerment.ReportControl();
            this.showTime1 = new CoffeShopManagerment.TableControl();
            this.controllMovie1 = new CoffeShopManagerment.ControllMovie();
            this.staffControll1 = new CoffeShopManagerment.StaffControll();
            this.billControl1 = new CoffeShopManagerment.BillControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 723);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(0, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 95);
            this.panel5.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.Logo_Coffee;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 164);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnMovie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnShowtime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStaff, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBill, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 173);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMovie
            // 
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.Image = global::CoffeShopManagerment.Properties.Resources.productcf;
            this.btnMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.Location = new System.Drawing.Point(3, 97);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Padding = new System.Windows.Forms.Padding(20);
            this.btnMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMovie.Size = new System.Drawing.Size(259, 88);
            this.btnMovie.TabIndex = 1;
            this.btnMovie.Text = "Product";
            this.btnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnShowtime
            // 
            this.btnShowtime.FlatAppearance.BorderSize = 0;
            this.btnShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowtime.ForeColor = System.Drawing.Color.White;
            this.btnShowtime.Image = global::CoffeShopManagerment.Properties.Resources.table2;
            this.btnShowtime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowtime.Location = new System.Drawing.Point(3, 191);
            this.btnShowtime.Name = "btnShowtime";
            this.btnShowtime.Padding = new System.Windows.Forms.Padding(20);
            this.btnShowtime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowtime.Size = new System.Drawing.Size(259, 88);
            this.btnShowtime.TabIndex = 2;
            this.btnShowtime.Text = "Table";
            this.btnShowtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowtime.UseVisualStyleBackColor = true;
            this.btnShowtime.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::CoffeShopManagerment.Properties.Resources.toppng_com_free_twitter_white_icon_employee_icon_white_537x501__1_;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(3, 285);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(20);
            this.btnStaff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStaff.Size = new System.Drawing.Size(259, 88);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::CoffeShopManagerment.Properties.Resources.pngfuel_com;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(3, 379);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(20);
            this.btnBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBill.Size = new System.Drawing.Size(259, 88);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::CoffeShopManagerment.Properties.Resources.white_home_icon_1424511;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(259, 88);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.userControl11);
            this.panel3.Controls.Add(this.showTime1);
            this.panel3.Controls.Add(this.controllMovie1);
            this.panel3.Controls.Add(this.staffControll1);
            this.panel3.Controls.Add(this.billControl1);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(287, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 723);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(882, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 44);
            this.button6.TabIndex = 2;
            this.button6.Text = "X";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 47);
            this.panel4.TabIndex = 7;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(3, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(940, 745);
            this.userControl11.TabIndex = 0;
            // 
            // showTime1
            // 
            this.showTime1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.showTime1.Location = new System.Drawing.Point(0, 0);
            this.showTime1.Name = "showTime1";
            this.showTime1.Size = new System.Drawing.Size(940, 723);
            this.showTime1.TabIndex = 4;
            // 
            // controllMovie1
            // 
            this.controllMovie1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.controllMovie1.Location = new System.Drawing.Point(0, 0);
            this.controllMovie1.Name = "controllMovie1";
            this.controllMovie1.Size = new System.Drawing.Size(940, 723);
            this.controllMovie1.TabIndex = 3;
            // 
            // staffControll1
            // 
            this.staffControll1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.staffControll1.Location = new System.Drawing.Point(3, 0);
            this.staffControll1.Name = "staffControll1";
            this.staffControll1.Size = new System.Drawing.Size(940, 723);
            this.staffControll1.TabIndex = 6;
            // 
            // billControl1
            // 
            this.billControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.billControl1.Location = new System.Drawing.Point(0, 0);
            this.billControl1.Name = "billControl1";
            this.billControl1.Size = new System.Drawing.Size(940, 723);
            this.billControl1.TabIndex = 5;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1226, 724);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnShowtime;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ReportControl userControl11;
        private System.Windows.Forms.Button button6;
        private ControllMovie controllMovie1;
        private TableControl showTime1;
        private BillControl billControl1;
        private StaffControll staffControll1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}