﻿namespace BTL
{
    partial class hoavan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoavan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmahv = new System.Windows.Forms.TextBox();
            this.ttenhv = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bthoat = new System.Windows.Forms.Button();
            this.blammoi = new System.Windows.Forms.Button();
            this.bthem = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.bxoa = new System.Windows.Forms.Button();
            this.bxong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(248, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoa Văn Của Sản Phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hoa văn:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hoa văn:";
            // 
            // tmahv
            // 
            this.tmahv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tmahv.Location = new System.Drawing.Point(261, 97);
            this.tmahv.Margin = new System.Windows.Forms.Padding(2);
            this.tmahv.Name = "tmahv";
            this.tmahv.Size = new System.Drawing.Size(271, 20);
            this.tmahv.TabIndex = 3;
            // 
            // ttenhv
            // 
            this.ttenhv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ttenhv.Location = new System.Drawing.Point(261, 148);
            this.ttenhv.Margin = new System.Windows.Forms.Padding(2);
            this.ttenhv.Name = "ttenhv";
            this.ttenhv.Size = new System.Drawing.Size(271, 20);
            this.ttenhv.TabIndex = 4;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(39, 189);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(669, 267);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // bthoat
            // 
            this.bthoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bthoat.Image = ((System.Drawing.Image)(resources.GetObject("bthoat.Image")));
            this.bthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthoat.Location = new System.Drawing.Point(588, 470);
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
            this.blammoi.Location = new System.Drawing.Point(451, 470);
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
            this.bthem.Location = new System.Drawing.Point(313, 470);
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
            this.bSua.Location = new System.Drawing.Point(39, 470);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(120, 25);
            this.bSua.TabIndex = 38;
            this.bSua.Text = "Sửa Thông Tin";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.BSua_Click);
            // 
            // bxoa
            // 
            this.bxoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bxoa.Image = ((System.Drawing.Image)(resources.GetObject("bxoa.Image")));
            this.bxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bxoa.Location = new System.Drawing.Point(176, 470);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(120, 25);
            this.bxoa.TabIndex = 49;
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
            this.bxong.Location = new System.Drawing.Point(39, 470);
            this.bxong.Name = "bxong";
            this.bxong.Size = new System.Drawing.Size(120, 25);
            this.bxong.TabIndex = 56;
            this.bxong.Text = "Xong";
            this.bxong.UseVisualStyleBackColor = false;
            this.bxong.Click += new System.EventHandler(this.Bxong_Click);
            // 
            // hoavan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 521);
            this.Controls.Add(this.bxong);
            this.Controls.Add(this.bxoa);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.blammoi);
            this.Controls.Add(this.bthem);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ttenhv);
            this.Controls.Add(this.tmahv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hoavan";
            this.Text = "Hoa Văn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hoavan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tmahv;
        private System.Windows.Forms.TextBox ttenhv;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.Button blammoi;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.Button bxong;
    }
}