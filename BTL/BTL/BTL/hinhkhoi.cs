using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class hinhkhoi : Form
    {
        chucnang data = new chucnang();
        public hinhkhoi()
        {
            InitializeComponent();
        }

        private void Hinhkhoi_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Hinhkhoi");
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmahk.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hình khối");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmahk.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("mã hình khối này đã có."); break; }
            }
            return k;

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmahk.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenhk.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahk.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hình khối");
                k = 1;
            }
            
            if (k == 0)
            {
                tmahk.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        void lammoi()
        {
            tmahk.Focus();
            ttenhk.Text = null;
            tmahk.Text = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmahk.Focus();
            ttenhk.Text = null;
            tmahk.Text = null;
            xong();
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into HinhKhoi (MaHinhKhoi,TenHinhKhoi) values ('" + tmahk.Text + "',N'" + ttenhk.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HinhKhoi");
                lammoi();
            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahk.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã hình khối");
                k = 1;
                tmahk.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from HinhKhoi where MaHinhKhoi = '" + tmahk.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HinhKhoi");
                lammoi();
            }
        }
        void xong()
        {
            tmahk.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahk.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hình khối");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmahk.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update Loai set TenHinhKhoi = N'" + ttenhk.Text + "' where MaHinhKhoi = '" + tmahk.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from HinhKhoi");
                xong();
                lammoi();
            }
        }
    }
}
