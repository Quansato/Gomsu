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
    public partial class timkiemsanpham : Form
    {
        
        chucnang data = new chucnang();
        public timkiemsanpham()
        {
            InitializeComponent();
        }

        private void Timkiemsanpham_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonTIMKIEM_Click(object sender, EventArgs e)
        {
           /* string sql = "select Mahang,Tenhanghoa,Tencongdung,Tenloai,Tenloaimen from ((DMhanghoa join CongDung on DMhanghoa.Macongdung=CongDung.Macongdung)join Loai on DMhanghoa.Maloai=Loai.Maloai) join Men on DMhanghoa.Maloaimen=Men.Maloaimen where Mahang is not null";
            if (textBoxCONGDUNG.Text != "")
            {
                sql += " and Tencongdung like N'%" + textBoxCONGDUNG.Text.Trim() + "%'";
            }
            if(textBoxMACONGDUNG.Text != "")
            {
                sql += " and Macongdung like N'%" + textBoxMACONGDUNG.Text.Trim() + "%'";
            }
            if (textBoxLOAIMEN.Text != "")
            {
                sql += " and Tenloaimen like N'%" + textBoxLOAIMEN.Text.Trim() + "%'";
            }
            if (textBoxMALOAIMEN.Text != "")
            {
                sql += " and Maloaimen like N'%" + textBoxMALOAIMEN.Text.Trim() + "%'";
            }
            if (textBoxLOAIHANG.Text != "")
            {
                sql += " and Tenloai like N'%" + textBoxLOAIHANG.Text.Trim() + "%'";
            }
            if (textBoxMALOAI.Text != "")
            {
                sql += " and Maloai like N'%" + textBoxMALOAI.Text.Trim() + "%'";
            }
            dataGridViewTK.DataSource = data.docbang(sql);*/
        }

        private void buttonTIMKIEM_Click_1(object sender, EventArgs e)
        {
            string sql = "select Mahang,Tenhanghoa,Tencongdung,Tenloai,Tenloaimen from ((DMhanghoa join CongDung on DMhanghoa.Macongdung=CongDung.Macongdung)join Loai on DMhanghoa.Maloai=Loai.Maloai) join Men on DMhanghoa.Maloaimen=Men.Maloaimen where Mahang is not null";
            if (textBoxCONGDUNG.Text != "")
            {
                sql += " and Tencongdung like N'%" + textBoxCONGDUNG.Text.Trim() + "%'";
            }
            if (textBoxMACONGDUNG.Text != "")
            {
                sql += " and CongDung.Macongdung like N'%" + textBoxMACONGDUNG.Text.Trim() + "%'";
            }
            if (textBoxLOAIMEN.Text != "")
            {
                sql += " and Tenloaimen like N'%" + textBoxLOAIMEN.Text.Trim() + "%'";
            }
            if (textBoxMALOAIMEN.Text != "")
            {
                sql += " and Men.Maloaimen like N'%" + textBoxMALOAIMEN.Text.Trim() + "%'";
            }
            if (textBoxLOAIHANG.Text != "")
            {
                sql += " and Tenloai like N'%" + textBoxLOAIHANG.Text.Trim() + "%'";
            }
            if (textBoxMALOAI.Text != "")
            {
                sql += " and Loai.Maloai like N'%" + textBoxMALOAI.Text.Trim() + "%'";
            }
            dataGridViewTK.DataSource = data.docbang(sql);
        }

        private void buttonTHOAT_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
                this.Close();
        }

        private void buttonLAMMOI_Click(object sender, EventArgs e)
        {
            textBoxCONGDUNG.Text = "";
            textBoxMACONGDUNG.Text = "";
            textBoxLOAIHANG.Text = "";
            textBoxMALOAI.Text = "";
            textBoxLOAIMEN.Text = "";
            textBoxMALOAIMEN.Text = "";
            dataGridViewTK.DataSource = null;
        }
    }
}
