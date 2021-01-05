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
    public partial class hoadonnhap : Form
    {
        chucnang data = new chucnang();
        public hoadonnhap()
        {
            InitializeComponent();
            tsohdn.TabIndex = 0;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hoadonnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qUANLYGOMSUDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Nhacungcap' table. You can move, or remove it, as needed.
            this.nhacungcapTableAdapter.Fill(this.qUANLYGOMSUDataSet.Nhacungcap);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.DMhanghoa' table. You can move, or remove it, as needed.
            this.dMhanghoaTableAdapter.Fill(this.qUANLYGOMSUDataSet.DMhanghoa);
            dgv.DataSource = data.docbang("select * from Hoadonnhap");
            cbmanv.SelectedItem = null;
            cbncc.SelectedItem = null;
            xong();
        }

        private void DataGridViewHĐN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tsohdn.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbmanv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tngaynhap.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbncc.Text = dgv.Rows[i].Cells[3].Value.ToString();
            ltongtien.Text = dgv.Rows[i].Cells[4].Value.ToString() + "  đồng";
        }
        int ktdl()
        {
            
            int k = 0;
            if (tsohdn.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
                tsohdn.Focus();
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tsohdn.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Số hóa đơn này đã có."); break; }
            }
            return k;

        }
        void tongtien()
        {

            string sql = "UPDATE dbo.Hoadonnhap SET Tongtien = (SELECT SUM(dbo.ChitietHDN.Thanhtien) FROM dbo.ChitietHDN WHERE dbo.ChitietHDN.SoHDN = '" + tsohdn.Text + "' GROUP BY dbo.ChitietHDN.SoHDN) WHERE SoHDN = '" + tsohdn.Text + "'";
            data.capnhadulieu(sql);
            dgv.DataSource = data.docbang("select *from HoaDonNhap");
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tsohdn.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
                tsohdn.Focus();
            }
            
            if (k==0)
            {
                tsohdn.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            
            if (ktdl()==0)
            {
                string sql = " insert into HoaDonNhap  (sohdn,manhanvien,ngaynhap,mancc) values ('" + tsohdn.Text + "','" + cbmanv.Text + "','" + tngaynhap.Value.ToString() + "','" + cbncc.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HoaDonNhap");
                tongtien();
                lammoi();
            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if(tsohdn.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập số hóa đơn nhập");
                k = 1;
                tsohdn.Focus();
            }
            if(k==0)
            {
                string sql = " delete from HoaDonNhap where soHDN = '" + tsohdn.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HoaDonNHap");
                lammoi();
            }
        }
        void lammoi()
        {
            tsohdn.Text = null;
            cbmanv.SelectedItem = null;
            cbncc.SelectedItem = null;
            tngaynhap.Text = null;
            tsohdn.Focus();
        }
    
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tsohdn.Text = null;
            cbmanv.SelectedItem = null;
            cbncc.SelectedItem = null;
            tngaynhap.Text = null;
            tsohdn.Focus();
            xong();
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Tsohdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void xong()
        {
            tsohdn.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tsohdn.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tsohdn.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k != 1)
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update HoaDonNHap set  manhanvien = '" + cbmanv.Text + "',ngaynhap = '" + tngaynhap.Value.ToString() + "',mancc = '" + cbncc.Text + "'where SoHDN ='" + tsohdn.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from HoaDonNhap");
                tongtien();
                xong();
                lammoi();
            }
        }
    }
}
