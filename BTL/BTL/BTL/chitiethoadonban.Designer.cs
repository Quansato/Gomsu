namespace BTL
{
    partial class chitiethoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitiethoadonban));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.dMhanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGOMSUDataSet = new BTL.QUANLYGOMSUDataSet();
            this.ltthanhtien = new System.Windows.Forms.Label();
            this.bxoa = new System.Windows.Forms.Button();
            this.bthoat = new System.Windows.Forms.Button();
            this.blammoi = new System.Windows.Forms.Button();
            this.bthem = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.cbsohdb = new System.Windows.Forms.ComboBox();
            this.hoadonbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonbanTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.HoadonbanTableAdapter();
            this.dMhanghoaTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.DMhanghoaTableAdapter();
            this.bxong = new System.Windows.Forms.Button();
            this.btimkiem = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.cbgiamgia = new System.Windows.Forms.ComboBox();
            this.tsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMhanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonbanBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN BÁN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số HĐB:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã hàng:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(8, 234);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(874, 175);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // cbmahang
            // 
            this.cbmahang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmahang.DataSource = this.dMhanghoaBindingSource;
            this.cbmahang.DisplayMember = "Mahang";
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(78, 67);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(187, 21);
            this.cbmahang.TabIndex = 12;
            this.cbmahang.ValueMember = "Mahang";
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
            // ltthanhtien
            // 
            this.ltthanhtien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ltthanhtien.AutoSize = true;
            this.ltthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltthanhtien.ForeColor = System.Drawing.Color.Lime;
            this.ltthanhtien.Location = new System.Drawing.Point(63, 16);
            this.ltthanhtien.Name = "ltthanhtien";
            this.ltthanhtien.Size = new System.Drawing.Size(26, 29);
            this.ltthanhtien.TabIndex = 14;
            this.ltthanhtien.Text = "0";
            // 
            // bxoa
            // 
            this.bxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxoa.Image = ((System.Drawing.Image)(resources.GetObject("bxoa.Image")));
            this.bxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxoa.Location = new System.Drawing.Point(156, 414);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(121, 25);
            this.bxoa.TabIndex = 29;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.Bxoa_Click);
            // 
            // bthoat
            // 
            this.bthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthoat.Image = ((System.Drawing.Image)(resources.GetObject("bthoat.Image")));
            this.bthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthoat.Location = new System.Drawing.Point(761, 414);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(121, 25);
            this.bthoat.TabIndex = 28;
            this.bthoat.Text = "Thoát";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.Bthoat_Click);
            // 
            // blammoi
            // 
            this.blammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blammoi.Image = ((System.Drawing.Image)(resources.GetObject("blammoi.Image")));
            this.blammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blammoi.Location = new System.Drawing.Point(459, 414);
            this.blammoi.Name = "blammoi";
            this.blammoi.Size = new System.Drawing.Size(121, 25);
            this.blammoi.TabIndex = 27;
            this.blammoi.Text = "Làm mới";
            this.blammoi.UseVisualStyleBackColor = true;
            this.blammoi.Click += new System.EventHandler(this.Blammoi_Click);
            // 
            // bthem
            // 
            this.bthem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthem.Image = ((System.Drawing.Image)(resources.GetObject("bthem.Image")));
            this.bthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthem.Location = new System.Drawing.Point(303, 414);
            this.bthem.Name = "bthem";
            this.bthem.Size = new System.Drawing.Size(121, 25);
            this.bthem.TabIndex = 26;
            this.bthem.Text = "Thêm mới";
            this.bthem.UseVisualStyleBackColor = true;
            this.bthem.Click += new System.EventHandler(this.Bthem_Click);
            // 
            // bSua
            // 
            this.bSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSua.Image = ((System.Drawing.Image)(resources.GetObject("bSua.Image")));
            this.bSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSua.Location = new System.Drawing.Point(8, 414);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(121, 25);
            this.bSua.TabIndex = 25;
            this.bSua.Text = "Sửa Thông Tin";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.BSua_Click);
            // 
            // cbsohdb
            // 
            this.cbsohdb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbsohdb.DataSource = this.hoadonbanBindingSource;
            this.cbsohdb.DisplayMember = "SoHDB";
            this.cbsohdb.FormattingEnabled = true;
            this.cbsohdb.Location = new System.Drawing.Point(78, 28);
            this.cbsohdb.Name = "cbsohdb";
            this.cbsohdb.Size = new System.Drawing.Size(187, 21);
            this.cbsohdb.TabIndex = 0;
            this.cbsohdb.ValueMember = "SoHDB";
            // 
            // hoadonbanBindingSource
            // 
            this.hoadonbanBindingSource.DataMember = "Hoadonban";
            this.hoadonbanBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            // 
            // hoadonbanTableAdapter
            // 
            this.hoadonbanTableAdapter.ClearBeforeFill = true;
            // 
            // dMhanghoaTableAdapter
            // 
            this.dMhanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // bxong
            // 
            this.bxong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxong.BackColor = System.Drawing.Color.Red;
            this.bxong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bxong.Image = ((System.Drawing.Image)(resources.GetObject("bxong.Image")));
            this.bxong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxong.Location = new System.Drawing.Point(9, 414);
            this.bxong.Name = "bxong";
            this.bxong.Size = new System.Drawing.Size(120, 25);
            this.bxong.TabIndex = 51;
            this.bxong.Text = "Xong";
            this.bxong.UseVisualStyleBackColor = false;
            this.bxong.Click += new System.EventHandler(this.Bxong_Click);
            // 
            // btimkiem
            // 
            this.btimkiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btimkiem.Image")));
            this.btimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btimkiem.Location = new System.Drawing.Point(616, 413);
            this.btimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btimkiem.Name = "btimkiem";
            this.btimkiem.Size = new System.Drawing.Size(121, 26);
            this.btimkiem.TabIndex = 54;
            this.btimkiem.Text = "Tìm kiếm";
            this.btimkiem.UseVisualStyleBackColor = true;
            this.btimkiem.Click += new System.EventHandler(this.Btimkiem_Click);
            // 
            // GB
            // 
            this.GB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GB.Controls.Add(this.label2);
            this.GB.Controls.Add(this.label6);
            this.GB.Controls.Add(this.cbmahang);
            this.GB.Controls.Add(this.cbsohdb);
            this.GB.Location = new System.Drawing.Point(65, 50);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(300, 100);
            this.GB.TabIndex = 55;
            this.GB.TabStop = false;
            this.GB.Text = "Hóa đơn";
            // 
            // gb1
            // 
            this.gb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb1.Controls.Add(this.cbgiamgia);
            this.gb1.Controls.Add(this.tsoluong);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Location = new System.Drawing.Point(514, 50);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(300, 100);
            this.gb1.TabIndex = 56;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thống kê";
            // 
            // cbgiamgia
            // 
            this.cbgiamgia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbgiamgia.FormattingEnabled = true;
            this.cbgiamgia.Location = new System.Drawing.Point(90, 67);
            this.cbgiamgia.Name = "cbgiamgia";
            this.cbgiamgia.Size = new System.Drawing.Size(183, 21);
            this.cbgiamgia.TabIndex = 17;
            // 
            // tsoluong
            // 
            this.tsoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsoluong.Location = new System.Drawing.Point(89, 28);
            this.tsoluong.Margin = new System.Windows.Forms.Padding(2);
            this.tsoluong.Name = "tsoluong";
            this.tsoluong.Size = new System.Drawing.Size(184, 20);
            this.tsoluong.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gỉảm giá:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.ltthanhtien);
            this.groupBox1.Location = new System.Drawing.Point(65, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 54);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thành tiền";
            // 
            // btim
            // 
            this.btim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btim.Image = ((System.Drawing.Image)(resources.GetObject("btim.Image")));
            this.btim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btim.Location = new System.Drawing.Point(616, 412);
            this.btim.Name = "btim";
            this.btim.Size = new System.Drawing.Size(120, 25);
            this.btim.TabIndex = 58;
            this.btim.Text = "Tìm";
            this.btim.UseVisualStyleBackColor = false;
            this.btim.Click += new System.EventHandler(this.Btim_Click);
            // 
            // chitiethoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 449);
            this.Controls.Add(this.btim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.btimkiem);
            this.Controls.Add(this.bxong);
            this.Controls.Add(this.bxoa);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.blammoi);
            this.Controls.Add(this.bthem);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "chitiethoadonban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn bán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chitiethoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMhanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonbanBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbmahang;
        private System.Windows.Forms.Label ltthanhtien;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.Button blammoi;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.ComboBox cbsohdb;
        private QUANLYGOMSUDataSet qUANLYGOMSUDataSet;
        private System.Windows.Forms.BindingSource hoadonbanBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.HoadonbanTableAdapter hoadonbanTableAdapter;
        private System.Windows.Forms.BindingSource dMhanghoaBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.DMhanghoaTableAdapter dMhanghoaTableAdapter;
        private System.Windows.Forms.Button bxong;
        private System.Windows.Forms.Button btimkiem;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ComboBox cbgiamgia;
        private System.Windows.Forms.TextBox tsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btim;
    }
}