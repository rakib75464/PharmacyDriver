using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    class function
    {
        private SqlCommand Cmd;
        private SqlDataReader reader;
        private SqlConnection con;


        protected SqlConnection getConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-FPM2E5O\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";
            return con;
        }

        public SqlDataReader ReadData(string query)
        {
            
            con= this.getConnection();
            Cmd = new SqlCommand(query, con);
            con.Open();
            //if (con.State == ConnectionState.Closed) { con.Open(); }
            reader = Cmd.ExecuteReader();
            //con.Close();
            return reader;
            
        }
        public DataSet getData(String query)
        {
            con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}