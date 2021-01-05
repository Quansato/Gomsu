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
    public partial class congviec : Form
    {
        chucnang data = new chucnang();
        public congviec()
        {
            InitializeComponent();
            tmacv.TabIndex = 0;
        }

        private void Congviec_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from Congviec");
            tmacv.ReadOnly = false;
            xong();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmacv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttencv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tmucluong.Text = dgv.Rows[i].Cells[2].Value.ToString();
            
        }
        void lammoi()
        {
            tmacv.Text = null;
            ttencv.Text = null;
            tmucluong.Text = null;
            tmacv.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmacv.Text = null;
            ttencv.Text = null;
            tmucluong.Text = null;
            tmacv.Focus();
            xong();
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Tmucluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        int ktdl()
        {

            int k = 0;
            if (tmacv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã công việc");
                k = 1;
                tmacv.Focus();
            }
            if (ttencv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên công việc");
                k = 1;
                ttencv.Focus();
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmacv.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã công việc này đã có."); break; }
            }
            return k;

        }
        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into CongViec  (MaCV,TenCV,MucLuong) values ('" + tmacv.Text + "',N'" + ttencv.Text + "',N'" + tmucluong.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from CongViec");
                lammoi();
            }
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã công việc");
                k = 1;
                tmacv.Focus();
            }
           

           
            if (k == 0)
            {
                bSua.Visible = false;
                bxong.Visible = true;
                tmacv.ReadOnly = true;
                bxoa.Enabled = false;
                bthem.Enabled = false;
                dgv.Enabled = false;

            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacv.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã công việc");
                k = 1;
                tmacv.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from CongViec where MaCV = '" + tmacv.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from CongViec");
                lammoi();
            }
        }
        void xong()
        {
            tmacv.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã công việc");
                k = 1;
                tmacv.Focus();
            }
            if (ttencv.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên công việc");
                k = 1;
                ttencv.Focus();
            }

            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmacv.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()) && k!=1)
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công."); break; }
            }
            if (k == 0)
            {
                string sql = "update CongViec set TenCV = N'" + ttencv.Text + "',MucLuong = N'" + tmucluong.Text + "' where MaCV = '" + tmacv.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select * from CongViec");
                xong();
                lammoi();

            }
        }
    }
}
