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
   
    public partial class chitiethoadonnhap : Form
    {
        public List<string> luutru = new List<string>();
        chucnang data = new chucnang();
        public chitiethoadonnhap()
        {
            InitializeComponent();
            tshdn.TabIndex = 0;
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(10);
            
            tshdn.Enabled = true;
           
          
                  

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Chitiethoadonnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Hoadonnhap' table. You can move, or remove it, as needed.
            this.hoadonnhapTableAdapter.Fill(this.qUANLYGOMSUDataSet.Hoadonnhap);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.DMhanghoa' table. You can move, or remove it, as needed.
            this.dMhanghoaTableAdapter.Fill(this.qUANLYGOMSUDataSet.DMhanghoa);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.ChitietHDN' table. You can move, or remove it, as needed.
            this.chitietHDNTableAdapter.Fill(this.qUANLYGOMSUDataSet.ChitietHDN);
            dgv1.DataSource = data.docbang("select * from ChitietHDN");
            KeyPreview = true;
            cbmahang.SelectedItem = null;
            tshdn.SelectedItem = null;
            xong();
            timxong();

        }
        void tinhtien()
        {
            string sql = "UPDATE dbo.ChitietHDN SET Thanhtien =(Dongia*dbo.ChitietHDN.Soluong)-(Dongia*dbo.ChitietHDN.Soluong*Giamgia)/100";
            data.capnhadulieu(sql);
            dgv1.DataSource = data.docbang("select * from ChitietHDN");
        }
        private void DataGridViewCTHĐN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridViewCTHĐN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;

            tdongia.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            tshdn.Text= dgv1.Rows[i].Cells[0].Value.ToString();
            tsoluong.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            lthanhtien.Text = dgv1.Rows[i].Cells[5].Value.ToString()+"  Đồng";
            cbmahang.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            comboBox1.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            
        }
        
        
        int ktdl()
        {
            int i;
            i = dgv1.CurrentRow.Index;
            int k = 0;
            if (tshdn.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
           
            for (int j = 0; j < dgv1.RowCount - 1; j++)
            {
                
                if (tshdn.Text.Equals(dgv1.Rows[j].Cells[0].Value.ToString().Trim()) && cbmahang.Text.Equals(dgv1.Rows[j].Cells[1].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Đã có thông tin ."); break; }
            }
            return k;

        }
        private void ButtonCAPNHAT_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tshdn.SelectedItem == null)
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
                bcapnhat.Visible = false;
                bxong.Visible = true;
                cbmahang.Enabled = false;
                tshdn.Enabled = false;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv1.Enabled = false;
                btimkiem.Enabled = false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btt_Click(object sender, EventArgs e)
        {
           
        }

        private void Tsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void Tdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Tttien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            
         
            if (ktdl()==0)
            {
                string sql = "insert into ChiTietHDN (SoHDN,mahang,soluong,dongia,giamgia) values ('" + tshdn.Text + "','" + cbmahang.Text + "','" + tsoluong.Text + "','" + tdongia.Text + "','" + comboBox1.Text + "')";
                data.capnhadulieu(sql);
                dgv1.DataSource = data.docbang("select *from ChiTietHDN");
                tinhtien();
                lammoi();
            }
        }
        int xoa()
        {
            
            int k = 0;
            if (tshdn.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }

            return k;

        }
        private void Bxoa_Click(object sender, EventArgs e)
        {
            if(xoa()==0)
            {
                string sql = "delete from ChiTietHDN where soHDN = '" + tshdn.Text + "'and mahang = '" + cbmahang.Text + "'";
                data.capnhadulieu(sql);
                dgv1.DataSource = data.docbang("select *from ChiTietHDN");
                lammoi();
            }
        }
        void lammoi()
        {
            tshdn.Text = null;
            cbmahang.Text = null;
            tsoluong.Text = null;
            tdongia.Text = null;
            comboBox1.SelectedItem = null;
            lthanhtien.Text = null;
            cbmahang.SelectedItem = "";
            tdongia.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tshdn.Text = null;
            cbmahang.Text= null;
            tsoluong.Text = null;
            tdongia.Text = null;
            comboBox1.SelectedItem = null;
            lthanhtien.Text = null;
            cbmahang.SelectedItem = "";
            dgv1.DataSource = data.docbang("select *from ChiTietHDN");
            tshdn.Focus();
            xong();
            timxong();

        }
        
        private void Tdongia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Cbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbmahang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Lthanhtien_Click(object sender, EventArgs e)
        {

        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Tsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tshdn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tdongia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void xong()
        {
            bcapnhat.Visible = true;
            bxong.Visible = false;
            cbmahang.Enabled = true;
            tshdn.Enabled = true;
            bthem.Enabled = true;
            bxoa.Enabled = true;
            dgv1.Enabled = true;
            btimkiem.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tshdn.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            if (cbmahang.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
            for (int j = 0; j < dgv1.RowCount - 1; j++)
            {

                if (tshdn.Text.Equals(dgv1.Rows[j].Cells[0].Value.ToString().Trim()) && k != 1)
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update ChitietHDN set  soluong = '" + tsoluong.Text + "',dongia = '" + tdongia.Text + "',giamgia = '" + comboBox1.Text + "'where SoHDN ='" + tshdn.Text + "' and mahang = '" + cbmahang.Text + "'";
                data.capnhadulieu(sql);
                dgv1.DataSource = data.docbang("select * from ChitietHDN");
                tinhtien();
                xong();
                lammoi();
            }
        }
        void timxong()
        {
            gb1.Visible = true;
            bcapnhat.Visible = true;
            bxong.Visible = false;
            bcapnhat.Enabled = true;
            groupBox1.Visible = true;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv1.Enabled = true;
            btimkiem.Visible = true;
            btim.Visible = false;
            GB.Text = " Hóa đơn ";
        }
        private void Btimkiem_Click(object sender, EventArgs e)
        {
            
            {
                lammoi();
                gb1.Visible = false;
                bcapnhat.Visible = true;
                bxong.Visible = false;
                bcapnhat.Enabled = false;
                groupBox1.Visible = false;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv1.Enabled = false;
                btimkiem.Visible = false;
                btim.Visible = true;
                GB.Text = "Nhập thông tin số hóa đơn hoặc mã hàng cần tìm ";
            }
        }

        private void Btim_Click(object sender, EventArgs e)
        {

            string SoHDN = " select *from TimTheoSoHDN ('" + tshdn.Text + "')";
            string MaHangNhap = " select *from TimTheoMaHangNhap ('" + cbmahang.Text + "')";
            string SoHDNMaHang = "select *from TimTheoSoHDNMaHang ('" + tshdn.Text + "','" + cbmahang.Text + "')";
            int k = 0;

            if (cbmahang.SelectedItem == null && tshdn.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập thông tin cần tìm kiếm");
                k = 1;
                tshdn.Focus();
            }
            if (k == 0)
            {
                if(cbmahang.SelectedItem == null && tshdn.SelectedItem != null)
                {

                    dgv1.DataSource = data.docbang(SoHDN);
                    timxong();
                }
                if (cbmahang.SelectedItem != null && tshdn.SelectedItem == null)
                {

                    dgv1.DataSource = data.docbang(MaHangNhap);
                    timxong();
                }
                if (cbmahang.SelectedItem != null && tshdn.SelectedItem != null)
                {

                    dgv1.DataSource = data.docbang(SoHDNMaHang);
                    timxong();
                }

            }
        }
    }
}
