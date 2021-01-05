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
    public partial class kichthuoc : Form
    {
        chucnang data = new chucnang();
        public kichthuoc()
        {
            InitializeComponent();
            tmakt.TabIndex = 0;
        }

        private void Kichthuoc_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from KichThuoc");
            xong();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgv.CurrentRow.Index;
            tmakt.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenkt.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        int ktdl()
        {

            int k = 0;
            if (tmakt.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã kích thước");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmakt.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Mã Kích thước này đã có."); break; }
            }
            return k;

        }
        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmakt.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã kích thước");
                k = 1;
                tmakt.Focus();
            }
           
            if (k == 0)
            {
                tmakt.ReadOnly = true;
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
                string sql = " insert into KichThuoc (MaKichThuoc,TenKichThuoc) values ('" + tmakt.Text + "',N'" + ttenkt.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from KichThuoc");
                lammoi();
            }
        }
        void lammoi()
        {
            tmakt.Focus();
            ttenkt.Text = null;
            tmakt.Text = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmakt.Focus();
            ttenkt.Text = null;
            tmakt.Text = null;
            xong();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmakt.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã kích thước ");
                k = 1;
                tmakt.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from KichThuoc where MaKichThuoc = '" + tmakt.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from KichThuoc");
                lammoi();
            }
        }
        void xong()
        {
            tmakt.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bxoa.Enabled = true;
            bthem.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmakt.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã kích thước");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmakt.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update KichThuoc set TenKichThuoc = N'" + ttenkt.Text + "' where MaKichThuoc = '" + tmakt.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from KichThuoc");
                xong();
                lammoi();
            }
        }
    }
}
