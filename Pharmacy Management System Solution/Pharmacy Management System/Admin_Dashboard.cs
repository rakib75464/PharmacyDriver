using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Admin_Dashboard : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            
            //try
            //{
             query = "select count(role) from userTable where role = 'Admin'";
               ds = fn.getData(query);
                setLabel(ds, label11);
                
                query = "select count(role) from userTable where role = 'Employee'";
                ds = fn.getData(query);
                setLabel(ds, label12);

                query = "select count(role) from userTable where role = 'Customer'";
                ds = fn.getData(query);
                setLabel(ds, label13);
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

            private void setLabel(DataSet ds, Label lbl)
            {
                if (ds.Tables[0].Rows.Count != 0)
                {
                    lbl.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    lbl.Text = "0";
                }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            new Admin_View_User().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Add_User add= new Admin_Add_User();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Admin_Update_User().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}
