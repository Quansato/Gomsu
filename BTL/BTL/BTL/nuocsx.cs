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
    public partial class nuocsx : Form
    {
        chucnang data = new chucnang();
        public nuocsx()
        {
            
            InitializeComponent();
            tmansx.TabIndex = 0;
        }

        private void Nuocsx_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from nuocSX");
            xong();
        }
        void lammoi()
        {
            tmansx.Focus();
            ttennsx.Text = null;
            tmansx.Text = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmansx.Focus();
            ttennsx.Text = null;
            tmansx.Text = null;
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmansx.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã nước sản xuất");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmansx.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã nước sản xuất này đã có."); break; }
            }
            return k;

        }
        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into NuocSx (MaNuocSX,TenNuocSX) values ('" + tmansx.Text + "',N'" + ttennsx.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from NuocSX");
                lammoi();
            }
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmansx.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã nước sản xuất");
                k = 1;
            }
           
            if (k == 0)
            {
                tmansx.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmansx.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttennsx.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmansx.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã nước sản xuất");
                tmansx.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from Nuocsx where MaNuocSx = '" + tmansx.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from NuocSX");
                lammoi();
            }
        }
        void xong()
        {
            tmansx.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmansx.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã nước sản xuất");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmansx.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update NuocSX set TenNuocSX = N'" + ttennsx.Text + "' where MaNuocSX = '" + tmansx.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from NuocSX");
                xong();
                lammoi();
            }
        }
    }
}
