using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace BTL
{
    public partial class FTop5 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public FTop5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số năm!!");
            }
            else { 
            da = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_top5";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nam", Convert.ToInt32(textBox1.Text));
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            rptt5 r = new rptt5();
            r.SetDataSource(dt);
            FormIn fbc = new FormIn();
            fbc.crystalReportViewer1.ReportSource = r;
            fbc.ShowDialog();
            }
        }
        private void Loaddl(String sql)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FTop5_Load(object sender, EventArgs e)
        {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-D1SOLVT;Initial Catalog=QUANLYGOMSUN;Integrated Security=True";
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số năm!!");
            }
            else { 
            String sql = "Exec usp_top5 @nam =";
            int dk = 0;
            if (textBox1.Text.Trim() != "")
            {
                dk += Convert.ToInt32(textBox1.Text);
            }
            sql += dk;
            Loaddl(sql);
            }
        }
    }
}
