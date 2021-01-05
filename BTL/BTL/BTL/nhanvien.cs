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
    public partial class nhanvien : Form
    {
        chucnang data = new chucnang();
        public nhanvien()
        {
            InitializeComponent();
            tmanv.TabIndex = 0;
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Congviec' table. You can move, or remove it, as needed.
            this.congviecTableAdapter.Fill(this.qUANLYGOMSUDataSet.Congviec);
            dgv.DataSource = data.docbang("select * from NhanVien");
            cbmacv.SelectedItem = null;
            xong();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
           
            i = dgv.CurrentRow.Index;
            tmanv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbmacv.Text = dgv.Rows[i].Cells[6].Value.ToString();
            ttennv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tngaysinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tsdt.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tdiachi.Text = dgv.Rows[i].Cells[5].Value.ToString();
            ;
            if (Convert.ToBoolean(dgv.Rows[i].Cells[2].Value.ToString()) ==  true)
            {
                rdnam.Checked = true;
            }
            else
                rdnu.Checked = true;

            

        }
        int ktdl()
        {

            int k = 0;
            if (tmanv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã Nhân Viên");
                k = 1;
                tmanv.Focus();
            }
            if (ttennv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên nhân viên");
                k = 1;
                ttennv.Focus();
            }
            if (cbmacv.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã công việc");
                k = 1;
            }
            if(rdnam.Checked == false && rdnu.Checked == false)
            {
                MessageBox.Show("Chọn giới tính nhân viên ");
                k = 1;
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmanv.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã nhân viên này đã có."); break; }
            }
            return k;

        }
        bool sex()
        {
            bool x = false;
            
            if (rdnam.Checked == true)
            {
                x = true;
                
            }
           
            return x;
        }
        private void Bthem_Click(object sender, EventArgs e)
        {

            if (ktdl() == 0)
            {
                string sql = " insert into NhanVien  (MaNhanVien,TenNhanVien,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCV) values ('" + tmanv.Text + "',N'" + ttennv.Text + "',N'" +sex() + "','"+tngaysinh.Value.ToString()+"','"+tsdt.Text+ "',N'"+tdiachi.Text+ "','"+cbmacv.Text+"')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from NhanVien");
                lammoi();

            }
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmanv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã Nhân Viên");
                k = 1;
                tmanv.Focus();
            }
            if (k==0)
            {
                tmanv.ReadOnly = true;
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

        private void Tsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void lammoi()
        {
            tmanv.Text = null;
            ttennv.Text = null;
            cbmacv.SelectedItem = null;
            tsdt.Text = null;
            tdiachi.Text = null;
            tngaysinh.Text = null;
            rdnam.Checked = false;
            rdnu.Checked = false;
            tmanv.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmanv.Text = null;
            ttennv.Text = null;
            cbmacv.SelectedItem = null;
            tsdt.Text = null;
            tdiachi.Text = null;
            tngaysinh.Text = null;
            rdnam.Checked = false;
            rdnu.Checked = false;
            tmanv.Focus();
            xong();
            
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmanv.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã nhân viên");
                tmanv.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from NhanVien where MaNhanVien = '" + tmanv.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from NhanVien");
                lammoi();
            }
        }
        void xong()
        {
            tmanv.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmanv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã Nhân Viên");
                k = 1;
                tmanv.Focus();
            }
            if (ttennv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên nhân viên");
                k = 1;
                ttennv.Focus();
            }
            if (cbmacv.SelectedItem == null)
            {
                MessageBox.Show("Hãy nhập mã công việc");
                k = 1;
            }
            if (rdnam.Checked == false && rdnu.Checked == false)
            {
                MessageBox.Show("Chọn giới tính nhân viên ");
                k = 1;
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmanv.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k != 1)
                { k = 0; MessageBox.Show("Cập nhật thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update NhanVien set TenNhanVien = N'" + ttennv.Text + "',DiaChi = N'" + tdiachi.Text + "',GioiTinh = '" + sex() + "',NgaySinh = '" + tngaysinh.Value.ToString() + "',DienThoai = '" + tsdt.Text + "',MaCV = '" + cbmacv.Text + "' where MaNhanVien = '" + tmanv.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from NhanVien");
                
                xong();
                lammoi();
            }
        }
    }
}
