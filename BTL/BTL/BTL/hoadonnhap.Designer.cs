namespace BTL
{
    partial class hoadonnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadonnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bSua = new System.Windows.Forms.Button();
            this.bthem = new System.Windows.Forms.Button();
            this.blammoi = new System.Windows.Forms.Button();
            this.bthoat = new System.Windows.Forms.Button();
            this.ltongtien = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGOMSUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGOMSUDataSet = new BTL.QUANLYGOMSUDataSet();
            this.nhacungcapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMhanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMhanghoaTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.DMhanghoaTableAdapter();
            this.nhacungcapTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.NhacungcapTableAdapter();
            this.nhanVienTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.NhanVienTableAdapter();
            this.bxoa = new System.Windows.Forms.Button();
            this.bxong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.tsohdn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMhanghoaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN NHẬP";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(36, 251);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(843, 164);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHĐN_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // bSua
            // 
            this.bSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSua.Image = ((System.Drawing.Image)(resources.GetObject("bSua.Image")));
            this.bSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSua.Location = new System.Drawing.Point(106, 420);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(121, 25);
            this.bSua.TabIndex = 12;
            this.bSua.Text = "Sửa Thông Tin";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.BSua_Click);
            // 
            // bthem
            // 
            this.bthem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthem.Image = ((System.Drawing.Image)(resources.GetObject("bthem.Image")));
            this.bthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthem.Location = new System.Drawing.Point(423, 420);
            this.bthem.Name = "bthem";
            this.bthem.Size = new System.Drawing.Size(121, 25);
            this.bthem.TabIndex = 13;
            this.bthem.Text = "Thêm mới";
            this.bthem.UseVisualStyleBackColor = true;
            this.bthem.Click += new System.EventHandler(this.Bthem_Click);
            // 
            // blammoi
            // 
            this.blammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blammoi.Image = ((System.Drawing.Image)(resources.GetObject("blammoi.Image")));
            this.blammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blammoi.Location = new System.Drawing.Point(575, 420);
            this.blammoi.Name = "blammoi";
            this.blammoi.Size = new System.Drawing.Size(121, 25);
            this.blammoi.TabIndex = 14;
            this.blammoi.Text = "Làm mới";
            this.blammoi.UseVisualStyleBackColor = true;
            this.blammoi.Click += new System.EventHandler(this.Blammoi_Click);
            // 
            // bthoat
            // 
            this.bthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthoat.Image = ((System.Drawing.Image)(resources.GetObject("bthoat.Image")));
            this.bthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthoat.Location = new System.Drawing.Point(730, 420);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(121, 25);
            this.bthoat.TabIndex = 15;
            this.bthoat.Text = "Thoát";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.Bthoat_Click);
            // 
            // ltongtien
            // 
            this.ltongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ltongtien.AutoSize = true;
            this.ltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltongtien.ForeColor = System.Drawing.Color.Lime;
            this.ltongtien.Location = new System.Drawing.Point(91, 26);
            this.ltongtien.Name = "ltongtien";
            this.ltongtien.Size = new System.Drawing.Size(26, 29);
            this.ltongtien.TabIndex = 16;
            this.ltongtien.Text = "0";
            this.ltongtien.Click += new System.EventHandler(this.Label7_Click);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qUANLYGOMSUDataSetBindingSource;
            // 
            // qUANLYGOMSUDataSetBindingSource
            // 
            this.qUANLYGOMSUDataSetBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            this.qUANLYGOMSUDataSetBindingSource.Position = 0;
            // 
            // qUANLYGOMSUDataSet
            // 
            this.qUANLYGOMSUDataSet.DataSetName = "QUANLYGOMSUDataSet";
            this.qUANLYGOMSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhacungcapBindingSource
            // 
            this.nhacungcapBindingSource.DataMember = "Nhacungcap";
            this.nhacungcapBindingSource.DataSource = this.qUANLYGOMSUDataSetBindingSource;
            // 
            // dMhanghoaBindingSource
            // 
            this.dMhanghoaBindingSource.DataMember = "DMhanghoa";
            this.dMhanghoaBindingSource.DataSource = this.qUANLYGOMSUDataSetBindingSource;
            // 
            // dMhanghoaTableAdapter
            // 
            this.dMhanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // nhacungcapTableAdapter
            // 
            this.nhacungcapTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // bxoa
            // 
            this.bxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxoa.Image = ((System.Drawing.Image)(resources.GetObject("bxoa.Image")));
            this.bxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxoa.Location = new System.Drawing.Point(266, 420);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(121, 25);
            this.bxoa.TabIndex = 19;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.Bxoa_Click);
            // 
            // bxong
            // 
            this.bxong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxong.BackColor = System.Drawing.Color.Red;
            this.bxong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bxong.Image = ((System.Drawing.Image)(resources.GetObject("bxong.Image")));
            this.bxong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxong.Location = new System.Drawing.Point(107, 420);
            this.bxong.Name = "bxong";
            this.bxong.Size = new System.Drawing.Size(120, 25);
            this.bxong.TabIndex = 55;
            this.bxong.Text = "Xong";
            this.bxong.UseVisualStyleBackColor = false;
            this.bxong.Click += new System.EventHandler(this.Bxong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.tsohdn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 127);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // cbmanv
            // 
            this.cbmanv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmanv.DataSource = this.nhanVienBindingSource;
            this.cbmanv.DisplayMember = "Manhanvien";
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(108, 91);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(179, 21);
            this.cbmanv.TabIndex = 21;
            this.cbmanv.ValueMember = "Manhanvien";
            // 
            // tsohdn
            // 
            this.tsohdn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsohdn.Location = new System.Drawing.Point(108, 50);
            this.tsohdn.Margin = new System.Windows.Forms.Padding(2);
            this.tsohdn.Name = "tsohdn";
            this.tsohdn.Size = new System.Drawing.Size(179, 20);
            this.tsohdn.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số HĐN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tngaynhap);
            this.groupBox2.Controls.Add(this.cbncc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(505, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 127);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // tngaynhap
            // 
            this.tngaynhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tngaynhap.Location = new System.Drawing.Point(117, 47);
            this.tngaynhap.Name = "tngaynhap";
            this.tngaynhap.Size = new System.Drawing.Size(177, 20);
            this.tngaynhap.TabIndex = 24;
            // 
            // cbncc
            // 
            this.cbncc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbncc.DataSource = this.nhacungcapBindingSource;
            this.cbncc.DisplayMember = "MaNCC";
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(117, 91);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(177, 21);
            this.cbncc.TabIndex = 23;
            this.cbncc.ValueMember = "MaNCC";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã nhà cung cấp :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.ltongtien);
            this.groupBox3.Location = new System.Drawing.Point(58, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 58);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng tiền theo Số Hóa Đơn Nhập";
            // 
            // hoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 458);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bxong);
            this.Controls.Add(this.bxoa);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.blammoi);
            this.Controls.Add(this.bthem);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hoadonnhap";
            this.Text = "Hóa đơn nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hoadonnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMhanghoaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.Button blammoi;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.Label ltongtien;
        private System.Windows.Forms.BindingSource qUANLYGOMSUDataSetBindingSource;
        private QUANLYGOMSUDataSet qUANLYGOMSUDataSet;
        private System.Windows.Forms.BindingSource dMhanghoaBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.DMhanghoaTableAdapter dMhanghoaTableAdapter;
        private System.Windows.Forms.BindingSource nhacungcapBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.NhacungcapTableAdapter nhacungcapTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.Button bxong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.TextBox tsohdn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker tngaynhap;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}