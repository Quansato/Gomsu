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
    public partial class hanghoa : Form
    {
        chucnang data = new chucnang();
        public hanghoa()
        {
            InitializeComponent();
            cbbaohanh.Items.Add(30);
            cbbaohanh.Items.Add(60);
            cbbaohanh.Items.Add(90);
            tmahang.TabIndex = 0;
        }

        private void Hanghoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.nuocSX' table. You can move, or remove it, as needed.
            this.nuocSXTableAdapter.Fill(this.qUANLYGOMSUDataSet.nuocSX);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Mau' table. You can move, or remove it, as needed.
            this.mauTableAdapter.Fill(this.qUANLYGOMSUDataSet.Mau);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Hoavan' table. You can move, or remove it, as needed.
            this.hoavanTableAdapter.Fill(this.qUANLYGOMSUDataSet.Hoavan);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Hinhkhoi' table. You can move, or remove it, as needed.
            this.hinhkhoiTableAdapter.Fill(this.qUANLYGOMSUDataSet.Hinhkhoi);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Men' table. You can move, or remove it, as needed.
            this.menTableAdapter.Fill(this.qUANLYGOMSUDataSet.Men);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.CongDung' table. You can move, or remove it, as needed.
            this.congDungTableAdapter.Fill(this.qUANLYGOMSUDataSet.CongDung);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.KichThuoc' table. You can move, or remove it, as needed.
            this.kichThuocTableAdapter.Fill(this.qUANLYGOMSUDataSet.KichThuoc);
            // TODO: This line of code loads data into the 'qUANLYGOMSUDataSet.Loai' table. You can move, or remove it, as needed.
            this.loaiTableAdapter.Fill(this.qUANLYGOMSUDataSet.Loai);
            dgv.DataSource = data.docbang("select * from DMhanghoa");
            tmahang.Text = null;
            ttenhang.Text = null;
            tghichu.Text = null;
            lsoluong.Text = "0";
            lgiaban.Text = "0";
            lgianhap.Text = "0";
            cbbaohanh.SelectedItem = null;
            cbcongdung.SelectedItem = null;
            cbhinhkhoi.SelectedItem = null;
            cbloaimen.SelectedItem = null;
            cbmahv.SelectedItem = null;
            cbmakt.SelectedItem = null;
            cbmaloai.SelectedItem = null;
            cbmausac.SelectedItem = null;
            cbnuocsx.SelectedItem = null;
            xong();
        }
        int ktdl()
        {

            int k = 0;
            if (tmahang.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập mã hàng");
                k = 1;
            }
            if(ttenhang.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập tên hàng ");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmahang.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 1; MessageBox.Show("mã hàng này đã có."); break; }
            }
            return k;

        }
        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tmahang.Text = dgv.Rows[i].Cells[0].Value.ToString();
            ttenhang.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbmaloai.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cbmakt.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cbcongdung.Text = dgv.Rows[i].Cells[4].Value.ToString();
            cbloaimen.Text = dgv.Rows[i].Cells[5].Value.ToString();
            cbhinhkhoi.Text = dgv.Rows[i].Cells[6].Value.ToString();
            cbmahv.Text = dgv.Rows[i].Cells[7].Value.ToString();
            cbmausac.Text = dgv.Rows[i].Cells[8].Value.ToString();
            cbnuocsx.Text = dgv.Rows[i].Cells[9].Value.ToString();
            lsoluong.Text = dgv.Rows[i].Cells[10].Value.ToString();
            lgianhap.Text = dgv.Rows[i].Cells[11].Value.ToString();
            lgiaban.Text = dgv.Rows[i].Cells[12].Value.ToString();
            cbbaohanh.Text = dgv.Rows[i].Cells[13].Value.ToString();
            tghichu.Text = dgv.Rows[i].Cells[14].Value.ToString();
        }

        private void Bthem_Click(object sender, EventArgs e)
        {
            if(ktdl()==0)
            {
                string sql = "insert into DMHangHoa ( Mahang ,Tenhanghoa ,Maloai ,Makichthuoc ,Macongdung , Maloaimen ,Mahinhkhoi ,MaHoaVan ,Mamau ,ManuocSX ,  Thoigianbaohanhanh , Ghichu) values ('"+tmahang.Text+ "',N'"+ttenhang.Text+ "','"+cbmaloai.Text+ "','"+cbmakt.Text+ "','"+cbcongdung.Text+ "','"+cbloaimen.Text+ "','"+cbhinhkhoi.Text+ "','"+cbmahv.Text+ "','"+cbmausac.Text+ "','"+cbnuocsx.Text+ "','"+cbbaohanh.Text+ "',N'"+tghichu.Text+"')";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("Select * from DMHangHoa");
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
            tmahang.Focus();
            tmahang.Text = null;
            ttenhang.Text = null;
            tghichu.Text = null;
            lsoluong.Text = "0";
            lgiaban.Text = "0";
            lgianhap.Text = "0";
            cbbaohanh.SelectedItem = null;
            cbcongdung.SelectedItem = null;
            cbhinhkhoi.SelectedItem = null;
            cbloaimen.SelectedItem = null;
            cbmahv.SelectedItem = null;
            cbmakt.SelectedItem = null;
            cbmaloai.SelectedItem = null;
            cbmausac.SelectedItem = null;
            cbnuocsx.SelectedItem = null;
        }
        private void Blammoi_Click(object sender, EventArgs e)
        {
            tmahang.Focus();
            tmahang.Text = null;
            ttenhang.Text = null;
            tghichu.Text = null;
            lsoluong.Text = "0";
            lgiaban.Text = "0";
            lgianhap.Text = "0";
            cbbaohanh.SelectedItem = null;
            cbcongdung.SelectedItem = null; 
            cbhinhkhoi.SelectedItem = null;
            cbloaimen.SelectedItem = null;
            cbmahv.SelectedItem = null;
            cbmakt.SelectedItem = null;
            cbmaloai.SelectedItem = null;
            cbmausac.SelectedItem = null;
            cbnuocsx.SelectedItem = null;
            xong();

        }

        private void BSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahang.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
           
            if (k==0)
            {
                tmahang.ReadOnly = true;
                bSua.Visible = false;
                bxong.Visible = true;
                bthem.Enabled = false;
                bxoa.Enabled = false;
                dgv.Enabled = false;
            }
        }

        private void Bxoa_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahang.TextLength == 0)
            {
                k = 1;
                MessageBox.Show("Chưa nhập mã hàng hóa");
                tmahang.Focus();
            }
            if (k == 0)
            {
                string sql = " delete from DMHangHoa where MaHang = '" + tmahang.Text + "'";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from DMHangHoa");
                lammoi();
            }
        }
        void xong()
        {
            tmahang.ReadOnly = false;
            bSua.Visible = true;
            bxong.Visible = false;
            bthem.Enabled = true;
            bxoa.Enabled = true;
            dgv.Enabled = true;
        }
        private void Bxong_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (tmahang.TextLength == 0)
            {
                MessageBox.Show("Hãy nhập số hóa đơn");
                k = 1;
            }
            for (int j = 0; j < dgv.RowCount - 1; j++)
            {

                if (tmahang.Text.Equals(dgv.Rows[j].Cells[0].Value.ToString().Trim()))
                { k = 0; MessageBox.Show("Thay đổi thông tin thành công"); break; }
            }
            if (k == 0)
            {
                string sql = "update DmHangHoa set TenHangHoa = N'" + ttenhang.Text + "',Maloai = '" + cbmaloai.Text + "',MaKichThuoc = '" + cbmakt.Text + "',MaCongDUng = '" + cbcongdung.Text + "',MaLoaiMen = '" + cbloaimen.Text + "',MaHinhKhoi = '" + cbhinhkhoi.Text + "',MaHoaVan = '" + cbmahv.Text + "',MaMau = '" + cbmausac.Text + "',MaNuocSx = '" + cbnuocsx.Text + "',Thoigianbaohanhanh = '" + cbbaohanh.Text + "',Ghichu = N'" + tghichu.Text + "' where MaHang = '" + tmahang.Text + "' ";
                data.capnhadulieu(sql);
                dgv.DataSource = data.docbang("select *from DMHangHoa");
                xong();
                lammoi();
            }
        }
    }
}
