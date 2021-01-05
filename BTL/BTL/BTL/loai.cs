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
    public partial class loai : Form
    {
        chucnang data = new chucnang();
        public loai()
        {
            InitializeComponent();
            tmaloai.TabIndex = 0;
        }

        private void Loai_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Loai");
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmaloai.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã loại");
                k = 1;
            }
            

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmaloai.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("mã loại hàng này đã có."); break; }
            }
            return k;

        }

        private void DataGridViewLOAI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmaloai.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã loại");
                k = 1;
                tmaloai.Focus();
            }
            
            if (k == 0)
            {
                tmaloai.ReadOnly = true;
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
            tmaloai.Focus();
            ttenloai.Text = null;
            tmaloai.Text = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmaloai.Focus();
            ttenloai.Text = null;
            tmaloai.Text = null;
            xong();
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl()==0)
            {
                string sql = " insert into Loai (MaLoai,TenLoai) values ('" + tmaloai.Text + "',N'" + ttenloai.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from Loai");
                lammoi();
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmaloai.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenloai.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmaloai.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã loại hàng");
                tmaloai.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from Loai where MaLoai = '" + tmaloai.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from Loai");
                lammoi();
            }
        }
        void xong()
        {
            tmaloai.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmaloai.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã loại");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmaloai.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update Loai set TenLoai = N'" + ttenloai.Text + "' where MaLoai = '" + tmaloai.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from Loai");
                xong();
                lammoi();
            }
        }
    }
}
