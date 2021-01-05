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
    public partial class hoadonban : Form
    {
        chucnang data = new chucnang();
        public hoadonban()
        {
            InitializeComponent();
            tshdb.TabIndex = 0;
        }

        private void Hoadonban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qUANLYGOMSUDataSet.Khachhang);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qUANLYGOMSUDataSet.NhanVien);
            dgv.DataSource = data.docbang("select * from Hoadonban");
            cbmanv.SelectedItem = null;
            cbmakhach.SelectedItem = null;
            xong();
            
            
        }
        int ktdl()
        {

            int k = 0;
            if (tshdb.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tshdb.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Số hóa đơn này đã có."); break; }
            }
            return k;

        }
        void tongtien()
        {

            string sql = "UPDATE dbo.HoadonBan SET Tongtien = (SELECT SUM(dbo.ChitietHDB.Thanhtien) FROM dbo.ChitietHDB WHERE dbo.ChitietHDB.SoHDB = '" + tshdb.Text + "' GROUP BY dbo.ChitietHDB.SoHDB) WHERE SoHDB = '" + tshdb.Text + "'";
            data.capnhadulieu(sql);
            dgv.DataSource = data.docbang("select *from HoaDonBan");
        }
        private void DataGridViewHĐB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tshdb.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbmanv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tngayban.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbmakhach.Text = dgv.Rows[i].Cells[3].Value.ToString();
            ltongtien.Text = dgv.Rows[i].Cells[4].Value.ToString() + "  đồng";
            tngayban.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl()==0)
            {
                string sql = " insert into HoaDonBan  (sohdb,manhanvien,ngayban,maKhach) values ('" + tshdb.Text + "','" + cbmanv.Text + "','" + tngayban.Value.ToString() + "','" + cbmakhach.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HoaDonBan");
                tongtien();
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

            tshdb.Text = null;
            cbmanv.SelectedItem = null;
            cbmakhach.SelectedItem = null;
            tngayban.Text = null;
            tshdb.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tshdb.Text = null;
            cbmanv.SelectedItem = null;
            cbmakhach.SelectedItem = null;
            tngayban.Text = null;
            tshdb.Focus();
            xong();
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tshdb.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            
            if (k == 0)
            {
                tshdb.ReadOnly = true;
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
            if (tshdb.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập số hóa đơn bán");
                k = 1;
                tshdb.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from HoaDonBan where soHDB = '" + tshdb.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from HoaDonBan");
                lammoi();
            }
        }

        private void Tshdb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void xong()
        {
            tshdb.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tshdb.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tshdb.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k != 1)
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update HoaDonBan set  manhanvien = '" + cbmanv.Text + "',ngayBAN = '" + tngayban.Value.ToString() + "',makhach = '" + cbmakhach.Text + "'where SoHDB ='" + tshdb.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from HoaDonBan");
                tongtien();
                xong();
                lammoi();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
