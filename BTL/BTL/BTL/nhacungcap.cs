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
    public partial class nhacungcap : Form
    {
        chucnang data = new chucnang();
        public nhacungcap()
        {
            InitializeComponent();
            tmancc.TabIndex = 0;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select *from Nhacungcap");
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmancc.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã nhà cung cấp");
                k = 1;
                tmancc.Focus();
            }
            if (ttenncc.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên nhà cung cấp");
                k = 1;
                ttenncc.Focus();
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmancc.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã nhà cung cấp này đã có."); break; }
            }
            return k;

        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into NhaCungCap  (MaNCC,TenNCC,DiaChi,DienThoai) values ('" + tmancc.Text + "',N'" + ttenncc.Text + "',N'" + tdiachi.Text + "','" + tsdt.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from NhaCungCap");
                lammoi();

            }
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmancc.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã nhà cung cấp ");
                k = 1;
                tmancc.Focus();
            }
            
           
            if (k == 0)
            {
                tmancc.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;

            }
        }
        void lammoi()
        {
            tmancc.Text = null;
            ttenncc.Text = null;
            tdiachi.Text = null;
            tsdt.Text = null;
            tmancc.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmancc.Text = null;
            ttenncc.Text = null;
            tdiachi.Text = null;
            tsdt.Text = null;
            tmancc.Focus();
            xong();
        }

        private void Tsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            tmancc.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenncc.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tdiachi.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tsdt.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmancc.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã nhà cung cấp");
                tmancc.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from NhaCungCap where MaNCC = '" + tmancc.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from NhaCungCap");
                lammoi();
            }
        }
        void xong()
        {
            tmancc.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmancc.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã nhà cung cấp ");
                k = 1;
                tmancc.Focus();
            }
            if (ttenncc.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên nhà cung cấp ");
                k = 1;
                ttenncc.Focus();
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmancc.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k != 1)
                { k = 0; MessageBox.Show("Cập nhật thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update NhaCungCap set TenNCC = N'" + ttenncc.Text + "',DiaChi = N'" + tdiachi.Text + "',DienThoai = '" + tsdt.Text + "' where MaNCC = '" + tmancc.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from NhaCungCap");
                xong();
                lammoi();

            }
        }
    }
}
