namespace BTL
{
    partial class timkiemhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiemhoadon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMAHANG = new System.Windows.Forms.TextBox();
            this.textBoxTONGTIEN = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonTIMKIEM = new System.Windows.Forms.Button();
            this.buttonTHOAT = new System.Windows.Forms.Button();
            this.textBoxNGAYBAN = new System.Windows.Forms.TextBox();
            this.buttonLAMMOI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền:";
            // 
            // textBoxMAHANG
            // 
            this.textBoxMAHANG.Location = new System.Drawing.Point(17, 29);
            this.textBoxMAHANG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMAHANG.Name = "textBoxMAHANG";
            this.textBoxMAHANG.Size = new System.Drawing.Size(140, 20);
            this.textBoxMAHANG.TabIndex = 5;
            // 
            // textBoxTONGTIEN
            // 
            this.textBoxTONGTIEN.Location = new System.Drawing.Point(17, 83);
            this.textBoxTONGTIEN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTONGTIEN.Name = "textBoxTONGTIEN";
            this.textBoxTONGTIEN.Size = new System.Drawing.Size(140, 20);
            this.textBoxTONGTIEN.TabIndex = 6;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 48);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(575, 264);
            this.dgv.TabIndex = 8;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // buttonTIMKIEM
            // 
            this.buttonTIMKIEM.Image = ((System.Drawing.Image)(resources.GetObject("buttonTIMKIEM.Image")));
            this.buttonTIMKIEM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTIMKIEM.Location = new System.Drawing.Point(3, 6);
            this.buttonTIMKIEM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTIMKIEM.Name = "buttonTIMKIEM";
            this.buttonTIMKIEM.Size = new System.Drawing.Size(77, 28);
            this.buttonTIMKIEM.TabIndex = 9;
            this.buttonTIMKIEM.Text = "Tìm kiếm";
            this.buttonTIMKIEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTIMKIEM.UseVisualStyleBackColor = true;
            this.buttonTIMKIEM.Click += new System.EventHandler(this.ButtonTIMKIEM_Click);
            // 
            // buttonTHOAT
            // 
            this.buttonTHOAT.Image = ((System.Drawing.Image)(resources.GetObject("buttonTHOAT.Image")));
            this.buttonTHOAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTHOAT.Location = new System.Drawing.Point(510, 6);
            this.buttonTHOAT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTHOAT.Name = "buttonTHOAT";
            this.buttonTHOAT.Size = new System.Drawing.Size(68, 28);
            this.buttonTHOAT.TabIndex = 10;
            this.buttonTHOAT.Text = "Thoát";
            this.buttonTHOAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTHOAT.UseVisualStyleBackColor = true;
            this.buttonTHOAT.Click += new System.EventHandler(this.ButtonTHOAT_Click);
            // 
            // textBoxNGAYBAN
            // 
            this.textBoxNGAYBAN.Location = new System.Drawing.Point(17, 135);
            this.textBoxNGAYBAN.Name = "textBoxNGAYBAN";
            this.textBoxNGAYBAN.Size = new System.Drawing.Size(140, 20);
            this.textBoxNGAYBAN.TabIndex = 11;
            // 
            // buttonLAMMOI
            // 
            this.buttonLAMMOI.Image = ((System.Drawing.Image)(resources.GetObject("buttonLAMMOI.Image")));
            this.buttonLAMMOI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLAMMOI.Location = new System.Drawing.Point(235, 6);
            this.buttonLAMMOI.Name = "buttonLAMMOI";
            this.buttonLAMMOI.Size = new System.Drawing.Size(75, 28);
            this.buttonLAMMOI.TabIndex = 12;
            this.buttonLAMMOI.Text = "Làm mới";
            this.buttonLAMMOI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLAMMOI.UseVisualStyleBackColor = true;
            this.buttonLAMMOI.Click += new System.EventHandler(this.ButtonLAMMOI_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNGAYBAN);
            this.panel1.Controls.Add(this.textBoxTONGTIEN);
            this.panel1.Controls.Add(this.textBoxMAHANG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(598, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 279);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLAMMOI);
            this.panel2.Controls.Add(this.buttonTHOAT);
            this.panel2.Controls.Add(this.buttonTIMKIEM);
            this.panel2.Location = new System.Drawing.Point(8, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 42);
            this.panel2.TabIndex = 14;
            // 
            // timkiemhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "timkiemhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm Hóa Đơn";
            this.Load += new System.EventHandler(this.Timkiemhoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMAHANG;
        private System.Windows.Forms.TextBox textBoxTONGTIEN;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonTIMKIEM;
        private System.Windows.Forms.Button buttonTHOAT;
        private System.Windows.Forms.TextBox textBoxNGAYBAN;
        private System.Windows.Forms.Button buttonLAMMOI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}