namespace CoffeShopManagerment
{
    partial class ControllMovie
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
            this.grdMovie = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert_Product = new System.Windows.Forms.Button();
            this.btnDelete_Product = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnEdit_Product = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.lblIDMovie = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblTypeMovie = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblNameMovie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMovie
            // 
            this.grdMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clName,
            this.clType,
            this.clPrice,
            this.clImage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMovie.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdMovie.EnableHeadersVisualStyles = false;
            this.grdMovie.Location = new System.Drawing.Point(13, 77);
            this.grdMovie.MultiSelect = false;
            this.grdMovie.Name = "grdMovie";
            this.grdMovie.ReadOnly = true;
            this.grdMovie.RowHeadersVisible = false;
            this.grdMovie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMovie.RowTemplate.Height = 25;
            this.grdMovie.RowTemplate.ReadOnly = true;
            this.grdMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMovie.Size = new System.Drawing.Size(909, 308);
            this.grdMovie.TabIndex = 1;
            this.grdMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovie_CellClick);
            this.grdMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovie_CellContentClick);
            // 
            // clID
            // 
            this.clID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clID.Width = 51;
            // 
            // clName
            // 
            this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Name";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clType
            // 
            this.clType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clType.DataPropertyName = "Type";
            this.clType.HeaderText = "Type";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            this.clType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clType.Width = 69;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Price";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clPrice.Width = 68;
            // 
            // clImage
            // 
            this.clImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clImage.DataPropertyName = "Image";
            this.clImage.HeaderText = "Image";
            this.clImage.Name = "clImage";
            this.clImage.ReadOnly = true;
            this.clImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clImage.Width = 79;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.Rectangle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnInsert_Product);
            this.panel1.Controls.Add(this.btnDelete_Product);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnEdit_Product);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(13, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 293);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(803, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(803, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(825, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add";
            // 
            // btnInsert_Product
            // 
            this.btnInsert_Product.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert_Product.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.plus;
            this.btnInsert_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert_Product.FlatAppearance.BorderSize = 0;
            this.btnInsert_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert_Product.ForeColor = System.Drawing.Color.Transparent;
            this.btnInsert_Product.Location = new System.Drawing.Point(821, 20);
            this.btnInsert_Product.Name = "btnInsert_Product";
            this.btnInsert_Product.Size = new System.Drawing.Size(50, 50);
            this.btnInsert_Product.TabIndex = 6;
            this.btnInsert_Product.UseVisualStyleBackColor = false;
            this.btnInsert_Product.Click += new System.EventHandler(this.btnInsert_Moive_Click);
            // 
            // btnDelete_Product
            // 
            this.btnDelete_Product.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete_Product.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.Delete_Button;
            this.btnDelete_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete_Product.FlatAppearance.BorderSize = 0;
            this.btnDelete_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Product.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete_Product.Location = new System.Drawing.Point(821, 205);
            this.btnDelete_Product.Name = "btnDelete_Product";
            this.btnDelete_Product.Size = new System.Drawing.Size(50, 50);
            this.btnDelete_Product.TabIndex = 5;
            this.btnDelete_Product.UseVisualStyleBackColor = false;
            this.btnDelete_Product.Click += new System.EventHandler(this.btnDelete_Movie_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPriceProduct);
            this.panel8.Controls.Add(this.lblHours);
            this.panel8.Location = new System.Drawing.Point(3, 180);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(326, 40);
            this.panel8.TabIndex = 6;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.BackColor = System.Drawing.Color.White;
            this.txtPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceProduct.ForeColor = System.Drawing.Color.Black;
            this.txtPriceProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPriceProduct.Location = new System.Drawing.Point(77, 3);
            this.txtPriceProduct.Multiline = true;
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(227, 35);
            this.txtPriceProduct.TabIndex = 1;
            this.txtPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblHours.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHours.Location = new System.Drawing.Point(6, 6);
            this.lblHours.Name = "lblHours";
            this.lblHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHours.Size = new System.Drawing.Size(68, 35);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Price";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEdit_Product
            // 
            this.btnEdit_Product.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit_Product.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.Update1;
            this.btnEdit_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit_Product.FlatAppearance.BorderSize = 0;
            this.btnEdit_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_Product.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit_Product.Location = new System.Drawing.Point(821, 114);
            this.btnEdit_Product.Name = "btnEdit_Product";
            this.btnEdit_Product.Size = new System.Drawing.Size(50, 50);
            this.btnEdit_Product.TabIndex = 4;
            this.btnEdit_Product.UseVisualStyleBackColor = false;
            this.btnEdit_Product.Click += new System.EventHandler(this.btnEdit_Movie_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtImage);
            this.panel7.Controls.Add(this.lblShowTime);
            this.panel7.Location = new System.Drawing.Point(392, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(326, 40);
            this.panel7.TabIndex = 3;
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.ForeColor = System.Drawing.Color.Black;
            this.txtImage.Location = new System.Drawing.Point(77, 0);
            this.txtImage.Multiline = true;
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(227, 35);
            this.txtImage.TabIndex = 1;
            this.txtImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblShowTime
            // 
            this.lblShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblShowTime.Location = new System.Drawing.Point(-13, 3);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShowTime.Size = new System.Drawing.Size(83, 35);
            this.lblShowTime.TabIndex = 0;
            this.lblShowTime.Text = "Image";
            this.lblShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtIDProduct);
            this.panel4.Controls.Add(this.lblIDMovie);
            this.panel4.Location = new System.Drawing.Point(3, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 40);
            this.panel4.TabIndex = 0;
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.BackColor = System.Drawing.Color.White;
            this.txtIDProduct.Enabled = false;
            this.txtIDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProduct.ForeColor = System.Drawing.Color.Black;
            this.txtIDProduct.Location = new System.Drawing.Point(74, 3);
            this.txtIDProduct.Multiline = true;
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.ReadOnly = true;
            this.txtIDProduct.Size = new System.Drawing.Size(227, 35);
            this.txtIDProduct.TabIndex = 1;
            this.txtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDMovie
            // 
            this.lblIDMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblIDMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIDMovie.Location = new System.Drawing.Point(3, 3);
            this.lblIDMovie.Name = "lblIDMovie";
            this.lblIDMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIDMovie.Size = new System.Drawing.Size(68, 35);
            this.lblIDMovie.TabIndex = 0;
            this.lblIDMovie.Text = "ID ";
            this.lblIDMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtType);
            this.panel6.Controls.Add(this.lblTypeMovie);
            this.panel6.Location = new System.Drawing.Point(392, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(326, 40);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(77, 3);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(227, 35);
            this.txtType.TabIndex = 1;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTypeMovie
            // 
            this.lblTypeMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblTypeMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTypeMovie.Location = new System.Drawing.Point(6, 3);
            this.lblTypeMovie.Name = "lblTypeMovie";
            this.lblTypeMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTypeMovie.Size = new System.Drawing.Size(68, 35);
            this.lblTypeMovie.TabIndex = 0;
            this.lblTypeMovie.Text = "Type";
            this.lblTypeMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtNameProduct);
            this.panel5.Controls.Add(this.lblNameMovie);
            this.panel5.Location = new System.Drawing.Point(3, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 40);
            this.panel5.TabIndex = 1;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.White;
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.ForeColor = System.Drawing.Color.Black;
            this.txtNameProduct.Location = new System.Drawing.Point(77, 3);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(227, 35);
            this.txtNameProduct.TabIndex = 1;
            this.txtNameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.lblNameMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameMovie.Location = new System.Drawing.Point(-2, 3);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameMovie.Size = new System.Drawing.Size(76, 35);
            this.lblNameMovie.TabIndex = 0;
            this.lblNameMovie.Text = "Name";
            this.lblNameMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CoffeShopManagerment.Properties.Resources.qlmon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ControllMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdMovie);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ControllMovie";
            this.Size = new System.Drawing.Size(940, 723);
            this.Load += new System.EventHandler(this.ControllMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert_Product;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnDelete_Product;
        private System.Windows.Forms.Button btnEdit_Product;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblTypeMovie;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblNameMovie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIDProduct;
        private System.Windows.Forms.Label lblIDMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImage;
    }
}
