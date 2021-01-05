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
    public partial class congdung : Form
    {
        chucnang data = new chucnang();
        public congdung()
        {
            InitializeComponent();
            tmacd.TabIndex = 0;
            xong();
        }

        private void Congdung_Load(object sender, EventArgs e)
        {
            dgv.DataSource = data.docbang("select * from CongDung");
        }
        int ktdl()
        {

            int k = 0;
            if (tmacd.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã Công Dụng");
                k = 1;
            }


            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmacd.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("Công Dụng này đã có."); break; }
            }
            return k;

        }
        private void DataGridViewCONGDUNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmacd.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttencd.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacd.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã công dụng");
                k = 1;
            }
            
            if (k == 0)
            {
                bxong.Visible = true;
                bSua.Visible = false;
                tmacd.ReadOnly = true;
                bthem.Enabled = false;
                bxoa.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if (ktdl() == 0)
            {
                string sql = " insert into CongDung (MaCongDung,TenCongDung) values ('" + tmacd.Text + "',N'" + ttencd.Text + "')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from CongDung");
                lammoi();
            }
        }
        void lammoi()
        {
            tmacd.Text = null;
            ttencd.Text = null;
            tmacd.Focus();
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmacd.Text = null;
            ttencd.Text = null;
            tmacd.Focus();
            xong();
        }

        private void Bthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacd.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã công dụng");
                k = 1;
                tmacd.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from CongDung where MaCongDung = '" + tmacd.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from CongDung");
                lammoi();
            }
        }
        void xong()
        {
            bSua.Visible = true;
            bxong.Visible = false;
            tmacd.ReadOnly = false;
            dgv.Enabled = true;
            bxoa.Enabled = true;
            bthem.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmacd.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã công dụng");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmacd.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update CongDung set TenCongDung = N'" + ttencd.Text + "' where MaCongDung = '" + tmacd.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select *from CongDung");
                bSua.Visible = true;
                bxong.Visible = false;
                xong();
                lammoi();
            }
        }
    }
}
