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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void NhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nhanvien formnhanvien = new nhanvien();
            formnhanvien.Show();
        }

        private void CôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            congviec fromcongviec = new congviec();
            fromcongviec.Show();
        }

        private void KháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            khachhang formkhach = new khachhang();
            formkhach.Show();
        }

        private void NhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhacungcap formncc = new nhacungcap();
            formncc.Show();
        }
        private void HóaĐơnBánToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hoadonban formhdb = new hoadonban();
            formhdb.Show();
        }

        private void ChiTiếtHóaĐơnBánToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chitiethoadonban formcthbd = new chitiethoadonban();
            formcthbd.Show();
        }

        private void HóaĐơnNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hoadonnhap formhdn = new hoadonnhap();
            formhdn.Show();
        }

        private void ChiTiếtHóaĐơnNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chitiethoadonnhap formcthdn = new chitiethoadonnhap();
            formcthdn.Show();
        }

        private void LoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loai formloai = new loai();
            formloai.Show();
        }

        private void KíchThướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kichthuoc formkt = new kichthuoc();
            formkt.Show();
        }

        private void CôngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            congdung formcd = new congdung();
            formcd.Show();
        }

        private void MenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            men formmen = new men();
            formmen.Show();
        }

        private void NướcSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuocsx formnsx = new nuocsx();
            formnsx.Show();
        }

        private void MàuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mausac formmau = new mausac();
            formmau.Show();
        }

        private void HìnhKhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinhkhoi formhinhkhoi = new hinhkhoi();
            formhinhkhoi.Show();
        }

        private void HoaVănToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoavan formhoavan = new hoavan();
            formhoavan.Show();
        }

        private void DMHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hanghoa formhanghoa = new hanghoa();
            formhanghoa.Show();
        }

        private void TìmKiếmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiemsanpham formtimkiemsp = new timkiemsanpham();
            formtimkiemsp.Show();
        }

        private void TìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiemhoadon formtimkiemhd = new timkiemhoadon();
            formtimkiemhd.Show();
        }

        private void TìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


     

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FTop5 f = new FTop5();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBctheoquys f2 = new FBctheoquys();
            f2.Show();
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDShoadon f3 = new FDShoadon();
            f3.Show();
        }

        private void nhânViênBánĐượcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBCnv f4 = new FBCnv();
            f4.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ FB Kiều Huy để được hỗ trợ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
