namespace BTL
{
    partial class chitiethoadonnhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitiethoadonnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bcapnhat = new System.Windows.Forms.Button();
            this.bthem = new System.Windows.Forms.Button();
            this.bxoa = new System.Windows.Forms.Button();
            this.blammoi = new System.Windows.Forms.Button();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.dMhanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGOMSUDataSet = new BTL.QUANLYGOMSUDataSet();
            this.chitietHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitietHDNTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.ChitietHDNTableAdapter();
            this.qUANLYGOMSUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMhanghoaTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.DMhanghoaTableAdapter();
            this.lthanhtien = new System.Windows.Forms.Label();
            this.bthoat = new System.Windows.Forms.Button();
            this.tshdn = new System.Windows.Forms.ComboBox();
            this.hoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitietHDNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonnhapTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.HoadonnhapTableAdapter();
            this.bxong = new System.Windows.Forms.Button();
            this.btimkiem = new System.Windows.Forms.Button();
            this.btim = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tdongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMhanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietHDNBindingSource1)).BeginInit();
            this.GB.SuspendLayout();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN NHẬP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số HĐN:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã hàng:";
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(25, 225);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(849, 122);
            this.dgv1.TabIndex = 15;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCTHĐN_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCTHĐN_CellContentClick);
            // 
            // bcapnhat
            // 
            this.bcapnhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bcapnhat.Image = ((System.Drawing.Image)(resources.GetObject("bcapnhat.Image")));
            this.bcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcapnhat.Location = new System.Drawing.Point(25, 372);
            this.bcapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.bcapnhat.Name = "bcapnhat";
            this.bcapnhat.Size = new System.Drawing.Size(121, 26);
            this.bcapnhat.TabIndex = 16;
            this.bcapnhat.Text = "Sửa thông tin";
            this.bcapnhat.UseVisualStyleBackColor = true;
            this.bcapnhat.Click += new System.EventHandler(this.ButtonCAPNHAT_Click);
            // 
            // bthem
            // 
            this.bthem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthem.Image = ((System.Drawing.Image)(resources.GetObject("bthem.Image")));
            this.bthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthem.Location = new System.Drawing.Point(171, 373);
            this.bthem.Name = "bthem";
            this.bthem.Size = new System.Drawing.Size(121, 26);
            this.bthem.TabIndex = 18;
            this.bthem.Text = "Thêm mới";
            this.bthem.UseVisualStyleBackColor = true;
            this.bthem.Click += new System.EventHandler(this.Bthem_Click);
            // 
            // bxoa
            // 
            this.bxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxoa.Image = ((System.Drawing.Image)(resources.GetObject("bxoa.Image")));
            this.bxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxoa.Location = new System.Drawing.Point(323, 373);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(121, 26);
            this.bxoa.TabIndex = 19;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.Bxoa_Click);
            // 
            // blammoi
            // 
            this.blammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blammoi.Image = ((System.Drawing.Image)(resources.GetObject("blammoi.Image")));
            this.blammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blammoi.Location = new System.Drawing.Point(470, 373);
            this.blammoi.Name = "blammoi";
            this.blammoi.Size = new System.Drawing.Size(121, 26);
            this.blammoi.TabIndex = 27;
            this.blammoi.Text = "Làm mới";
            this.blammoi.UseVisualStyleBackColor = true;
            this.blammoi.Click += new System.EventHandler(this.Blammoi_Click);
            // 
            // cbmahang
            // 
            this.cbmahang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmahang.DataSource = this.dMhanghoaBindingSource;
            this.cbmahang.DisplayMember = "Mahang";
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(71, 62);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(176, 21);
            this.cbmahang.TabIndex = 29;
            this.cbmahang.ValueMember = "Mahang";
            this.cbmahang.SelectedIndexChanged += new System.EventHandler(this.Cbmahang_SelectedIndexChanged_1);
            // 
            // dMhanghoaBindingSource
            // 
            this.dMhanghoaBindingSource.DataMember = "DMhanghoa";
            this.dMhanghoaBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            // 
            // qUANLYGOMSUDataSet
            // 
            this.qUANLYGOMSUDataSet.DataSetName = "QUANLYGOMSUDataSet";
            this.qUANLYGOMSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitietHDNBindingSource
            // 
            this.chitietHDNBindingSource.DataMember = "ChitietHDN";
            this.chitietHDNBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            // 
            // chitietHDNTableAdapter
            // 
            this.chitietHDNTableAdapter.ClearBeforeFill = true;
            // 
            // qUANLYGOMSUDataSetBindingSource
            // 
            this.qUANLYGOMSUDataSetBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            this.qUANLYGOMSUDataSetBindingSource.Position = 0;
            // 
            // dMhanghoaTableAdapter
            // 
            this.dMhanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // lthanhtien
            // 
            this.lthanhtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lthanhtien.AutoSize = true;
            this.lthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lthanhtien.ForeColor = System.Drawing.Color.Lime;
            this.lthanhtien.Location = new System.Drawing.Point(64, 16);
            this.lthanhtien.Name = "lthanhtien";
            this.lthanhtien.Size = new System.Drawing.Size(26, 29);
            this.lthanhtien.TabIndex = 30;
            this.lthanhtien.Text = "0";
            this.lthanhtien.Click += new System.EventHandler(this.Lthanhtien_Click);
            // 
            // bthoat
            // 
            this.bthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthoat.Image = ((System.Drawing.Image)(resources.GetObject("bthoat.Image")));
            this.bthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthoat.Location = new System.Drawing.Point(753, 373);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(121, 26);
            this.bthoat.TabIndex = 31;
            this.bthoat.Text = "Thoát";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.Bthoat_Click);
            // 
            // tshdn
            // 
            this.tshdn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tshdn.DataSource = this.hoadonnhapBindingSource;
            this.tshdn.DisplayMember = "SoHDN";
            this.tshdn.FormattingEnabled = true;
            this.tshdn.Location = new System.Drawing.Point(71, 26);
            this.tshdn.Name = "tshdn";
            this.tshdn.Size = new System.Drawing.Size(176, 21);
            this.tshdn.TabIndex = 0;
            this.tshdn.ValueMember = "SoHDN";
            this.tshdn.SelectedIndexChanged += new System.EventHandler(this.Tshdn_SelectedIndexChanged);
            // 
            // hoadonnhapBindingSource
            // 
            this.hoadonnhapBindingSource.DataMember = "Hoadonnhap";
            this.hoadonnhapBindingSource.DataSource = this.qUANLYGOMSUDataSetBindingSource;
            // 
            // chitietHDNBindingSource1
            // 
            this.chitietHDNBindingSource1.DataMember = "ChitietHDN";
            this.chitietHDNBindingSource1.DataSource = this.qUANLYGOMSUDataSetBindingSource;
            // 
            // hoadonnhapTableAdapter
            // 
            this.hoadonnhapTableAdapter.ClearBeforeFill = true;
            // 
            // bxong
            // 
            this.bxong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxong.BackColor = System.Drawing.Color.Red;
            this.bxong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bxong.Image = ((System.Drawing.Image)(resources.GetObject("bxong.Image")));
            this.bxong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxong.Location = new System.Drawing.Point(26, 373);
            this.bxong.Name = "bxong";
            this.bxong.Size = new System.Drawing.Size(120, 25);
            this.bxong.TabIndex = 52;
            this.bxong.Text = "Xong";
            this.bxong.UseVisualStyleBackColor = false;
            this.bxong.Click += new System.EventHandler(this.Bxong_Click);
            // 
            // btimkiem
            // 
            this.btimkiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btimkiem.Image")));
            this.btimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btimkiem.Location = new System.Drawing.Point(608, 373);
            this.btimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btimkiem.Name = "btimkiem";
            this.btimkiem.Size = new System.Drawing.Size(121, 26);
            this.btimkiem.TabIndex = 53;
            this.btimkiem.Text = "Tìm kiếm";
            this.btimkiem.UseVisualStyleBackColor = true;
            this.btimkiem.Click += new System.EventHandler(this.Btimkiem_Click);
            // 
            // btim
            // 
            this.btim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btim.Image = ((System.Drawing.Image)(resources.GetObject("btim.Image")));
            this.btim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btim.Location = new System.Drawing.Point(608, 373);
            this.btim.Name = "btim";
            this.btim.Size = new System.Drawing.Size(122, 26);
            this.btim.TabIndex = 54;
            this.btim.Text = "Tìm";
            this.btim.UseVisualStyleBackColor = false;
            this.btim.Click += new System.EventHandler(this.Btim_Click);
            // 
            // GB
            // 
            this.GB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GB.Controls.Add(this.label2);
            this.GB.Controls.Add(this.label8);
            this.GB.Controls.Add(this.cbmahang);
            this.GB.Controls.Add(this.tshdn);
            this.GB.Location = new System.Drawing.Point(102, 47);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(270, 100);
            this.GB.TabIndex = 55;
            this.GB.TabStop = false;
            this.GB.Text = "Hóa Đơn";
            // 
            // gb1
            // 
            this.gb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb1.Controls.Add(this.comboBox1);
            this.gb1.Controls.Add(this.tdongia);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.tsoluong);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Location = new System.Drawing.Point(528, 47);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(270, 131);
            this.gb1.TabIndex = 56;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thống kê";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // tdongia
            // 
            this.tdongia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tdongia.Location = new System.Drawing.Point(80, 28);
            this.tdongia.Margin = new System.Windows.Forms.Padding(2);
            this.tdongia.Multiline = true;
            this.tdongia.Name = "tdongia";
            this.tdongia.Size = new System.Drawing.Size(176, 20);
            this.tdongia.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Giảm giá:";
            // 
            // tsoluong
            // 
            this.tsoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsoluong.Location = new System.Drawing.Point(80, 64);
            this.tsoluong.Margin = new System.Windows.Forms.Padding(2);
            this.tsoluong.Multiline = true;
            this.tsoluong.Name = "tsoluong";
            this.tsoluong.Size = new System.Drawing.Size(176, 20);
            this.tsoluong.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Số lượng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lthanhtien);
            this.groupBox1.Location = new System.Drawing.Point(102, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 56);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thành Tiền";
            // 
            // chitiethoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(897, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.btim);
            this.Controls.Add(this.btimkiem);
            this.Controls.Add(this.bxong);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.blammoi);
            this.Controls.Add(this.bxoa);
            this.Controls.Add(this.bthem);
            this.Controls.Add(this.bcapnhat);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "chitiethoadonnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chitiethoadonnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMhanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietHDNBindingSource1)).EndInit();
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button bcapnhat;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.Button blammoi;
        private System.Windows.Forms.ComboBox cbmahang;
        private QUANLYGOMSUDataSet qUANLYGOMSUDataSet;
        private System.Windows.Forms.BindingSource chitietHDNBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.ChitietHDNTableAdapter chitietHDNTableAdapter;
        private System.Windows.Forms.BindingSource qUANLYGOMSUDataSetBindingSource;
        private System.Windows.Forms.BindingSource dMhanghoaBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.DMhanghoaTableAdapter dMhanghoaTableAdapter;
        private System.Windows.Forms.Label lthanhtien;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.ComboBox tshdn;
        private System.Windows.Forms.BindingSource chitietHDNBindingSource1;
        private System.Windows.Forms.BindingSource hoadonnhapBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.HoadonnhapTableAdapter hoadonnhapTableAdapter;
        private System.Windows.Forms.Button bxong;
        private System.Windows.Forms.Button btimkiem;
        private System.Windows.Forms.Button btim;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tdongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}