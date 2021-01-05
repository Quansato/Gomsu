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
    public partial class men : Form
    {
        chucnang data = new chucnang();
        public men()
        {
            InitializeComponent();
            tmamen.TabIndex = 0;
        }

        private void Men_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Men");
            xong();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmamen.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenmen.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into MEn (MaLoaiMen,TenLoaiMen) values ('" + tmamen.Text + "',N'" + ttenmen.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from Men");
                lammoi();
            }
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        int ktdl()
        {

            int k = 0;
            if (tmamen.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã men");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmamen.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã men này đã có."); break; }
            }
            return k;

        }
        void lammoi()
        {
            tmamen.Focus();
            ttenmen.Text = null;
            tmamen.Text = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmamen.Focus();
            ttenmen.Text = null;
            tmamen.Text = null;
            xong();
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmamen.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã men");
                k = 1;
                tmamen.Focus();
            }
            
            if (k == 0)
            {
                tmamen.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmamen.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã loại men");
                tmamen.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from Men where MaLoaiMen = '" + tmamen.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from Men");
                lammoi();
            }
        }
        void xong()
        {
            tmamen.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmamen.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã men");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmamen.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update Men set TenLoaiMen = N'" + ttenmen.Text + "' where MaLoaiMen = '" + tmamen.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from Men");
                xong();
                lammoi();
            }
        }
    }
}
