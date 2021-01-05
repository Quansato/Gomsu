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
    public partial class khachhang : Form
    {
        chucnang data = new chucnang();
        public khachhang()
        {
            InitializeComponent();
            tmakhach.TabIndex = 0;
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Khachhang");
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmakhach.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã khách hàng");
                k = 1;
                tmakhach.Focus();
            }
            if(ttenkhach.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên khách hàng");
                k = 1;
                ttenkhach.Focus();
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmakhach.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã khách hàng này đã có."); break; }
            }
            return k;

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmakhach.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenkhach.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tdiachi.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tsdt.Text = dgv.Rows[i].Cells[3].Value.ToString();

        }

        private void Bthem_Click(object sender, EventArgs e)
        {

            if (ktdl() == 0)
            {
                string sql = " insert into KhachHang  (MaKhach,TenKhach,DiaChi,DienThoai) values ('" + tmakhach.Text + "',N'" + ttenkhach.Text + "',N'" + tdiachi.Text + "','" + tsdt.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from KhachHang");
                lammoi();
               
            }
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        void lammoi()
        {
            tmakhach.Text = null;
            ttenkhach.Text = null;
            tdiachi.Text = null;
            tsdt.Text = null;
            tmakhach.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmakhach.Text = null;
            ttenkhach.Text = null;
            tdiachi.Text = null;
            tsdt.Text = null;
            tmakhach.Focus();
            xong();
        }

        private void Tsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmakhach.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã khách hàng ");
                k = 1;
                tmakhach.Focus();
            }
            
            
            if (k == 0)
            {
                tmakhach.ReadOnly = true;
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
            if (tmakhach.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                k = 1;
                tmakhach.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from KhachHang where MaKhach = '" + tmakhach.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from KhachHang");
                lammoi();
            }
        }
        void xong()
        {
            tmakhach.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {

            int k = 0;
            if (tmakhach.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã khách hàng ");
                k = 1;
                tmakhach.Focus();
            }
            if (ttenkhach.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên khách hàng ");
                k = 1;
                ttenkhach.Focus();
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmakhach.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k!=1)
                { k = 0; MessageBox.Show("Cập nhật thành công."); break; }

            }
            if (k == 0)
            {
                string sql = "update KhachHang set TenKhach = N'" + ttenkhach.Text + "',DiaChi = N'" + tdiachi.Text + "',DienThoai = '" + tsdt.Text + "' where MaKhach = '" + tmakhach.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from KhachHang");
                xong();
                lammoi();

            }
        }
    }
}
