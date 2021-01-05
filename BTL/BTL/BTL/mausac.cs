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
    public partial class mausac : Form
    {
        chucnang data = new chucnang();
        public mausac()
        {
            InitializeComponent();
            tmacl.TabIndex = 0;
        }

        private void Mausac_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Mau");
            xong();
        }
        void lammoi()
        {
            tmacl.Focus();
            ttencl.Text = null;
            tmacl.Text = null;
        }

        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmacl.Focus();
            ttencl.Text = null;
            tmacl.Text = null;
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmacl.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã màu sắc");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmacl.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã màu sắc này đã có."); break; }
            }
            return k;

        }
        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacl.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã màu sắc");
                k = 1;
                tmacl.Focus();
            }
            
            if (k == 0)
            {
                tmacl.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into Mau (MaMau,TenMau) values ('" + tmacl.Text + "',N'" + ttencl.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from Mau");
                lammoi();
            }
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmacl.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttencl.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacl.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã màu sắc");
                tmacl.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from Mau where MaMau = '" + tmacl.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from Mau");
                lammoi();
            }
        }
        void xong()
        {
            tmacl.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacl.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã màu sắc");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmacl.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update mau set TenMau = N'" + ttencl.Text + "' where MaMau = '" + tmacl.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from Mau");
                xong();
                lammoi();
            }
        }
    }
}
