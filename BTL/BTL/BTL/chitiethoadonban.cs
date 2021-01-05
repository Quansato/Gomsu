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
    public partial class chitiethoadonban : Form
    {
        chucnang data = new chucnang();
        public chitiethoadonban()
        {
            InitializeComponent();
            cbgiamgia.Items.Add(5);
            cbgiamgia.Items.Add(10);
        }

        private void Chitiethoadonban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.DMhanghoa' table. You can move, or remove it, as needed.
            this.dMhanghoaTableAdapter.Fill(this.qUANLYGOMSUDataSet.DMhanghoa);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Hoadonban' table. You can move, or remove it, as needed.
            this.hoadonbanTableAdapter.Fill(this.qUANLYGOMSUDataSet.Hoadonban);
            dgv.DataSource = data.docbang("select * from ChitietHDB");
            cbsohdb.SelectedItem = null;
            cbmahang.SelectedItem = null;
            xong();
            timxong();
           
        }

        private void Cbgiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Blammoi_Click(object sender, EventArgs e)
        {
            lammoi();
            xong();
            dgv.DataSource = data.docbang("select *from CHITIetHDB");
            timxong();

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            cbsohdb.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tsoluong.Text = dgv.Rows[i].Cells[2].Value.ToString();
            ltthanhtien.Text = dgv.Rows[i].Cells[4].Value.ToString() + "  Đồng";
            cbmahang.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbgiamgia.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }
        int ktdl()
        {

            int k = 0;
            if (cbsohdb.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
            if (tsoluong.TextLength == 0 && Convert.ToInt32(tsoluong.Text) == 0)
            {
                MessageBox.Show("Hãy nhập số lượng đã bán .");
                k = 1;
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (cbsohdb.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && cbmahang.Text.Equals(dgv.Rows[j].Cells[1].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Đã có thông tin ."); break; }
            }
            return k;
        }
        void tinhtien()
        {
            string sql = "UPDATE dbo.ChitietHDB SET Thanhtien =(DMhanghoa.DonGiaBan*dbo.ChitietHDB.Soluong)-(DonGiaBan*dbo.ChitietHDB.Soluong*Giamgia)/100 FROM dbo.ChitietHDB LEFT JOIN dbo.DMhanghoa ON DMhanghoa.Mahang = ChitietHDB.Mahang";
            data.capnhadulieu(sql);
            dgv.DataSource = data.docbang("select * from ChitietHDB");
        }
        private void BSua_Click(object sender, EventArgs e)
        {

            int k = 0;
          
            if (cbsohdb.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
           
            if (k == 0)
            {
                bSua.Visible = false;
                bxong.Visible = true;
                cbsohdb.Enabled = false;
                cbmahang.Enabled = false;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (cbsohdb.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
            if (k == 0)
            {
                string sql = "delete from ChiTietHDB where soHDB = '" + cbsohdb.Text + "'and mahang = '" + cbmahang.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from ChiTietHDB");
                lammoi();
            }
        }
        void lammoi()
        {
            cbsohdb.Text = null;
            cbmahang.Text = null;
            tsoluong.Text = null;
            cbgiamgia.SelectedItem = null;
            ltthanhtien.Text = null;
            cbsohdb.Focus();

        }
        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = "insert into ChiTietHDB (SoHDB,mahang,soluong,giamgia) values ('" + cbsohdb.Text + "','" + cbmahang.Text + "','" + tsoluong.Text + "','" + cbgiamgia.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from ChiTietHDB");
                tinhtien();
                lammoi();
            }
        }
        void xong()
        {
            bSua.Visible = true;
            bxong.Visible = false;
            cbsohdb.Enabled = true;
            cbmahang.Enabled = true;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }

        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;

            if (cbsohdb.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (cbsohdb.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k!=1)
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update ChitietHDB set  soluong = '" + tsoluong.Text + "',giamgia = '" + cbgiamgia.Text + "'where SoHDB ='" + cbsohdb.Text + "' and mahang = '" + cbmahang.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from ChitietHDB");
                tinhtien();
                xong();
                 
                lammoi();
            }
        }
        void timxong()
        {
            gb1.Visible = true;
            bSua.Visible = true;
            bxong.Visible = false;
            bSua.Enabled = true;
            groupBox1.Visible = true;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
            btimkiem.Visible = true;
            btim.Visible = false;
            GB.Text = "Hóa đơn";
            
        }
        private void Btim_Click(object sender, EventArgs e)
        {
            string SoHDN = " select *from TimTheoSoHDB ('" + cbsohdb.Text + "')";
            string MaHangBan = " select *from TimTheoMaHangBan ('" + cbmahang.Text + "')";
            string SoHDBMaHang = "select *from TimTheoSoHDBMaHang ('" + cbsohdb.Text + "','" + cbmahang.Text + "')";
            int k = 0;

            if (cbmahang.SelectedItem == null && cbsohdb.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập thông tin cần tìm kiếm");
                k = 1;
                cbsohdb.Focus();
            }
            if (k == 0)
            {
                if (cbmahang.SelectedItem == null && cbsohdb.SelectedItem != null)
                {

                    dgv.DataSource = data.docbang(SoHDN);
                    timxong();
                }
                if (cbmahang.SelectedItem != null && cbsohdb.SelectedItem == null)
                {

                    dgv.DataSource = data.docbang(MaHangBan);
                    timxong();
                }
                if (cbmahang.SelectedItem != null && cbsohdb.SelectedItem != null)
                {

                    dgv.DataSource = data.docbang(SoHDBMaHang);
                    timxong();
                }

            }
        }

        private void Btimkiem_Click(object sender, EventArgs e)
        {
            lammoi();
            gb1.Visible = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bSua.Enabled = false;
            groupBox1.Visible = false;
            bxoa.Enabled = false;
            bthem.Enabled = false;
            dgv.Enabled = false;
            btimkiem.Visible = false;
            btim.Visible = true;
            cbsohdb.Focus();
            GB.Text = "Nhập số hóa đơn hoặc mã hàng cần tìm ";
        }
    }
}
