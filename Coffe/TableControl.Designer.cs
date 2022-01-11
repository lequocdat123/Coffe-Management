namespace CoffeShopManagerment
{
    partial class TableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdShowTime = new System.Windows.Forms.DataGridView();
            this.clIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.lblNameMovie_Showtime = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtIDTable = new System.Windows.Forms.TextBox();
            this.lblIDShowTime = new System.Windows.Forms.Label();
            this.btnEditShowtime = new System.Windows.Forms.Button();
            this.btnInsertShowTime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdShowTime
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShowTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShowTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDTable,
            this.clStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdShowTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdShowTime.Location = new System.Drawing.Point(13, 77);
            this.grdShowTime.Name = "grdShowTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdShowTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdShowTime.RowHeadersVisible = false;
            this.grdShowTime.RowTemplate.Height = 25;
            this.grdShowTime.Size = new System.Drawing.Size(547, 640);
            this.grdShowTime.TabIndex = 3;
            this.grdShowTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShowTime_CellClick);
            // 
            // clIDTable
            // 
            this.clIDTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clIDTable.DataPropertyName = "ID";
            this.clIDTable.HeaderText = "Số Bàn";
            this.clIDTable.Name = "clIDTable";
            this.clIDTable.ReadOnly = true;
            this.clIDTable.Width = 270;
            // 
            // clStatus
            // 
            this.clStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clStatus.DataPropertyName = "Status";
            this.clStatus.HeaderText = "Status";
            this.clStatus.Name = "clStatus";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.employees;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 40);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbbStatus);
            this.panel10.Controls.Add(this.lblNameMovie_Showtime);
            this.panel10.Location = new System.Drawing.Point(25, 109);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(315, 66);
            this.panel10.TabIndex = 12;
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cbbStatus.Location = new System.Drawing.Point(121, 20);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(189, 32);
            this.cbbStatus.TabIndex = 19;
            // 
            // lblNameMovie_Showtime
            // 
            this.lblNameMovie_Showtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMovie_Showtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblNameMovie_Showtime.Location = new System.Drawing.Point(34, 20);
            this.lblNameMovie_Showtime.Name = "lblNameMovie_Showtime";
            this.lblNameMovie_Showtime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameMovie_Showtime.Size = new System.Drawing.Size(80, 35);
            this.lblNameMovie_Showtime.TabIndex = 0;
            this.lblNameMovie_Showtime.Text = "Seats";
            this.lblNameMovie_Showtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtIDTable);
            this.panel13.Controls.Add(this.lblIDShowTime);
            this.panel13.Location = new System.Drawing.Point(25, 15);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(315, 66);
            this.panel13.TabIndex = 7;
            // 
            // txtIDTable
            // 
            this.txtIDTable.Enabled = false;
            this.txtIDTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTable.Location = new System.Drawing.Point(121, 22);
            this.txtIDTable.Multiline = true;
            this.txtIDTable.Name = "txtIDTable";
            this.txtIDTable.ReadOnly = true;
            this.txtIDTable.Size = new System.Drawing.Size(189, 35);
            this.txtIDTable.TabIndex = 1;
            this.txtIDTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDShowTime
            // 
            this.lblIDShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblIDShowTime.Location = new System.Drawing.Point(29, 22);
            this.lblIDShowTime.Name = "lblIDShowTime";
            this.lblIDShowTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIDShowTime.Size = new System.Drawing.Size(85, 35);
            this.lblIDShowTime.TabIndex = 0;
            this.lblIDShowTime.Text = "ID";
            this.lblIDShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditShowtime
            // 
            this.btnEditShowtime.BackColor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.Update1;
            this.btnEditShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditShowtime.FlatAppearance.BorderSize = 0;
            this.btnEditShowtime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShowtime.Location = new System.Drawing.Point(137, 220);
            this.btnEditShowtime.Name = "btnEditShowtime";
            this.btnEditShowtime.Size = new System.Drawing.Size(100, 68);
            this.btnEditShowtime.TabIndex = 13;
            this.btnEditShowtime.UseVisualStyleBackColor = false;
            this.btnEditShowtime.Click += new System.EventHandler(this.btnEditShowtime_Click_1);
            // 
            // btnInsertShowTime
            // 
            this.btnInsertShowTime.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertShowTime.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.plus;
            this.btnInsertShowTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertShowTime.FlatAppearance.BorderSize = 0;
            this.btnInsertShowTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInsertShowTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInsertShowTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInsertShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertShowTime.Location = new System.Drawing.Point(16, 220);
            this.btnInsertShowTime.Name = "btnInsertShowTime";
            this.btnInsertShowTime.Size = new System.Drawing.Size(100, 68);
            this.btnInsertShowTime.TabIndex = 18;
            this.btnInsertShowTime.UseVisualStyleBackColor = false;
            this.btnInsertShowTime.Click += new System.EventHandler(this.btnInsertShowTime_Click_1);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.Delete_Button;
            this.btnDeleteShowtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteShowtime.FlatAppearance.BorderSize = 0;
            this.btnDeleteShowtime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(252, 220);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(100, 68);
            this.btnDeleteShowtime.TabIndex = 17;
            this.btnDeleteShowtime.UseVisualStyleBackColor = false;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDeleteShowtime);
            this.panel1.Controls.Add(this.btnInsertShowTime);
            this.panel1.Controls.Add(this.btnEditShowtime);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Location = new System.Drawing.Point(575, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 643);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(256, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(149, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(39, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add";
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdShowTime);
            this.Name = "TableControl";
            this.Size = new System.Drawing.Size(940, 723);
            this.Load += new System.EventHandler(this.ShowTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShowTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdShowTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblNameMovie_Showtime;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtIDTable;
        private System.Windows.Forms.Label lblIDShowTime;
        private System.Windows.Forms.Button btnEditShowtime;
        private System.Windows.Forms.Button btnInsertShowTime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
