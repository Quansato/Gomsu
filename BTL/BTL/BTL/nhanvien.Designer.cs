namespace BTL
{
    partial class nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhanvien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tmanv = new System.Windows.Forms.TextBox();
            this.tsdt = new System.Windows.Forms.TextBox();
            this.tdiachi = new System.Windows.Forms.TextBox();
            this.ttennv = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bthoat = new System.Windows.Forms.Button();
            this.blammoi = new System.Windows.Forms.Button();
            this.bthem = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.cbmacv = new System.Windows.Forms.ComboBox();
            this.congviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYGOMSUDataSet = new BTL.QUANLYGOMSUDataSet();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.congviecTableAdapter = new BTL.QUANLYGOMSUDataSetTableAdapters.CongviecTableAdapter();
            this.bxoa = new System.Windows.Forms.Button();
            this.tngaysinh = new System.Windows.Forms.DateTimePicker();
            this.bxong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congviecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Công Việc:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giới Tính:";
            // 
            // tmanv
            // 
            this.tmanv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tmanv.Location = new System.Drawing.Point(161, 59);
            this.tmanv.Margin = new System.Windows.Forms.Padding(2);
            this.tmanv.Name = "tmanv";
            this.tmanv.Size = new System.Drawing.Size(202, 20);
            this.tmanv.TabIndex = 8;
            // 
            // tsdt
            // 
            this.tsdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsdt.Location = new System.Drawing.Point(568, 96);
            this.tsdt.Margin = new System.Windows.Forms.Padding(2);
            this.tsdt.Name = "tsdt";
            this.tsdt.Size = new System.Drawing.Size(202, 20);
            this.tsdt.TabIndex = 9;
            this.tsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tsdt_KeyPress);
            // 
            // tdiachi
            // 
            this.tdiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tdiachi.Location = new System.Drawing.Point(568, 135);
            this.tdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.tdiachi.Name = "tdiachi";
            this.tdiachi.Size = new System.Drawing.Size(202, 20);
            this.tdiachi.TabIndex = 12;
            // 
            // ttennv
            // 
            this.ttennv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ttennv.Location = new System.Drawing.Point(161, 135);
            this.ttennv.Margin = new System.Windows.Forms.Padding(2);
            this.ttennv.Name = "ttennv";
            this.ttennv.Size = new System.Drawing.Size(202, 20);
            this.ttennv.TabIndex = 13;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(37, 202);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(786, 124);
            this.dgv.TabIndex = 15;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // bthoat
            // 
            this.bthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthoat.Image = ((System.Drawing.Image)(resources.GetObject("bthoat.Image")));
            this.bthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthoat.Location = new System.Drawing.Point(703, 345);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(120, 25);
            this.bthoat.TabIndex = 41;
            this.bthoat.Text = "Thoát";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.Bthoat_Click);
            // 
            // blammoi
            // 
            this.blammoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blammoi.Image = ((System.Drawing.Image)(resources.GetObject("blammoi.Image")));
            this.blammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blammoi.Location = new System.Drawing.Point(536, 345);
            this.blammoi.Name = "blammoi";
            this.blammoi.Size = new System.Drawing.Size(120, 25);
            this.blammoi.TabIndex = 40;
            this.blammoi.Text = "Làm mới";
            this.blammoi.UseVisualStyleBackColor = true;
            this.blammoi.Click += new System.EventHandler(this.Blammoi_Click);
            // 
            // bthem
            // 
            this.bthem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthem.Image = ((System.Drawing.Image)(resources.GetObject("bthem.Image")));
            this.bthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthem.Location = new System.Drawing.Point(200, 345);
            this.bthem.Name = "bthem";
            this.bthem.Size = new System.Drawing.Size(120, 25);
            this.bthem.TabIndex = 39;
            this.bthem.Text = "Thêm mới";
            this.bthem.UseVisualStyleBackColor = true;
            this.bthem.Click += new System.EventHandler(this.Bthem_Click);
            // 
            // bSua
            // 
            this.bSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSua.Image = ((System.Drawing.Image)(resources.GetObject("bSua.Image")));
            this.bSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSua.Location = new System.Drawing.Point(37, 345);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(120, 25);
            this.bSua.TabIndex = 38;
            this.bSua.Text = "Sửa Thông Tin";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.BSua_Click);
            // 
            // cbmacv
            // 
            this.cbmacv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmacv.DataSource = this.congviecBindingSource;
            this.cbmacv.DisplayMember = "MaCV";
            this.cbmacv.FormattingEnabled = true;
            this.cbmacv.Location = new System.Drawing.Point(161, 96);
            this.cbmacv.Name = "cbmacv";
            this.cbmacv.Size = new System.Drawing.Size(202, 21);
            this.cbmacv.TabIndex = 42;
            this.cbmacv.ValueMember = "MaCV";
            // 
            // congviecBindingSource
            // 
            this.congviecBindingSource.DataMember = "Congviec";
            this.congviecBindingSource.DataSource = this.qUANLYGOMSUDataSet;
            // 
            // qUANLYGOMSUDataSet
            // 
            this.qUANLYGOMSUDataSet.DataSetName = "QUANLYGOMSUDataSet";
            this.qUANLYGOMSUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdnam
            // 
            this.rdnam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(191, 166);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 43;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // rdnu
            // 
            this.rdnu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(267, 166);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 44;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // congviecTableAdapter
            // 
            this.congviecTableAdapter.ClearBeforeFill = true;
            // 
            // bxoa
            // 
            this.bxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxoa.Image = ((System.Drawing.Image)(resources.GetObject("bxoa.Image")));
            this.bxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxoa.Location = new System.Drawing.Point(369, 345);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(120, 25);
            this.bxoa.TabIndex = 49;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.Bxoa_Click);
            // 
            // tngaysinh
            // 
            this.tngaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tngaysinh.Location = new System.Drawing.Point(568, 59);
            this.tngaysinh.Name = "tngaysinh";
            this.tngaysinh.Size = new System.Drawing.Size(202, 20);
            this.tngaysinh.TabIndex = 50;
            // 
            // bxong
            // 
            this.bxong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxong.BackColor = System.Drawing.Color.Red;
            this.bxong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bxong.Image = ((System.Drawing.Image)(resources.GetObject("bxong.Image")));
            this.bxong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxong.Location = new System.Drawing.Point(37, 345);
            this.bxong.Name = "bxong";
            this.bxong.Size = new System.Drawing.Size(120, 25);
            this.bxong.TabIndex = 56;
            this.bxong.Text = "Xong";
            this.bxong.UseVisualStyleBackColor = false;
            this.bxong.Click += new System.EventHandler(this.Bxong_Click);
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 382);
            this.Controls.Add(this.bxong);
            this.Controls.Add(this.tngaysinh);
            this.Controls.Add(this.bxoa);
            this.Controls.Add(this.rdnu);
            this.Controls.Add(this.rdnam);
            this.Controls.Add(this.cbmacv);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.blammoi);
            this.Controls.Add(this.bthem);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ttennv);
            this.Controls.Add(this.tdiachi);
            this.Controls.Add(this.tsdt);
            this.Controls.Add(this.tmanv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "nhanvien";
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congviecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYGOMSUDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tmanv;
        private System.Windows.Forms.TextBox tsdt;
        private System.Windows.Forms.TextBox tdiachi;
        private System.Windows.Forms.TextBox ttennv;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.Button blammoi;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.ComboBox cbmacv;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.RadioButton rdnu;
        private QUANLYGOMSUDataSet qUANLYGOMSUDataSet;
        private System.Windows.Forms.BindingSource congviecBindingSource;
        private QUANLYGOMSUDataSetTableAdapters.CongviecTableAdapter congviecTableAdapter;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.DateTimePicker tngaysinh;
        private System.Windows.Forms.Button bxong;
    }
}