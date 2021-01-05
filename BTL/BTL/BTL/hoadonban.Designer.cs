namespace BTL
{
    partial class hoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadonban));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGOMSUDataSet = new BTL.QUANLYGOMSUDataSet();
            this.ltongtien = new System.Windows.Forms.Label();
            this.bxoa = new System.Windows.Forms.Button();
            this.bthoat = new System.Windows.Forms.Button();
            this.blammoi = new System.Windows.Forms.Button();
            this.bthem = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.NhanVienTableAdapter();
            this.khachhangTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.KhachhangTableAdapter();
            this.bxong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tshdb = new System.Windows.Forms.TextBox();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tngayban = new System.Windows.Forms.DateTimePicker();
            this.cbmakhach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(55, 274);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(879, 184);
            this.dgv.TabIndex = 12;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHĐB_CellClick);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            // 
            // qUANLYGOMSUDataSet
            // 
            this.qUANLYGOMSUDataSet.DataSetName = "QUANLYGOMSUDataSet";
            this.qUANLYGOMSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ltongtien
            // 
            this.ltongtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ltongtien.AutoSize = true;
            this.ltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ltongtien.Location = new System.Drawing.Point(98, 16);
            this.ltongtien.Name = "ltongtien";
            this.ltongtien.Size = new System.Drawing.Size(26, 29);
            this.ltongtien.TabIndex = 15;
            this.ltongtien.Text = "0";
            // 
            // bxoa
            // 
            this.bxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxoa.Image = ((System.Drawing.Image)(resources.GetObject("bxoa.Image")));
            this.bxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxoa.Location = new System.Drawing.Point(280, 464);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(121, 25);
            this.bxoa.TabIndex = 24;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.Bxoa_Click);
            // 
            // bthoat
            // 
            this.bthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthoat.Image = ((System.Drawing.Image)(resources.GetObject("bthoat.Image")));
            this.bthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthoat.Location = new System.Drawing.Point(762, 464);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(121, 25);
            this.bthoat.TabIndex = 23;
            this.bthoat.Text = "Thoát";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.Bthoat_Click);
            // 
            // blammoi
            // 
            this.blammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blammoi.Image = ((System.Drawing.Image)(resources.GetObject("blammoi.Image")));
            this.blammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blammoi.Location = new System.Drawing.Point(605, 464);
            this.blammoi.Name = "blammoi";
            this.blammoi.Size = new System.Drawing.Size(121, 25);
            this.blammoi.TabIndex = 22;
            this.blammoi.Text = "Làm mới";
            this.blammoi.UseVisualStyleBackColor = true;
            this.blammoi.Click += new System.EventHandler(this.Blammoi_Click);
            // 
            // bthem
            // 
            this.bthem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthem.Image = ((System.Drawing.Image)(resources.GetObject("bthem.Image")));
            this.bthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthem.Location = new System.Drawing.Point(443, 464);
            this.bthem.Name = "bthem";
            this.bthem.Size = new System.Drawing.Size(121, 25);
            this.bthem.TabIndex = 21;
            this.bthem.Text = "Thêm mới";
            this.bthem.UseVisualStyleBackColor = true;
            this.bthem.Click += new System.EventHandler(this.Bthem_Click);
            // 
            // bSua
            // 
            this.bSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSua.Image = ((System.Drawing.Image)(resources.GetObject("bSua.Image")));
            this.bSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSua.Location = new System.Drawing.Point(114, 464);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(121, 25);
            this.bSua.TabIndex = 20;
            this.bSua.Text = "Sửa Thông Tin";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.BSua_Click);
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "Khachhang";
            this.khachhangBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // bxong
            // 
            this.bxong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxong.BackColor = System.Drawing.Color.Red;
            this.bxong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bxong.Image = ((System.Drawing.Image)(resources.GetObject("bxong.Image")));
            this.bxong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxong.Location = new System.Drawing.Point(115, 463);
            this.bxong.Name = "bxong";
            this.bxong.Size = new System.Drawing.Size(120, 25);
            this.bxong.TabIndex = 54;
            this.bxong.Text = "Xong";
            this.bxong.UseVisualStyleBackColor = false;
            this.bxong.Click += new System.EventHandler(this.Bxong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tshdb);
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(83, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 125);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // tshdb
            // 
            this.tshdb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tshdb.Location = new System.Drawing.Point(103, 32);
            this.tshdb.Margin = new System.Windows.Forms.Padding(2);
            this.tshdb.Name = "tshdb";
            this.tshdb.Size = new System.Drawing.Size(193, 20);
            this.tshdb.TabIndex = 0;
            // 
            // cbmanv
            // 
            this.cbmanv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmanv.DataSource = this.nhanVienBindingSource;
            this.cbmanv.DisplayMember = "Manhanvien";
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(103, 77);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(191, 21);
            this.cbmanv.TabIndex = 29;
            this.cbmanv.ValueMember = "Manhanvien";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã nhân viên:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Số HĐB:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tngayban);
            this.groupBox2.Controls.Add(this.cbmakhach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(547, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 125);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // tngayban
            // 
            this.tngayban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tngayban.Location = new System.Drawing.Point(107, 32);
            this.tngayban.Name = "tngayban";
            this.tngayban.Size = new System.Drawing.Size(193, 20);
            this.tngayban.TabIndex = 31;
            // 
            // cbmakhach
            // 
            this.cbmakhach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmakhach.DataSource = this.khachhangBindingSource;
            this.cbmakhach.DisplayMember = "Makhach";
            this.cbmakhach.FormattingEnabled = true;
            this.cbmakhach.Location = new System.Drawing.Point(107, 82);
            this.cbmakhach.Name = "cbmakhach";
            this.cbmakhach.Size = new System.Drawing.Size(193, 21);
            this.cbmakhach.TabIndex = 30;
            this.cbmakhach.ValueMember = "Makhach";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày bán:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã khách:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.ltongtien);
            this.groupBox3.Location = new System.Drawing.Point(83, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 62);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng tiền theo số hóa đơn bán";
            // 
            // hoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 501);
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
            this.Name = "hoadonban";
            this.Text = "Hóa đơn bán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
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
        private System.Windows.Forms.Label ltongtien;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.Button blammoi;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.Button bSua;
        private QUANLYGOMSUDataSet qUANLYGOMSUDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.KhachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.Button bxong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tshdb;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker tngayban;
        private System.Windows.Forms.ComboBox cbmakhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}