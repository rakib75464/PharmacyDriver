using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Admin_Update_User : Form
    {
        function fn = new function();
        String query;

        public Admin_Update_User()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Update_User_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        public void clearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            comboBox2.SelectedIndex = -1;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String password = textBox2.Text;
            String dateRegistered = dateTimePicker1.Text;
            String role = comboBox1.Text;
            String status = comboBox2.Text;

            query = "update userTable set username = '"+userName+ "',password = '"+password+ "',dateRegistered = '"+dateRegistered+ "',role = '"+role+ "',status = '"+status+ "' where userName like '" + textBox3.Text + "%'";
            fn.setData(query, "User Details Updated");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String search = textBox3.Text;

            query = "SELECT * FROM userTable WHERE userName LIKE '" + search + "%'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0]; // Assume only one match for simplicity

                // Populate the textboxes and comboboxes with the retrieved data
                textBox1.Text = row["userName"].ToString();
                textBox2.Text = row["password"].ToString();
                dateTimePicker1.Value = DateTime.Parse(row["dateRegistered"].ToString());
                comboBox1.Text = row["role"].ToString();
                comboBox2.Text = row["status"].ToString();
            }
            else
            {
                clearAll(); // Clear fields if no user found
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin_Add_User().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Admin_View_User().Show();
            this.Hide();
        }
    }
}
