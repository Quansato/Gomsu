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
    public partial class hoavan : Form
    {
        chucnang data = new chucnang();
        public hoavan()
        {
            InitializeComponent();
        }

        private void Hoavan_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Hoavan");
            xong();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmahv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenhv.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hoa văn");
                k = 1;
            }
           
            if (k == 0)
            {
                tmahv.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }
        int ktdl()
        {

            int k = 0;
            if (tmahv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hoa văn");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmahv.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã hoa văn này đã có."); break; }
            }
            return k;

        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into HoaVan (MaHoaVan,TenHoaVan) values ('" + tmahv.Text + "',N'" + ttenhv.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HoaVan");
                lammoi();
            }
        }
        void lammoi()
        {

            tmahv.Focus();
            ttenhv.Text = null;
            tmahv.Text = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmahv.Focus();
            ttenhv.Text = null;
            tmahv.Text = null;
            xong();
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahv.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã hoa văn");
                k = 1;
                tmahv.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from HoaVan where MaHoaVan = '" + tmahv.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HoaVan");
                lammoi();
            }
        }
        void xong()
        {
            tmahv.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }

        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hoa văn");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmahv.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update HoaVan set TenHoaVan = N'" + ttenhv.Text + "' where MaHoaVan = '" + tmahv.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from HoaVan");
                xong();
                lammoi();
            }
        }
    }
}
