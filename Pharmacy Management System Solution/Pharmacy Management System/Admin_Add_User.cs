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
    public partial class Admin_Add_User : Form
    {
        function fn = new function();
        String query;

        public Admin_Add_User()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Admin_Update_User().Show();
            this.Hide();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String password = textBox2.Text;
            String dateRegistered = dateTimePicker1.Text;
            String role = comboBox1.Text;
            String status = comboBox2.Text;

            try
            {
                query = "insert into userTable (userName, password, role, dateRegistered, status) values ('" + userName + "','" + password + "','" + role + "','" + dateRegistered + "','" + status + "')";
                fn.setData(query, "Successfully Added !");
            }
            catch (Exception)
            {
                MessageBox.Show("User Already Exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void Admin_Add_User_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_View_User v = new Admin_View_User();
            v.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Hide();
        }
    }
}
