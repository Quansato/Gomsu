using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class timkiemhoadon : Form
    {
        chucnang data = new chucnang();
        public timkiemhoadon()
        {
            InitializeComponent();
            textBoxMAHANG.TabIndex = 0;
           
        }
    
        private void ButtonTIMKIEM_Click(object sender, EventArgs e)
        {
            
            int k = 0;

             string ngay = "select *from TimTheoNB('" + textBoxNGAYBAN.Text + "')";
             string mahang = "select *from TimTheoMH('" + textBoxMAHANG.Text + "')";
             string tongtien = "select *from TimTheoTT('" + textBoxTONGTIEN.Text + "')";
             string mahangngayban = "select *from TimTheoMHNB('" + textBoxMAHANG.Text + "','" + textBoxNGAYBAN.Text + "')";
             string mahangtongtien = "select *from TimTheoMHTT('" + textBoxMAHANG.Text + "','" + textBoxTONGTIEN.Text + "')";
             string ngaybantongtien = "select *from TimTheoNBTT('" + textBoxNGAYBAN.Text + "','" + textBoxTONGTIEN.Text + "')";
             string baloai = "select *from TimTheo3loai('" + textBoxMAHANG.Text + "','" + textBoxNGAYBAN.Text + "','" + textBoxTONGTIEN.Text + "')";
             if (textBoxMAHANG.TextLength != 0 && textBoxTONGTIEN.TextLength == 0 && textBoxNGAYBAN.TextLength == 0)
             {

                 dgv.DataSource = data.docbang(mahang);
                 k = 1;

             }
             if (textBoxMAHANG.TextLength == 0 && textBoxTONGTIEN.TextLength == 0 && textBoxNGAYBAN.TextLength!=0)
             {

                 dgv.DataSource = data.docbang(ngay);
                 k = 1;
             }
             if (textBoxMAHANG.TextLength == 0 && textBoxTONGTIEN.TextLength != 0 && textBoxNGAYBAN.TextLength==0)
             {

                 dgv.DataSource = data.docbang(tongtien);
                 k = 1;
             }
             if (textBoxMAHANG.TextLength != 0 && textBoxTONGTIEN.TextLength != 0 && textBoxNGAYBAN.TextLength != 0)
             {

                 dgv.DataSource = data.docbang(baloai);
                 k = 1;

             }
             if (textBoxMAHANG.TextLength != 0 && textBoxTONGTIEN.TextLength == 0 && textBoxNGAYBAN.TextLength != 0)
             {

                 dgv.DataSource = data.docbang(mahangngayban);
                 k = 1;

             }
             if (textBoxMAHANG.TextLength != 0 && textBoxTONGTIEN.TextLength != 0 && textBoxNGAYBAN.TextLength == 0)
             {

                 dgv.DataSource = data.docbang(mahangtongtien);
                 k = 1;

             }
             if (textBoxMAHANG.TextLength == 0 && textBoxTONGTIEN.TextLength != 0 && textBoxNGAYBAN.TextLength != 0)
             {

                 dgv.DataSource = data.docbang(ngaybantongtien);
                 k = 1;

             }
             if (k==0)
             {
                 MessageBox.Show("Nhập thông tin cần tìm kiếm ");
             }

        }

        private void Timkiemhoadon_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLAMMOI_Click(object sender, EventArgs e)
        {
            textBoxMAHANG.Text = "";
            textBoxNGAYBAN.Text = "";
            textBoxTONGTIEN.Text = "";
            dgv.DataSource = null;
            textBoxMAHANG.Focus();
        }

        private void ButtonTHOAT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            textBoxMAHANG.Text = dgv.Rows[i].Cells[1].Value.ToString();
            textBoxTONGTIEN.Text = dgv.Rows[i].Cells[3].Value.ToString();
            textBoxNGAYBAN.Text= dgv.Rows[i].Cells[2].Value.ToString();
        }
    }
}
