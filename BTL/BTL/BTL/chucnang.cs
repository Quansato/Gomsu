using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BTL
{
    
    class chucnang
    {
        SqlConnection connection = null;
        string str = @"Data Source=DESKTOP-D1SOLVT;Initial Catalog=QUANLYGOMSUN;Integrated Security=True";
        private void KNDL()
        {
            connection = new SqlConnection(str);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void DKNDL()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public DataTable docbang(string sql)
        {
            DataTable table = new DataTable();
            KNDL();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(table);
            DKNDL();
            return table;
        }
        public void capnhadulieu(string sql)
        {
            KNDL();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            DKNDL();

        }

    }
}
